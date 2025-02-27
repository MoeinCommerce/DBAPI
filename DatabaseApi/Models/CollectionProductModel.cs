namespace DatabaseApi.Models
{
    public class CollectionProductModel
    {
        public int Id { get; set; }
        public CollectionModel Collection { get; set; }
        public Product Product { get; set; }
    }
}
