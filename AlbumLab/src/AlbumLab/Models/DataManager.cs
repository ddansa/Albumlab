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
            string name = "Movits!";
            string desc = "Movits! är en svensk hiphop - grupp från Hertsön, ett bostadsområde i Luleå, bestående av bröderna \"Johan Jivin\" och \"Mördar-Anders\" Rensfeldt, samt saxofonisten Jocke \"One-Take\" Nilsson från Piteå. Gruppen spelar en svängig blandning mellan jazz och hiphop. Movits! beskriver sig själva som \"Djangogitarr, Blås och Streetswing. Musik för såväl Art directorn som för din mamma!\".";

            List<Album> albums = new List<Album>();
            albums.Add(new Album(1, "Äppelknyckarjazz", 2008));
            albums.Add(new Album(2, "Ut ur min skalle", 2011));
            albums.Add(new Album(3, "Huvudet Bland Molnen", 2013));
            albums.Add(new Album(4, "Dom försökte begrava oss, dom visste inte att vi var frön", 2015));

            Band = new Band(name, desc, albums);
        }

        public Band Band { get; set; }

        public Album GetAlbumById(int id)
        {
            return Band.Albums.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}