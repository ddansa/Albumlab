using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumLab.Models.Classes
{
    public class Album
    {
        public Album(int id, string title, int year)
        {
            Id = id;
            Title = title;
            Year = year;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
