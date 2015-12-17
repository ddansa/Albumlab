using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumLab.Models.Classes;
using AlbumLab.Controllers;

namespace AlbumLab.Models
{
    public class DataManager
    {
        public DataManager()
        {
            Artists = new List<Artist>();
            _Rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                Artist artist = new Artist(i, "Artist " + i.ToString());
                Artists.Add(artist);
            }
        }

        public List<Artist> Artists { get; set; }

        public static Random _Rnd { get; set; }
    }
}
