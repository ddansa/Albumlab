using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AlbumLab.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbumLab.Controllers
{
    public class HomeController : Controller
    {
        private static DataManager _data = new DataManager();
        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewData["artists"] = _data.Bands;
            return View();
        }
    }
}
