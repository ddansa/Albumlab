using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Models.Classes
{
    public class Album
    {
        public Album(string title, int year)
        {
            Id = Guid.NewGuid().ToString("N");
            Title = title;
            Year = year;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
