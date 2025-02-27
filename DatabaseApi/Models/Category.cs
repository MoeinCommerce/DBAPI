// System
using System.Collections.ObjectModel;


namespace DatabaseApi.Models
{
    public class Category  : MappableModel
    {
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? ParentWebId { get; set; }
        public ObservableCollection<Category> SubCategories { get; set; }
    }
}
