using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.Build.Definitions
{
    public class TfsBuildDefinitionHrefLink
    {
        [JsonPropertyName("href")]
        public String HrefLink { get; set; } = "";
    }
}
