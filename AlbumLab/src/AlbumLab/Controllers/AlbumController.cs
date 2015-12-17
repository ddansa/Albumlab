using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AlbumLab.Controllers
{
    class AlbumController : MainController
    {
        public IActionResult Details(int id)
        {
            //return View(_data.GetAlbumById(id));
            return View();
        }
    }
}