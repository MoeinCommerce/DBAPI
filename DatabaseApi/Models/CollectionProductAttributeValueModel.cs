using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class CollectionProductAttributeValueModel
    {
        public CollectionProductModel CollectionProduct { get; set; }
        public AttributeValueModel AttributeValue { get; set; }
    }
}
