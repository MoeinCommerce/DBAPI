// System
using System;
using System.Numerics;


namespace DatabaseApi.Models
{
    public class MappableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BigInteger? WebId { get; set; }
        public string WebName { get; set; }
        public int? TargetWeb { get; set; }
        public DateTime? LastUpdate { get; set; }
        public bool? UpdateRequired { get; set; }
    }
}
