using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string cotegoryName { get; set; }
        public string ShortDisc { get; set; }
        public string LongDisc { get; set; }
        public string img { get; set; }
        public ushort price { get; set;}
        public bool isFovarite { get; set; }
        public bool aleLable { get; set; }
        public int cotegoryID { get; set; }
        public virtual Category category { set; get; }

    }
}
