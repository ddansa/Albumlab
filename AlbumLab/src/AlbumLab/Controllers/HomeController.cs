using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlbumLab.Models;
using AlbumLab.Models.Classes;

namespace AlbumLab.Controllers
{
    class HomeController : MainController
    {
        public IActionResult Index()
        {
            return View(_data.Band);
        }
    }
}