using System.Numerics;

namespace DatabaseApi.Models
{
    public class VariableModel
    {
        public string Id { get; set; }
        public string CollectionId { get; set; }
        public string VariableWebId { get; set; }
        public string VariationId { get; set; }
        public string VariationWebId { get; set; }
        public int TargetWeb { get; set; }
    }
}
