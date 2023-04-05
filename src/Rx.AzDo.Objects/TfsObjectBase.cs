using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo.BaseObject
{
    /// <summary>
    /// Base class definition of TFS object.
    /// </summary>
    /// <remarks>
    /// <para>Represents abstract base class of TFS object with required properties.</para>
    /// </remarks>
    public abstract class TfsObjectBase
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; } = "";

        [JsonPropertyName("createdBy")]
        public TfsAuthor CreatedBy { get; set; } = new();

        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; }

        [JsonPropertyName("modifiedBy")]
        public TfsAuthor? ModifiedBy { get; set; }

        [JsonPropertyName("modifiedOn")]
        public DateTime? ModifiedOn { get; set; }
    }
}
