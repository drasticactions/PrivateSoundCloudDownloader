using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSoundCloudApi.Entities.Playlist;

namespace PrivateSoundCloudApi.Interfaces
{
    public interface IPlaylistManager
    {
        Task<PlaylistResponse> GetPrivatePlaylist(string playlistId, string secretToken);
    }
}
