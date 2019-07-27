using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Purchase
    {
        public Purchase(string name, int count, string telephonNumber, string eMail)
        {
            this.Name = name;
            this.Count = count;
            this.TelephonNumber = telephonNumber;
            this.EMail = eMail;
        }
        public string Name { get; set; }
        public int Count { get; set; }
        public string TelephonNumber { get; set; }
        public string EMail { get; set; }
    }
}
