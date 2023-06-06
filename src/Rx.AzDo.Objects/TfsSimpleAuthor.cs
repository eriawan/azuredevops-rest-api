using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.BaseObject
{
    /// <summary>
    /// Represents author of creation and modification.
    /// </summary>
    public class TfsSimpleAuthor
    {
        [JsonPropertyName("displayName")]
        public String? DisplayName { get; set; } = "";

        [JsonPropertyName("id")]
        public String? Id { get; set; } = "";

        [JsonPropertyName("uniqueName")]
        public String? UniqueName { get; set; } = "";
    }
}
