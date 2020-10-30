using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmay0._0._2.Classes
{
    class ProductData
    {
        public string Notation { get; set; }

        public string Dev1Name { get; set; }
        public string Dev2Name { get; set; }

        public string Dev1Mobile { get; set; }
        public string Dev2Mobile { get; set; }

        public string Dev1Email { get; set; }
        public string Dev2Email { get; set; }

        public string FacebookLink { get; set; }
        public string CopyID { get; set; }

        private static ProductData productDataObj = null;

        private static string CONFIG_DIR = "Config.json";
        private ProductData() {
             
        }

        public static ProductData getPorductDataObj() {
            if (productDataObj == null)
                Read();
            return productDataObj;
        }

        private static void Read()
        {
           
            using (StreamReader Filejosn = new StreamReader(CONFIG_DIR))
            {
                 productDataObj = JsonConvert.DeserializeObject<ProductData>(Filejosn.ReadToEnd());                
            }
           
        }

        public static bool update() {
            try {
               
                string output = JsonConvert.SerializeObject(productDataObj, Formatting.Indented);
                File.WriteAllText(CONFIG_DIR, output);
                return true;
            }
            catch (Exception e) {
                return false;
            }
            
        }
    }
}
