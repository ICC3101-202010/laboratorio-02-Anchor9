using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Fmiranda
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion C1 = new Cancion("Teenage", "California", "Blink182", "Rock");
            Cancion C2 = new Cancion("FatLip", "AllKiller", "Sum41", "Punk");

            Console.WriteLine(C1.Informacion());

            Espotifai espotifai = new Espotifai();
            List<Cancion> songs = new List<Cancion>();
            

            Console.WriteLine("AGREGAR");
            Console.WriteLine(espotifai.AgregarCancion(C1));
            Console.WriteLine(espotifai.AgregarCancion(C2));

            Console.WriteLine("Mostrar");
            espotifai.ShowSongs();

        }
    }
}
