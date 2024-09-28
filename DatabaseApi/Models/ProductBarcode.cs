using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class ProductBarcode
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Text { get; set; }
    }
}
