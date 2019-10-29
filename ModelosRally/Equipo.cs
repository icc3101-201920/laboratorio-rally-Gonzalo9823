using System;
using System.Collections.Generic;

namespace ModelosRally
{
    public class Equipo
    {
        string nombre;
        List<Vehiculo> vehiculos;
        List<Persona> tripulacion;

        public Equipo(string nombre)
        {
            this.nombre = nombre;
            vehiculos = new List<Vehiculo>();
            tripulacion = new List<Persona>();
        }

        public bool AgregarVehiculos(Vehiculo vehiculo)
        {
            //Agregar verificaciones
            vehiculos.Add(vehiculo);
            return true;
        }

        public bool AgregarTriupulacion(Persona persona)
        {
            tripulacion.Add(persona);
            return true;
        }

        public List<Vehiculo> GetListaVehiculos()
        {
            return vehiculos;
        }

        public List<Persona> GetListaTripulacion()
        {
            return tripulacion;
        }

        public override string ToString()
        {
            return nombre;
        }

    }
}
