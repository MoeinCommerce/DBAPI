using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApi.Models
{
    public class AttributeValueModel
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        // public int ValueId { get; set; }
        public string Value { get; set; }
        public bool IsSelected { get; set; } = true;
    }
}
