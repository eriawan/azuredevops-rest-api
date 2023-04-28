using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.Build.Definitions
{
    public class TfsBuildDefinitionReferenceLinks
    {
        [JsonPropertyName("self")]
        public TfsBuildDefinitionHrefLink Self { get; set; } = new();

        [JsonPropertyName("web")]
        public TfsBuildDefinitionHrefLink? Web { get; set; } = new();

        [JsonPropertyName("editor")]
        public TfsBuildDefinitionHrefLink? Editor { get; set; }

        [JsonPropertyName("badge")]
        public TfsBuildDefinitionHrefLink? Badge { get; set; }
    }
}
