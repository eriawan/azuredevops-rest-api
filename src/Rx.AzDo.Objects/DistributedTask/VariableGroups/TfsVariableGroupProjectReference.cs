using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.DistributedTask.VariableGroups
{
    public class TfsVariableGroupProjectReference
    {
        [JsonPropertyName("id")]
        public String Id { get; set; } = "";

        [JsonPropertyName("name")]
        public String Name { get; set; } = "";
    }
}
