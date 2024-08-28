using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Estacionamiento
    {
        private List<Vehiculos> vehiculos = new List<Vehiculos>();
        private int espaciosDisponibles = 50;

        public void RegistrarVehiculo()
        {
            if (espaciosDisponibles >0)
            {
                vehiculos.Add(vehiculos)
                    espaciosDisponibles--;
                Console.WriteLine("Vehiculo registrado correctamente");

            }
        }
    }
}
