namespace DatabaseApi.Models
{
    public class CollectionProductModel
    {
        public string Id { get; set; }
        public CollectionModel Collection { get; set; }
        public Product Product { get; set; }
    }
}
