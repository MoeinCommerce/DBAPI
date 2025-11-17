// System
using System.Collections.ObjectModel;
using System.Numerics;


namespace DatabaseApi.Models
{
    public class Category  : MappableModel
    {
        public string Description { get; set; }
        public string ParentId { get; set; }
        public string ParentWebId { get; set; }
        public ObservableCollection<Category> SubCategories { get; set; }
    }
}
