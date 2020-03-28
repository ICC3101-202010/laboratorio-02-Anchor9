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
        public Espotifai()
        {

        }

        public List<Cancion> Songs { get => songs; set => songs = value; }

        public bool AgregarCancion(Cancion cancion)

        {
            List<Cancion> songs = new List<Cancion>();
            Cancion nuevo = cancion;

            if (songs.Contains(nuevo))
            {
                return false;
            }
            else
            {
                songs.Add(nuevo);
                return true;
            }
        }
        public void VerCanciones()
        {
            List<Cancion> songs = new List<Cancion>();
            songs.ForEach(Console.WriteLine);
        }




    }
}
