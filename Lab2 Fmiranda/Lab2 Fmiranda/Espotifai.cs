using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Fmiranda
{
    public class Espotifai
    {
        private List<Cancion> songs; // = new List<Cancion>();
        private Cancion canciones;
        
        public Espotifai()
        {

        }
        public List<Cancion> Songs { get => songs; set => songs = value; }

        public Cancion Canciones { get => canciones; set => canciones = value; }

        List<Cancion> SongsE = new List<Cancion>();

        ////////////////////////////////////////////////////////////////////////
        public bool AgregarCancion(Cancion cancion)
        {

            Cancion new_song = cancion;
            
            
            string new_info = cancion.Informacion();
            

            string new_name = cancion.Name;
            string new_album = cancion.Album;
            string new_artist = cancion.Artist;
            string new_genre = cancion.Genre;

            //foreach (Cancion song in Songs)
            if (SongsE.Contains(new_song))
            {
              return false;
            }

            else if (!SongsE.Contains(new_song))
            {
                 SongsE.Add(new Cancion(new_name, new_album, new_artist, new_genre));
                 return true;
            }
            return false;

            
        }
        //////////////////////////////////////////////////////////////////////////////////
        public void ShowSongs()
        {
            //this.songs = new List<Cancion>();
            foreach (var song in SongsE)
            {
                Console.WriteLine(song.Informacion());
            }
        }

        //////////////////////////////////////////////////////////////////////////////////
        public List<Cancion> CancionesPorCriterio(String category, String value)
        {           
            List<Cancion> find = new List<Cancion>();
            if (category != "Album" || category != "Name" || category != "Genre" || category != "Artist")
            {
                Console.WriteLine("ERROR, invalid parameter");
         
            }
            else
            {              
                foreach (var song in Songs)
                {
                    

    
                }


            }
            return find;


        }


        //////////////////////////////////////////////////////////////////////////////////
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        {
            return false;
        }
        public String VerMisPlaylists()
        {
            return  "a";
        }


    }


    
}
