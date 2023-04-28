using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.Build.Definitions
{
    public class TfsBuildDefinition
    {
        [JsonPropertyName("_links")]
        public TfsBuildDefinitionReferenceLinks ReferenceLinks { get; set; } = new TfsBuildDefinitionReferenceLinks();

        [JsonPropertyName("quality")]
        public String Quality { get; set; } = "definition";

    }
}
