using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGuia
{
    public class Casa
    {
        public int IdCasa { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public int numeroHabitaciones { get; set; }

        public string datosCasa()
        {
            return $"La dirección es {Direccion}, en la ciudad {Ciudad} con el número de habitaciones {numeroHabitaciones}";
        }
    }
}
