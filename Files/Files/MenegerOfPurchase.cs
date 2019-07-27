using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class MenegerOfPurchase
    {
        public MenegerOfPurchase(MenegerOfGoods menegerOfGoods, List<Purchase> purchases)
        {
            this.MenegerOfGoods = menegerOfGoods;
            this.Purchases = purchases;
        }
        public MenegerOfGoods MenegerOfGoods;
        public List<Purchase> Purchases;
        private bool findGood;
        public bool Find(string name)
        {
            for (int i = 0; i < 6; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("You are stupid");
                    Console.WriteLine("Don`t have your good");
                    return false;
                }
                findGood = MenegerOfGoods.Find(name);
                if (findGood)
                {
                    break;
                }
                Console.WriteLine("Don`t have this good");
            }
            return true;
        }
        public Purchase Add(string name)
        {
            Console.WriteLine("Enter good count");
            var count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your telephon number");
            var telephonNumber = Console.ReadLine();
            Console.WriteLine("Enter your e-mail");
            var eMail = Console.ReadLine();
            Purchase purchase = new Purchase(name, count, telephonNumber, eMail);
            return purchase;
        }


    }
}
