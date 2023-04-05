using Rx.AzDo.BaseObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.DistributedTask.VariableGroups
{
    public class TfsVariableGroups : TfsObjectBase
    {
        [JsonPropertyName("variables")]
        public List<KeyValuePair<String,TfsVariableValueInVariableGroups>> Variables { get; set; } = new();

        [JsonPropertyName("variableGroupProjectReferences")]
        public List<TfsVariableGroupProjectReference> VariableGroupProjectReferences { get; set; } = new();
    }
}
