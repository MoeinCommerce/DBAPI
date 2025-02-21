namespace DatabaseApi.Models
{
    public class DbConfig
    {
        public string Key { get; set; }
        public string DefaultValue { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsProtected { get; set; }
        public string Description { get; set; }
    }
}