using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlbumLab.Models.Classes;

namespace AlbumLab.Controllers
{
    public class AlbumController : MainController
    {
        public IActionResult Index()
        {
            return View(_data.Band);
        }

        public IActionResult Details(string id)
        {
            Album album = _data.GetAlbumById(id);
            if (album != null)
                return View(_data.GetAlbumById(id));
            else
                return Content("404 - Not Found");
        }
    }
}