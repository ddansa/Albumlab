using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Models.Classes
{
    public class Band
    {
        public Band(string name, string description, List<Album> albums)
        {
            Name = name;
            Description = description;
            Albums = albums;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}