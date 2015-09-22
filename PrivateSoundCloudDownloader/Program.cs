using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PrivateSoundCloudApi.Entities.Playlist;
using PrivateSoundCloudApi.Managers;
using TagLib;
using File = System.IO.File;

namespace PrivateSoundCloudDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = MainAsync(args);
            t.Wait();
        }

        static async Task MainAsync(string[] args)
        {
            var webManager = new WebManager("0f8fdbbaa21a9bd18210986a7dc2d72c");
            var playlistManager = new PlaylistManager(webManager);
            var trackManager = new TrackManager(webManager);
            var playlist = await playlistManager.GetPrivatePlaylist("136295555", "s-xyQQ0");
            for (int index = 0; index < playlist.Tracks.Length; index++)
            {
                var track = playlist.Tracks[index];
                Console.WriteLine($"{track.Title}");
                var trackUrls = await trackManager.GetTrackUrls(track.Id.ToString(), "s-xyQQ0");
                Console.WriteLine(trackUrls.HttpMp3128Url);
                using (var webClient = new WebClient())
                {
                    var index1 = index;
                    webClient.DownloadFileCompleted += (sender, value) => Task.Run(() => { EditTags(track, index1); });
                    webClient.DownloadProgressChanged += (sender, value) => System.Console.Write("\r%{0:N0}", value);
                    webClient.DownloadFileAsync(new Uri(trackUrls.HttpMp3128Url),
                        AppDomain.CurrentDomain.BaseDirectory + $"/{track.Title}.mp3");
                }
            }
            Console.ReadLine();
        }

        static void EditTags(Track track, int index)
        {
            var tagFile = TagLib.File.Create(AppDomain.CurrentDomain.BaseDirectory + $"/{track.Title}.mp3");
            var tags = tagFile.GetTag(TagTypes.Id3v2);
            tags.Title = track.Title;
            tags.Track = (uint)index;
            tags.Album = "";
            tags.AlbumArtists = new string[] { "" };
            Debug.WriteLine("GOT FILE!");
            tagFile.Save();
        }
    }
}
