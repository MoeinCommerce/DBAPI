using System.Numerics;

namespace DatabaseApi.Models
{
    public class VariableModel
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public string VariableWebId { get; set; }
        public int VariationId { get; set; }
        public string VariationWebId { get; set; }
        public int TargetWeb { get; set; }
    }
}
