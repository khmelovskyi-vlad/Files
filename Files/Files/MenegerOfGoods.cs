using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class MenegerOfGoods
    {
        public MenegerOfGoods(List<Good> goods)
        {
            this.Goods = goods;
        }
        public List<Good> Goods;
        public void Add()
        {
            Console.WriteLine("Enter good name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter good description");
            var description = Console.ReadLine();
            Console.WriteLine("Enter good price");
            var price = Convert.ToDouble(Console.ReadLine());
            Good good = new Good(name, description, price);
            Goods.Add(good);
        }
        public bool Find(string name)
        {
            foreach (var good in Goods)
            {
                if (good.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove()
        {
            Console.WriteLine("Enter good name");
            var name = Console.ReadLine();
            foreach (var good in Goods)
            {
                if (good.Name == name)
                {
                    Goods.Remove(good);
                    return;
                }
            }
        }
        public void Change()
        {
            Console.WriteLine("Enter good name");
            var name = Console.ReadLine();
            foreach (var good in Goods)
            {
                if (good.Name == name)
                {
                    Console.WriteLine("Enter good name");
                    good.Name = Console.ReadLine();
                    Console.WriteLine("Enter good description");
                    good.Description = Console.ReadLine();
                    Console.WriteLine("Enter good price");
                    good.Price = Convert.ToDouble(Console.ReadLine());
                    return;
                }
            }
        }
    }
}
