using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSoundCloudApi.Entities.Track;

namespace PrivateSoundCloudApi.Interfaces
{
    public interface ITrackManager
    {
        Task<TrackResponse> GetTrackUrls(string trackId, string secretToken);
    }
}
