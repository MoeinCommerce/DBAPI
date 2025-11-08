using System.Numerics;

namespace DatabaseApi.Models
{
    public class VariableModel
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public BigInteger VariableWebId { get; set; }
        public int VariationId { get; set; }
        public BigInteger VariationWebId { get; set; }
        public int TargetWeb { get; set; }
    }
}
