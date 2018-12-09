using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicWebApplication.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int ArtistID { get; set; }
    }
}