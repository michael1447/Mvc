using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicWebApplication.Controllers;
using MusicWebApplication.Models;

namespace MusicWebApplication.Models
{

    public class Artist
    {
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }
        public int Age { get; set; }
    }
}