using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public interface IDispositivoElectronico
    {
        public void Encender();
        public void Apagar();
        public void MostrarEstado();
    }
}
