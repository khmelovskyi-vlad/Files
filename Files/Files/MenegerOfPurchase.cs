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
        public (string name, bool isName)FindName()
        {
            Console.WriteLine("Enter good name");
            for (int i = 0; i < 6; i++)
            {
                var name = Console.ReadLine();
                if (i == 5)
                {
                    Console.WriteLine("You are stupid");
                    Console.WriteLine("Don`t have your good");
                    return (name, false);
                }
                if (MenegerOfGoods.Find(name))
                {
                    return (name, true);
                }
                Console.WriteLine("Don`t have this good, write new please");
            }
            return ("", false);
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
