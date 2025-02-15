using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class CollectionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TargetWebId { get; set; }
        public ObservableCollection<AttributeModel> Attributes { get; set; }
    }
}
