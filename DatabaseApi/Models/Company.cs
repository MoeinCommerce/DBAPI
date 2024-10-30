namespace DatabaseApi.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public byte[] Logo { get; set; }
    }
}