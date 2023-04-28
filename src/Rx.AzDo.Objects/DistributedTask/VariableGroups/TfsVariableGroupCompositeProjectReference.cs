using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.DistributedTask.VariableGroups
{
    public class TfsVariableGroupCompositeProjectReference
    {
        [JsonPropertyName("projectReference")]
        public TfsVariableGroupProjectReference ProjectReference { get; set; } = new();

        [JsonPropertyName("name")]
        public String Name { get; set; } = "";
    }
}
