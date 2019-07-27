using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class GoodStore
    {
        public GoodStore(string adress)
        {
            this.adress = adress;
        }

        private string adress;
        private string FilePath { get { return Path.Combine(adress, "goods.json"); } }

        public IEnumerable<Good> GetGoods()
        {
            var goodsJson = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<Good>>(goodsJson);

        }
        public void SaveGoods(IEnumerable<Good> goods)
        {
            var goodsJson = JsonConvert.SerializeObject(goods);
            File.WriteAllText(FilePath, goodsJson);
        }
        public bool IsGoodsStored()
        {
            return File.Exists(FilePath);
        }
    }
}
