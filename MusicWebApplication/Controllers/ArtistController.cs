using MusicWebApplication.Models;
using MusicWebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWebApplication.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index()
        {
            List<Artist> Artistlist = new List<Artist>
            {
            new Artist { ArtistID = 1, ArtistName = "Eminem", Age = 54 },
            new Artist { ArtistID = 2, ArtistName = "jeBoi", Age = 10 },
            new Artist { ArtistID = 3, ArtistName = "Michael", Age = 22 }
            };
            return View("Index", Artistlist);
        }

    }
}