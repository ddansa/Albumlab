using AlbumLab.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Controllers
{
    public abstract class MainController : Controller
    {
        protected static DataManager _data = new DataManager();
    }
}
