using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rx.AzDo
{
    public class TfsComplexAuthor
    {
        public class TfsComplexAuthorInnerAuthoredBy
        {
            public String DisplayName { get; set; } = "";

            [JsonPropertyName("url")]
            public String? UrlLink { get; set; }

            [JsonPropertyName("_links")]
            public TfsComplexAuthorAvatar AvatarLinks { get; set; } = new();
        }

        public class TfsComplexAuthorAvatar
        {
            [JsonPropertyName("avatar")]
            public TfsComplexAuthorAvatarLink Avatar { get; set; } = new();

            public class TfsComplexAuthorAvatarLink
            {
                [JsonPropertyName("href")]
                public String AvatarHref { get; set; } = "";
            }
        }

        public String Id { get; set; } = "";

        public String? UniqueName { get; set; }

        [JsonPropertyName("imageUrl")]
        public String? ImageUrl { get; set; }

        public String? Descriptor { get; set; }

    }
}
