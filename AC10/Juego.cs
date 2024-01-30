using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC10
{
    internal class Juego
    {
        private List<Jugador> jugadores = new List<Jugador>();
        Revolver revolver = null;


        public Juego()
        {
            Console.WriteLine("Ruleta rusa con revolver de 6 disparos");
            Console.WriteLine("=======================================");
            Console.WriteLine("Nombre de jugadores (1,6): ");
            int num = int.Parse(Console.ReadLine());
            string nombre; 
            if(num >6 || num < 1)
            {
                num = 6;
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Nombre del jugador {0}:", i+1);
                nombre= Console.ReadLine();   
                jugadores.Add(new Jugador (i, nombre));
            }
        }

        public void Ronda()
        {
           revolver = new Revolver();
            revolver.Rotacion();
            revolver.InsertarBala();
            for (int i = 0;i < jugadores.Count;i++)
            {
                Console.WriteLine("\n{0}, aprieta el gatillo para disparar...", jugadores[i].Nombre);
                Console.ReadKey();
                jugadores[i].Disparar(revolver);
                if (jugadores[i].Vivo)
                {
                    Console.WriteLine(jugadores[i].Nombre + " sigues VIVO!!!... Has tenido suerte");
                    revolver.SiguienteBala();
                }
                else
                {
                    Console.WriteLine(jugadores[i].Nombre + "has Muerto...");
                    break;
                }
                Console.ReadLine();
            }
        }

    }

    
}
