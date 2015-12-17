using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AlbumLab.Controllers
{
    public class AlbumController : MainController
    {
        public IActionResult Index()
        {
            return View(_data.Band);
            //return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            return View(_data.GetAlbumById(id));
        }
    }
}