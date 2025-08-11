using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }

        public void Encender()
        {

            if (EstaEncendido == true)
            {
                Console.WriteLine("Esta encendido");
            }
        }

        public void Apagar() 
        {
            if (EstaEncendido == false)
            {
                Console.WriteLine("Esta apagado");
            }
        
        }

        public void MostrarEstado() 
        {
            Console.WriteLine($"La marca del dispositivo es: {Marca}");
            Console.WriteLine($"La marca del dispositivo es: {Modelo}");
            Console.WriteLine($"¿Esta encedido?");
            Console.WriteLine(EstaEncendido);
        }


    }
}
