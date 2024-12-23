namespace DatabaseApi.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActivated { get; set; }
        public int Rank { get; set; }
    }
}