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
            Espotifai espotifai = new Espotifai();

            // CANCIONES
            Cancion C1 = new Cancion("Teenage", "California", "Blink182", "Rock");
            Cancion C2 = new Cancion("FatLip", "AllKiller", "Sum41", "Punk");


            //---------------  M  E  N  U  ----------------------------


            Console.WriteLine("Welcome to espotifai, choose an option: \n");

            Console.WriteLine("[1] Show songs");
            Console.WriteLine("[2] Add song");
            Console.WriteLine("[3] Show songs by category");
            Console.WriteLine("[0] Exit");

            string option = Console.ReadLine();

            while (option != "1" && option != "2" && option != "0" && option != "3")
            {
                Console.WriteLine("Invalid parameter, re enter again");
                option = Console.ReadLine();

            }


            if (option == "1")
            {
                // INFO
                Console.WriteLine(C1.Informacion());

            }

            else if (option == "2")
            {
                //AGREGAR
                

                Console.WriteLine("AGREGAR \n");
                Console.WriteLine(espotifai.AgregarCancion(C1));
                Console.WriteLine(espotifai.AgregarCancion(C2));
                espotifai.ShowSongs();


            }
            else if (option == "3")
            {
                //SHOW SONG BY CATEGORY
                espotifai.ShowSongs();
                //Console.WriteLine("Show songs by parameter");
                //string parameter = Console.ReadLine();
                

            }

            else if (option == "0")
            {
                Console.WriteLine("Thanks");

           
            }





            //MOSTRAR
            // Console.WriteLine("\nMostrar ");
            //espotifai.ShowSongs();

        }
    }
    
}
