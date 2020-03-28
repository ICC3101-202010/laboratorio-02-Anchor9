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

            Console.WriteLine(C1.Informacion(C1));

            Espotifai espotifai = new Espotifai();
            
            espotifai.AgregarCancion(C1);
            espotifai.VerCanciones();

        }
    }
}
