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
            Bands = new List<Band>();
            // Creates new 15 bands
            for (int i = 1; i <= 15; i++)
            {
                Band artist = new Band(i, "Artist " + i.ToString());
                Bands.Add(artist);
            }
        }

        public Band GetBandById(int id)
        {
            // Finds the first band in our Bands property with the same Id as in-parameter
            return Bands.FirstOrDefault(b => b.Id == id);
        }


        public List<Band> Bands { get; set; }

    }
}
