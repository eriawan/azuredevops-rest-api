using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.DistributedTask.VariableGroups
{
    public class TfsVariableValueInVariableGroups
    {
        [JsonPropertyName("value")]
        public String? Value { get; set; }

        [JsonPropertyName("isSecret")]
        public bool IsSecret { get; set; } = false;
    }
}
