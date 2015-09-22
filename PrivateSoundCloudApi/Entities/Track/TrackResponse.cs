using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrivateSoundCloudApi.Entities.Track
{
    public class TrackResponse
    {
        [JsonProperty("http_mp3_128_url")]
        public string HttpMp3128Url { get; set; }

        [JsonProperty("preview_mp3_128_url")]
        public string PreviewMp3128Url { get; set; }
    }
}
