using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wristband.Models
{
    public class WristbandModel
    {
        public int ID { get; set; }
        public string  productcode { get; set; }
        public string productname { get; set; }
        public double  price { get; set; }
        public List<string> colors = new List<string>();
        public List<string> btnimg = new List<string>();
        public List<string> frmimg = new List<string>();
    }
}
