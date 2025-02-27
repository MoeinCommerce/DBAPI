// System
using System.Collections.ObjectModel;


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
