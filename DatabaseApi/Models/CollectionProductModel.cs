using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class CollectionProductModel
    {
        public int Id { get; set; }
        public CollectionModel Collection { get; set; }
        public Product Product { get; set; }
    }
}
