using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class Category  : MappableModel
    {
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public ObservableCollection<Category> SubCategories { get; set; }
    }
}
