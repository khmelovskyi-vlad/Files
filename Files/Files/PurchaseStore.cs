using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class PurchaseStore
    {
        public PurchaseStore(string adress)
        {
            this.adress = adress;
        }
        private string adress { get; set; }
        public void SaveLastPurchase(IEnumerable<Purchase> purchases)
        {
            var lastGood = purchases.ElementAt(purchases.Count() - 1);
            var nameGood = lastGood.Name;
            var purchasJson = JsonConvert.SerializeObject(lastGood);
            int numPurchase = 1;
            while (true)
            {
                var filePath = $"{adress}{nameGood}{numPurchase}.json";
                if (IsPurchaseStored(filePath))
                {
                    numPurchase++;
                    continue;
                }
                File.WriteAllText(filePath, purchasJson);
                break;
            }
        }
        private bool IsPurchaseStored(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}
