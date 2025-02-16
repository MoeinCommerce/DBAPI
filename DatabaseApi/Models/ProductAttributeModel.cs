using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class ProductAttributeModel
    {
        public bool IsMapped { get; set; }
        public CollectionModel Collection { get; set; }
        public Product Product { get; set; }
        public ObservableCollection<AttributeModel> Attributes { get; set; }
        public List<AttributeValueModel> AttributeValues { get; set; }
    }
}
