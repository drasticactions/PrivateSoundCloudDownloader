using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrivateSoundCloudApi.Entities.Playlist;
using PrivateSoundCloudApi.Entities.Track;
using PrivateSoundCloudApi.Interfaces;

namespace PrivateSoundCloudApi.Managers
{
    public class TrackManager : ITrackManager
    {
        private readonly IWebManager _webManager;
        public TrackManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public async Task<TrackResponse> GetTrackUrls(string trackId, string secretToken)
        {
            var response = await _webManager.GetData($"https://api.soundcloud.com/i1/tracks/{trackId}/streams?secret_token={secretToken}");
            return JsonConvert.DeserializeObject<TrackResponse>(response.ResultJson);
        }
    }
}
