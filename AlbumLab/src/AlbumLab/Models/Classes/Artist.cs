using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Models.Classes
{
    public class Artist
    {
        public Artist(int id, string name)
        {
            Name = name;
            Id = id;
            Albums = new List<Album>();

            for (int i = 0; i < DataManager._Rnd.Next(1, 11); i++)
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
