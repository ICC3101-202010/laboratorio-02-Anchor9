using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Fmiranda
{
    public class Espotifai
    {
        private List<Cancion> songs;
        private Cancion canciones;
        public Espotifai()
        {

        }
        public List<Cancion> Songs 
        {  
            get
            {
                return this.songs;
            }
        }
        public Cancion Canciones { get => canciones; set => canciones = value; }


       
        public bool AgregarCancion(Cancion cancion)
        {
;
            Cancion new_song = cancion;
            string new_info = cancion.Informacion();
            List<Cancion> songs = new List<Cancion>();

            string new_name = cancion.Name;
            string new_album = cancion.Album;
            string new_artist = cancion.Artist;
            string new_genre = cancion.Genre;



            foreach (Cancion song in songs)
            {
                
                if (songs.Contains(new_song))
                {
                    
                    return false;
                }
                else
                {
                    songs.Add(new Cancion(new_name,new_album,new_artist,new_genre));
    
                    return true;
                    
                }
                
            
            }
            return false;
                  
        }
        public void ShowSongs()
        {
            List<Cancion> songs = new List<Cancion>();
            
            foreach (Cancion song in songs)
            {
                
                Console.WriteLine(song.Name);
                Console.WriteLine(song.Album);
                Console.WriteLine(song.Artist);
                Console.WriteLine(song.Genre);
            }
        }


    }


    
}
