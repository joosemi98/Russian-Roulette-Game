using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AC10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = false;
            char respuesta;

            do
            {
                Console.Clear();
                //Creamos un nuevo juego
                Juego partida = new Juego();
                
                partida.Ronda();

                Console.WriteLine("\n¿Deseas volver a jugar(S/N)");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
                if (respuesta != 'S')
                {
                    Console.WriteLine("Continua el juego");
                    finalizar = true;
                }
                


            } while (!finalizar);
            Console.ReadKey();


        }
    }
}
