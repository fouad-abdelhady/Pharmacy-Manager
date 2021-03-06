﻿using Pharmay0._0._2.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmay0._0._2.Database.ClassesDatabaseOperations
{

    public class OrdersOperations
    {
        private MedicienOperations mo;
        private DatabaseManager dbManager;
        private OleDbCommand comand;
        private DatabaseOperations inserUpdatetObj;

        public OrdersOperations()
        {
            this.dbManager = DatabaseManager.getDatabaseMangmentObj();
            this.comand = new OleDbCommand();
            this.mo = new MedicienOperations();
            inserUpdatetObj = new DatabaseOperations();
        }

        public void addOrder(Orders order)
        {

            int orderId = insertOrder(order);
            if (orderId == -1)
            {
                MessageBox.Show("Some Error Happend While inserting The order");
                return;
            }
            updateCustomerDebtValue(order);
            order.OrderId = orderId;
            inserOrderMeds(order);
        }

        private void updateCustomerDebtValue(Orders order)
        {
            if (order.Paid)
                return;

            double dept = order.Customer.DebtValue + (order.TotalPrice - order.PaidAmount);
            string query =
            "UPDATE DebtCustomers SET {0} = {1} WHERE {2} = {3}";

            query = string.Format(query,
               DatabaseVars.DEBT_VALUE, dept,
               DatabaseVars.CUSTOMER_ID, order.Customer.CustomerID);
            inserUpdatetObj.inserUpdatetData(query);
        }

        private void inserOrderMeds(Orders order)
        {
            foreach (MedAndOrder mao in order.ListOfMeds)
            {
                if (mao.Medicen.IsItOld)
                {
                    // updateMedAmountInOldMed(mao);
                    subtractAmountFromOldInventory(mao);
                }
                 updateMedAmount(mao, false);
                addToMedsAndOrds(mao, order.OrderId);
            }
        }


        #region enhanced insertion


        private void subtractAmountFromOldInventory(MedAndOrder mao)
        {
            string query = "";
            int newNumOfTabs = mao.Medicen.Oldmed.RemainingAmount - mao.NumOfTabes;
            if (newNumOfTabs > 0)
            {
                query = "UPDATE OldMeds SET {0} = {1} WHERE {2} = {3}";
                query = string.Format(query,
                    DatabaseVars.REMAINING_AMOUNT, newNumOfTabs,
                    DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
            }
            else if (newNumOfTabs == 0)
            {
                query = "DELETE FROM OldMeds WHERE {0} ='{1}' AND {2} = {3};";
                query = string.Format(query,
                    DatabaseVars.PARCODE, mao.Medicen.Oldmed.PareCode,
                    DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
            }
            else
            {
                subtractAmountFromOldMeds(newNumOfTabs*-1, mao);
                return;
            }

            inserUpdatetObj.inserUpdatetData(query);
        }


        private int subtractAmountFromOldMeds(int newNumOfTabs, MedAndOrder mao)
        {
            // doda the right hand side is done :)
            int temp;
            string query;
            ArrayList oldMeds = new ArrayList();
            newNumOfTabs *= -1;
            if (deletOldMed(mao.Medicen.Oldmed))
                oldMeds = mao.Medicen.OldmedsList;
            else
                return -1;

            foreach (OldMed om in oldMeds)
            {
                #region loop body 

                temp = om.RemainingAmount - newNumOfTabs;
                if (temp > 0) {
                    query = "UPDATE OldMeds SET {0} = {1} WHERE {2} = {3}";
                    query = string.Format(query,
                        DatabaseVars.REMAINING_AMOUNT, newNumOfTabs,
                        DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
                    inserUpdatetObj.inserUpdatetData(query);

                    return 0;
                }
                else if (temp == 0)
                {
                    query = "DELETE FROM OldMeds WHERE {0} ='{1}' AND {2} = {3};";
                    query = string.Format(query,
                        DatabaseVars.PARCODE, mao.Medicen.Oldmed.PareCode,
                        DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
                    inserUpdatetObj.inserUpdatetData(query);
                    return 0;
                }
                else
                {
                    query = "DELETE FROM OldMeds WHERE {0} ='{1}' AND {2} = {3};";
                    query = string.Format(query,
                        DatabaseVars.PARCODE, mao.Medicen.Oldmed.PareCode,
                        DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
                    inserUpdatetObj.inserUpdatetData(query);
                    newNumOfTabs = temp * -1;
                }

                #endregion

            }
            return newNumOfTabs;
        }


        private bool deletOldMed(OldMed om)
        {
            string query = "DELETE FROM OldMeds WHERE {0} ='{1}' AND {2} = {3};";
            query = string.Format(query,
                DatabaseVars.PARCODE, om.PareCode,
                DatabaseVars.ID, om.Id1);
            return inserUpdatetObj.inserUpdatetData(query);
        }

        private void checkNewAmountAvaliablity(MedAndOrder mao)
        {            
            mo.getOldMeds(mao.Medicen) ;
            ArrayList oldMeds = mao.Medicen.OldmedsList;

            if(oldMeds.Count == 0)
                updateMedAmount(mao, true);

            int totalOld = getOldSum(oldMeds);
            int newAmount = mao.Medicen.NumOfTabes - totalOld;
            int remaingAmount = newAmount - mao.NumOfTabes;

            if (remaingAmount > 0)
            {
                updateMedAmount(mao, true);
            }
            else if (remaingAmount == 0)
            {
                deletOldMed((OldMed)oldMeds[oldMeds.Count - 1]);
                updateMedAmount(mao, true);               
            }
            else {
                subtractAmountFromNewAndOld(remaingAmount * -1, mao);
            }

        }

        private void subtractAmountFromNewAndOld(int reqiredAmount, MedAndOrder mao)
        {
            int temp;
            int counter = 0;
           // int newNumOfTabs = mao.NumOfTabes;
            

            foreach (OldMed om in mao.Medicen.OldmedsList)
            {
                #region loop body 

                temp = om.RemainingAmount - reqiredAmount;

                if (temp > 0)
                {
                    deletOldMed(om);
                    updateMedAmount(mao, true);
                    return;
                }
                else if (temp == 0)
                {
                    deletOldMed(om);
                    try
                    {
                        deletOldMed((OldMed)mao.Medicen.OldmedsList[counter + 1]);
                    }
                    catch (Exception e) {

                    }
                    updateMedAmount(mao, true);
                    return;
                }
                else
                {
                    deletOldMed(om);
                    reqiredAmount = temp * -1;
                }

                counter++;

                #endregion
            }
        }

        private int getOldSum(ArrayList oldMeds)
        {
            int sum = 0;
            foreach (OldMed om in oldMeds) {
                sum += om.RemainingAmount;
            }
            return sum;
        }

        #endregion




        private void updateMedAmountInOldMed(MedAndOrder mao)
        {
            string query;
            int newNumOfTabs = mao.Medicen.Oldmed.RemainingAmount - mao.NumOfTabes;

            if (newNumOfTabs <= 0)
            {
                query = "DELETE FROM OldMeds WHERE {0} ='{1}' AND {2} = {3};";
                query = string.Format(query,
               DatabaseVars.PARCODE, mao.Medicen.Oldmed.PareCode,
               DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
            }
            else
            {

                query = "UPDATE OldMeds SET {0} = {1} WHERE {2} = {3}";
                query = string.Format(query,
                   DatabaseVars.REMAINING_AMOUNT, newNumOfTabs,
                   DatabaseVars.ID, mao.Medicen.Oldmed.Id1);
            }

            inserUpdatetObj.inserUpdatetData(query);
        }
        private void addToMedsAndOrds(MedAndOrder mao, int orderId)
        {
            double numOfPackages = (double)mao.NumOfTabes / (double)mao.Medicen.TabPerPackage;
            string query = "INSERT INTO MedsAndOrds ({0},{1},{2},{3},{4}) VALUES('{5}',{6},{7},{8},{9});";
            query = string.Format(query,
            DatabaseVars.PARCODE,
            DatabaseVars.ORDER_ID,
            DatabaseVars.NUMBER_OF_TABES,
            DatabaseVars.NUMBER_OF_PACKAGES,
            DatabaseVars.TYPE_TOTAL_PRICE,
            mao.Medicen.Parecode,
            orderId,
            mao.NumOfTabes,
            numOfPackages,
            mao.TotalPrice);

            inserUpdatetObj.inserUpdatetData(query);
        }

        private void updateMedAmount(MedAndOrder mao, bool skip)
        {
            int newNumOfTabs = mao.Medicen.NumOfTabes - mao.NumOfTabes;
            if (!mao.Medicen.IsItOld && !skip) {
                checkNewAmountAvaliablity(mao);
                return; 
            }
            string query =
            "UPDATE Meds SET {0} = {1} WHERE {2} = '{3}'";
            query = string.Format(query,
               DatabaseVars.NUMBER_OF_TABES, newNumOfTabs,
               DatabaseVars.PARCODE, mao.Medicen.Parecode);
            inserUpdatetObj.inserUpdatetData(query);
        }

        

        private int insertOrder(Orders order)
        {
            string query = "INSERT INTO Orders ({0},{1},{2},{3},{4}) VALUES('{5}',{6},{7},{8},{9});";
            query = string.Format(query,
            DatabaseVars.ORDER_DATE,
            DatabaseVars.TOTAL_PRICE,
            DatabaseVars.PAID_AMOUNT,
            DatabaseVars.CUSTOMER_ID,
            DatabaseVars.PAID,
            order.OrderDate,
            order.TotalPrice,
            order.PaidAmount,
            order.Customer.CustomerID,
            order.Paid);
            return inserUpdatetObj.inserUpdatetData(query, 0);
        }

        public List<Orders> getAllOrders(string query)
        {
            List<Orders> rescentOrders = new List<Orders>();
            Orders order = new Orders();
            OleDbConnection dbConnection = dbManager.openDb();
            this.comand.Connection = dbConnection;
            comand.CommandText = query;
            OleDbDataReader result = comand.ExecuteReader();

            while (result.Read())
            {
                order.OrderId = result.GetInt32(0);
                order.OrderDate = result.GetDateTime(1);
                order.TotalPrice = (double)result.GetDecimal(2);
                order.PaidAmount = (double)result.GetDecimal(3);
                order.Customer.CustomerID = result.GetInt32(4);
                if (order.Customer.CustomerID != -1)
                    order.Customer.CustomerName = result.GetString(5);
                order.Paid = result.GetBoolean(6);
                order.DebtValue = (double)result.GetDouble(7);
                rescentOrders.Add(order);
                order = new Orders();
            }

            result.Close();
            dbManager.closeDb();
            return rescentOrders;
        }

        internal bool deleteOrders(DateTime value, string v)
        {

            string query = "DELETE FROM Orders WHERE OrderDate < #{0}#;";
            query = string.Format(query, value);
            return inserUpdatetObj.inserUpdatetData(query);
        }

        public void getOrderMedsInfo(Orders order)
        {
            string query = "SELECT * FROM OrderDetails WHERE {0} = {1} ;";
            query = string.Format(query, DatabaseVars.ORDER_ID, order.OrderId);
            MedAndOrder mao = new MedAndOrder();
            mao.setMedOpj();
            OleDbConnection dbConnection = dbManager.openDb();
            this.comand.Connection = dbConnection;
            comand.CommandText = query;
            OleDbDataReader result = comand.ExecuteReader();

            while (result.Read())
            {

                mao.OrderId = result.GetInt32(0);
                mao.Medicen.MedName = result.GetString(1);
                mao.Medicen.Parecode = result.GetString(2);
                mao.NumOfTabes = result.GetInt16(3);
                mao.TotalPrice = (double)result.GetDecimal(4);

                order.ListOfMeds.Add(mao);
                mao = new MedAndOrder();
                mao.setMedOpj();
            }
            result.Close();
            dbManager.closeDb();
        }

        public bool setOrderToPaid(Orders order)
        {
            string query =
            "UPDATE Orders SET CustomerID = -1, Paid = true, PaidAmount = {0} WHERE OrderID = {1}";
            query = string.Format(query, order.TotalPrice, order.OrderId);
            return inserUpdatetObj.inserUpdatetData(query);
        }

        public void getCustomerUnPaidOrders(Customers customer)
        {
            string query = "SELECT * FROM UnpaidOrders WHERE CustomerID = {0} ;";
            query = string.Format(query, customer.CustomerID);
            Orders order = new Orders();
            OleDbConnection dbConnection = dbManager.openDb();
            this.comand.Connection = dbConnection;
            comand.CommandText = query;
            OleDbDataReader result = comand.ExecuteReader();

            while (result.Read())
            {

                order.OrderId = result.GetInt32(0);
                order.OrderDate = result.GetDateTime(2);
                order.TotalPrice = (double)result.GetDecimal(3);
                order.PaidAmount = (double)result.GetDecimal(4);
                order.DebtValue = (double)result.GetDecimal(5);

                customer.addCustomerOrder(order);
                order = new Orders();
            }
            result.Close();
            dbManager.closeDb();
        }

        public List<Orders> getDaySales(DateTime dayDate)
        {

            DateTime today = new DateTime();
            today = DateTime.Today;
            string query = "Select * FROM DaySalesQ WHERE OrderDate BETWEEN #{0}# AND #{1}# ;";
            query = string.Format(query, today, dayDate);
            List<Orders> daysSalesList = new List<Orders>();
            Orders order = new Orders();

            OleDbConnection dbConnection = dbManager.openDb();
            this.comand.Connection = dbConnection;
            comand.CommandText = query;
            OleDbDataReader result = comand.ExecuteReader();

            while (result.Read())
            {

                order.OrderId = result.GetInt32(0);
                order.OrderDate = result.GetDateTime(1);
                order.TotalPrice = (double)result.GetDecimal(2);
                order.PaidAmount = (double)result.GetDecimal(3);
                order.DebtValue = result.GetDouble(4);

                daysSalesList.Add(order);
                order = new Orders();
            }
            result.Close();
            dbManager.closeDb();

            return daysSalesList;
        }
        public double csd(string value)
        {
            return double.Parse(Regex.Replace(value, "[^0-9.]", ""));
        }
    }
}
