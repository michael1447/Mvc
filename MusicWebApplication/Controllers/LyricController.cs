using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWebApplication.Models;
using MusicWebApplication.Controllers;

namespace MusicWebApplication.Controllers
{
    public class LyricController : Controller
    {
        // GET: Lyric
        public ActionResult Index()
        {
            string LyricText = "";
            //List<Lyric> TrackList = new List<Lyric>
            //{
            //    new Lyric{LyricText = ""}
            //};
            return View();
        }
    }
}