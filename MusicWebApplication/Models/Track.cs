using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicWebApplication.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public int ArtistID { get; set; }
        public int AlbumId { get; set; }
        public int LyricID { get; set; }

        public string TrackName { get; set; }
        public int TrackTime { get; set; }
        public string Genre { get; set; }
    }
}