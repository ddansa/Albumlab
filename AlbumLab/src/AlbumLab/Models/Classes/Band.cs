using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Models.Classes
{
    public class Band
    {
        public Band(int id, string name)
        {
            Name = name;
            Id = id;
            Albums = new List<Album>();

            // Creates 3 albums for this band
            for (int i = 1; i <= 3; i++)
            {
                Album album = new Album(i, "Album " + i.ToString());
                Albums.Add(album);
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<Album> Albums { get; set; }

    }
}
