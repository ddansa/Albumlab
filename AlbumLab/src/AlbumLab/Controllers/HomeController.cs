using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AlbumLab.Controllers
{
    public class HomeController : MainController
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_data.Band);
        }
    }
}
