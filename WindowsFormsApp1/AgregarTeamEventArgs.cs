using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasRally
{
    public class AgregarTeamEventArgs : EventArgs
    {
        public string nombre { get; set; }
        public List<Vehiculo> vehiculos { get; set; }
        public List<Persona> tripulacion { get; set; }

    }
}
