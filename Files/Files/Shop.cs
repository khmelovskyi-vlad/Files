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
        private GoodStore goodStore = new GoodStore("D:\\temp\\Goods");
        private PurchaseStore purchaseStore = new PurchaseStore("D:\\temp\\Purchase\\");
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
                    goodStore.SaveGoods(goods);
                }
                if (key.Key == ConsoleKey.P)
                {
                    if (RunAndFindPurchase())
                    {
                        purchaseStore.SaveLastPurchase(purchases);
                    }
                }
                if(key.Key == ConsoleKey.Escape)
                {
                    throw new OperationCanceledException();
                }
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
        public bool RunAndFindPurchase()
        {
            MenegerOfGoods menegerOfGoods = new MenegerOfGoods(goods);
            MenegerOfPurchase menegerOfPurchase = new MenegerOfPurchase(menegerOfGoods, purchases);
            var (name, isName) = menegerOfPurchase.FindName();
            if (isName)
            {
                purchases.Add(menegerOfPurchase.Add(name));
            }
            return isName;
        }
    }
}
