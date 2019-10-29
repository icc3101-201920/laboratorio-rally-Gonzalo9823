using ModelosRally;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    class Controller
    {
        List<Equipo> Equipos;
        List<Persona> Pilotos;
        List<Vehiculo> Vehiculos;
        Form1 vistaPilotos;

        public Controller(Form1 vistaPilotos)
        {
            Pilotos = new List<Persona>();
            Vehiculos = new List<Vehiculo>();
            Equipos = new List<Equipo>();

            this.vistaPilotos = vistaPilotos;
            this.vistaPilotos.OnAgregarPiloto += VistaPilotos_OnAgregarPiloto;
            this.vistaPilotos.OnAgregarVehiculo += VistaPilotos_OnAgregarVehiculo;
            this.vistaPilotos.OnAgregarTeam += VistaPilotos_OnAgregarTeam;
            this.vistaPilotos.OnGetTeam += VistaPilotos_OnGetTeam;
        }

        private void VistaPilotos_OnAgregarPiloto(object sender, AgregarPilotoEventArgs e)
        {
            Persona piloto = new Persona(e.nombre, (Rol)e.rol);
            Pilotos.Add(piloto);

            Equipos[e.equipo].AgregarTriupulacion(piloto);
        }

        private void VistaPilotos_OnAgregarVehiculo(object sender, AgregarVehiculoEventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo(e.marca, e.cilindrada);
            Vehiculos.Add(vehiculo);
            Equipos[e.equipo].AgregarVehiculos(vehiculo);
        }

        private void VistaPilotos_OnAgregarTeam(object sender, AgregarTeamEventArgs e)
        {
            Equipo equipo = new Equipo(e.nombre);
            Equipos.Add(equipo);
            vistaPilotos.ActulizarListaEquipos(equipo);
        }

        private void VistaPilotos_OnGetTeam(object sender, GetTeamEventArgs e)
        {
            Equipo equipo = Equipos[e.equipo];
            string vehiclesList = "";
            string personsList = "";

            foreach (Vehiculo vehiculo in equipo.GetListaVehiculos())
            {
                vehiclesList += $"- {vehiculo.getMarca()} | {vehiculo.getCilindrada()}\n";
            }

            foreach (Persona persona in equipo.GetListaTripulacion())
            {
                personsList += $"- {persona.GetNombre()} | {persona.GetRol()}\n";
            }

            vistaPilotos.updateViewTeamInfo(vehiclesList, personsList);
        }

    }
}
