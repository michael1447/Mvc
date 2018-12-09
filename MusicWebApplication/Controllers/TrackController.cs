using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWebApplication.Models;
using MusicWebApplication.Controllers;

namespace MusicWebApplication.Controllers
{
    public class TrackController : Controller
    {
        // GET: Track
        public ActionResult Index()
        {
            List<Track> TrackList = new List<Track>
            {
            new Track { TrackName = "lucky you", TrackTime = 244, Genre = "hiphop" },
            new Track { TrackName = "mooi nummer", TrackTime = 200, Genre = "modern" },
            new Track { TrackName = "test song", TrackTime  = 150, Genre = "test songs" }
            };

            return View("Index", TrackList);
        }
    }
}