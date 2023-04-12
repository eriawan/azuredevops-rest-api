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

        /// <summary>
        /// A required information about initial object creator
        /// </summary>
        [JsonPropertyName("createdBy")]
        public TfsSimpleAuthor CreatedBy { get; set; } = new();

        /// <summary>
        /// A required information about the date of the creation
        /// </summary>
        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// An optional information about the creator of last modification
        /// </summary>
        [JsonPropertyName("modifiedBy")]
        public TfsSimpleAuthor? ModifiedBy { get; set; }

        /// <summary>
        /// An optional information about the date of last modification
        /// </summary>0
        [JsonPropertyName("modifiedOn")]
        public DateTime? ModifiedOn { get; set; }

    }
}
