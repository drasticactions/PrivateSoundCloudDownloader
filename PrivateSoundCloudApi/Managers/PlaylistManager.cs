using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrivateSoundCloudApi.Entities.Playlist;
using PrivateSoundCloudApi.Interfaces;

namespace PrivateSoundCloudApi.Managers
{
    public class PlaylistManager : IPlaylistManager
    {
        private readonly IWebManager _webManager;
        public PlaylistManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public async Task<PlaylistResponse> GetPrivatePlaylist(string playlistId, string secretToken)
        {
            var response =await _webManager.GetData($"https://api.soundcloud.com/playlists/{playlistId}?secret_token={secretToken}");
            return JsonConvert.DeserializeObject<PlaylistResponse>(response.ResultJson);
        }
    }
}
