namespace DatabaseApi.Models
{
    public class VariableModel
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public int VariableWebId { get; set; }
        public int VariationId { get; set; }
        public int VariationWebId { get; set; }
        public int TargetWeb { get; set; }
    }
}
