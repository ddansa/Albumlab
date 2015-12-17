using AlbumLab.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Controllers
{
    abstract class MainController : Controller
    {
        public static DataManager _data = new DataManager();
    }
}
