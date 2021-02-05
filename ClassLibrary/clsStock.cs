using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string modelNo { get; set; }
        public DateTime releaseDate { get; set; }
        public double netWeight { get; set; }
        public double grossWeight { get; set; }
        public bool visible { get; set; }
    }
}
