using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Fmiranda
{
    public class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string genre;
       public Cancion(string Name, string Album, string Artist, string Genre)
        {
            name = Name;
            album = Album;
            artist = Artist;
            genre = Genre;
        }
        public string Name { get =>  name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public string Album { get => album; set => album = value; }
        public string Genre { get => genre; set => genre = value; }

        public string Informacion()
        {
            string informacion = "Genero:" + this.Genre + " Artist:" + this.Artist + " Album:" + this.Album + " Name:" + this.Name;
            return informacion;
            
        }
    }
}
