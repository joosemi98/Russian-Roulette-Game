using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC10
{
    internal class Revolver
    {
        private int PosicionActual { get; set; }
        public int PosicionBala { get; set;}
        private Random Rand = new Random();


        public void InsertarBala()
        {
            PosicionBala = Rand.Next(1, 7);
        }

        public void Rotacion()
        {
            PosicionActual = Rand.Next(1, 7);
        }

        public bool Disparar()
        {
            if (PosicionActual == PosicionBala) {
            
            return true;
            
            }
            else
            {
                
                return false;
            }
        }

        public void SiguienteBala()
        {
            PosicionActual++;
            if (PosicionActual == 7)
            {
                PosicionActual = 1;
            }
        }

        public void VerInfo()
        {
            Console.WriteLine($"Posición Acutal: {PosicionActual}", $"PosicionBala: {PosicionBala}");
        }
    }
}
