using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Laptop : IDispositivoElectronico
    {
        public string Marca { get; set; }
        public string Modelo { get;set; }
        public bool EstaEncendido { get; set; }
        public int NivelBateria { get; set; }

        public void Encender()
        {
            EstaEncendido = true;
        }

        public void Apagar()
        {
            EstaEncendido = false;
            NivelBateria = 0;  
           
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"La marca del dispositivo es: {Marca}");
            Console.WriteLine($"El modelo del dispositivo es: {Modelo}");
            Console.WriteLine($"Su nivel de bateria es: {NivelBateria}%");
            Console.WriteLine($"¿Está encendido?: {(EstaEncendido ? "Sí" : "No")}"); // condición ? valorSiVerdadero : valorSiFalso
            Console.WriteLine();

        }

    }
}
