using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC10
{
    internal class Jugador
    {
        public int Id;
        public string Nombre;
        public bool Vivo = true;

        public bool vivo { get { return vivo; } }
        public string nombre { get { return nombre; } set { nombre = value; } }

        public Jugador(int id, string nombre) {

            this.Id = id;
            this.Nombre = nombre;
        
        }

        

        public void Disparar(Revolver revolver)
        {
            if (revolver.Disparar())
            {
                Vivo = false;
                Console.WriteLine($"{Nombre} se disparó y perdió ");

            }
            
            
        }



    }
}
