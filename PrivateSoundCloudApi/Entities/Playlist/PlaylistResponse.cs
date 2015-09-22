using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrivateSoundCloudApi.Entities.Playlist
{
    public class PlaylistResponse
    {
        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("release_day")]
        public object ReleaseDay { get; set; }

        [JsonProperty("permalink_url")]
        public string PermalinkUrl { get; set; }

        [JsonProperty("reposts_count")]
        public int RepostsCount { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("purchase_url")]
        public object PurchaseUrl { get; set; }

        [JsonProperty("release_month")]
        public object ReleaseMonth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("label_name")]
        public string LabelName { get; set; }

        [JsonProperty("tag_list")]
        public string TagList { get; set; }

        [JsonProperty("release_year")]
        public object ReleaseYear { get; set; }

        [JsonProperty("track_count")]
        public int TrackCount { get; set; }

        [JsonProperty("shared_to_count")]
        public int SharedToCount { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("tracks")]
        public Track[] Tracks { get; set; }

        [JsonProperty("playlist_type")]
        public string PlaylistType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("downloadable")]
        public bool Downloadable { get; set; }

        [JsonProperty("sharing")]
        public string Sharing { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("likes_count")]
        public int LikesCount { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("purchase_title")]
        public object PurchaseTitle { get; set; }

        [JsonProperty("created_with")]
        public CreatedWith CreatedWith { get; set; }

        [JsonProperty("artwork_url")]
        public string ArtworkUrl { get; set; }

        [JsonProperty("ean")]
        public string Ean { get; set; }

        [JsonProperty("streamable")]
        public bool Streamable { get; set; }

        [JsonProperty("user")]
        public User2 User { get; set; }

        [JsonProperty("embeddable_by")]
        public string EmbeddableBy { get; set; }

        [JsonProperty("label_id")]
        public object LabelId { get; set; }
    }
}
