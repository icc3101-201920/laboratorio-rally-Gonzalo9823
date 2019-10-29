using ModelosRally;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasRally
{
    public partial class Form1 : Form
    {
        public event EventHandler<AgregarPilotoEventArgs> OnAgregarPiloto;
        public event EventHandler<AgregarVehiculoEventArgs> OnAgregarVehiculo;
        public event EventHandler<AgregarTeamEventArgs> OnAgregarTeam;
        public event EventHandler<GetTeamEventArgs> OnGetTeam;

        public Form1()
        {
            InitializeComponent();
            this.RolComboBox.DataSource = Enum.GetValues(typeof(Rol));
        }

        private void AgregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addPersonPanel.Visible = true;
            this.addTeamPanel.Visible = false;
            this.addVehiclePanel.Visible = false;
            this.viewTeamPanel.Visible = false;

            this.viewTeamComboBox.SelectedItem = null;
        }

        private void AgregarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addTeamPanel.Visible = true;
            this.addPersonPanel.Visible = false;
            this.addVehiclePanel.Visible = false;
            this.viewTeamPanel.Visible = false;

            this.viewTeamComboBox.SelectedItem = null;

        }

        private void AgregarVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.addVehiclePanel.Visible = true;
            this.addPersonPanel.Visible = false;
            this.addTeamPanel.Visible = false;
            this.viewTeamPanel.Visible = false;

            this.viewTeamComboBox.SelectedItem = null;

        }
        private void VerEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.viewTeamPanel.Visible = true;
            this.addPersonPanel.Visible = false;
            this.addTeamPanel.Visible = false;
            this.addVehiclePanel.Visible = false;
        }

        // PILOTO
        private void AgregarPilotoButton_Click(object sender, EventArgs e)
        {

            if (OnAgregarPiloto != null && this.personTeamComboBox.SelectedItem != null && this.RolComboBox.SelectedItem != null && this.NameTextBox.Text != "")
            {
                AgregarPilotoEventArgs pilotoArgs = new AgregarPilotoEventArgs();
                pilotoArgs.nombre = this.NameTextBox.Text;
                pilotoArgs.rol = this.RolComboBox.SelectedIndex;
                pilotoArgs.equipo = this.personTeamComboBox.SelectedIndex;
                OnAgregarPiloto(this, pilotoArgs);
                MessageBox.Show("Personal agregada");
                this.NameTextBox.Text = "";
                this.RolComboBox.SelectedItem = null;
                this.personTeamComboBox.SelectedItem = null;
            } else
            {
                MessageBox.Show("Porfavor agrega todos los datos");
            }

        }

        private void RolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buttonText = "";
            if (this.RolComboBox.SelectedItem != null)
            {
                buttonText = $"{(Rol)this.RolComboBox.SelectedIndex}";

            }

            this.AgregarPilotoButton.Text = $"Agregar {buttonText}";
        }

        // VEHICULO
        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            if(OnAgregarVehiculo != null && this.cilindradaTextBox.Text != "" && this.marcaTextBox.Text != "" && this.vehicleTeamComboBox.SelectedItem != null)
            {
                AgregarVehiculoEventArgs vehicleArgs = new AgregarVehiculoEventArgs();
                int x = 0;

                if (Int32.TryParse(this.cilindradaTextBox.Text, out x))
                {
                    vehicleArgs.marca = this.marcaTextBox.Text;
                    vehicleArgs.cilindrada = x;
                    vehicleArgs.equipo = this.vehicleTeamComboBox.SelectedIndex;
                    OnAgregarVehiculo(this, vehicleArgs);
                    MessageBox.Show("Vehiculo agregado");
                    this.marcaTextBox.Text = "";
                    this.cilindradaTextBox.Text = "";
                    this.vehicleTeamComboBox.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Porfavor elige una cilindrada correcta");
                }
            }
            else
            {
                MessageBox.Show("Porfavor agrega todos los datos");
            }
        }

        // EQUIPOS
        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarTeam != null && this.teamNameTextBox.Text != "")
            {
                AgregarTeamEventArgs teamArgs = new AgregarTeamEventArgs();
                teamArgs.nombre = this.teamNameTextBox.Text;
                OnAgregarTeam(this, teamArgs);
                MessageBox.Show("Equipo agregado");
                this.teamNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Porfavor agrega todos los datos");
            }
        }
        public void ActulizarListaEquipos(Equipo equipo)
        {
            vehicleTeamComboBox.Items.Add(equipo);
            personTeamComboBox.Items.Add(equipo);
            viewTeamComboBox.Items.Add(equipo);
        }

        // VER EQUIPOS
        private void ViewTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.viewTeamComboBox.SelectedItem == null)
            {
                this.teamInfoPanel.Visible = false;
            }
            else
            {
                if (OnGetTeam != null)
                {
                    GetTeamEventArgs getTeamArgs = new GetTeamEventArgs();
                    getTeamArgs.equipo = this.viewTeamComboBox.SelectedIndex;
                    OnGetTeam(this, getTeamArgs);
                    this.teamInfoPanel.Visible = true;
                }
            }
           
        }

        // no se hace pero bueeenooo
        public void updateViewTeamInfo(string vehicles, string persons)
        {
            this.viewTeamVehiclesLabel.Text = vehicles;
            this.viewTeamPersonsLabel.Text = persons;
        }
    }
}
