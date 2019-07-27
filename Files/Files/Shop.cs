using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Shop
    {
        public List<Good> goods = new List<Good>();
        public List<Purchase> purchases = new List<Purchase>();
        private GoodStore goodStore = new GoodStore("C:\\temp\\Goods");
        public void Run()
        {
            if (goodStore.IsGoodsStored())
            {
                goods = goodStore.GetGoods().ToList();
            }
            while (true)
            {
                Console.WriteLine("Select a mode");
                Console.WriteLine("If you want to see good mode, click G, if you want to see purchase mode, click P, if you want exit this program, click Escape");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.G)
                {
                    RunGood();
                }
                if (key.Key == ConsoleKey.P)
                {
                    RunPurchase();
                }
                if(key.Key == ConsoleKey.Escape)
                {
                    throw new OperationCanceledException();
                }
                goodStore.SaveGoods(goods);
            }

        }
        public void RunGood()
        {
            MenegerOfGoods menegerOfGoods = new MenegerOfGoods(goods);
            Console.WriteLine("If you want to add new good, click G if you want to delete good click D, if you want ro change good click C, if you want exit this program click Escape");
            var key = Console.ReadKey(true);
            if(key.Key == ConsoleKey.G)
            {
                menegerOfGoods.Add();
            }
            if(key.Key == ConsoleKey.D)
            {
                menegerOfGoods.Remove();
            }
            if(key.Key == ConsoleKey.C)
            {
                menegerOfGoods.Change();
            }
            if(key.Key == ConsoleKey.Escape)
            {
                throw new OperationCanceledException();
            }


        }
        public void RunPurchase()
        {
            MenegerOfGoods menegerOfGoods = new MenegerOfGoods(goods);
            MenegerOfPurchase menegerOfPurchase = new MenegerOfPurchase(menegerOfGoods, purchases);
            Console.WriteLine("Enter good name");
            var name = Console.ReadLine();
            if (menegerOfPurchase.Find(name))
            {
                purchases.Add(menegerOfPurchase.Add(name));
            }



        }
    }
}
