namespace VistasRally
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarPilotoButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RolComboBox = new System.Windows.Forms.ComboBox();
            this.addTeamPanel = new System.Windows.Forms.Panel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.addPersonPanel = new System.Windows.Forms.Panel();
            this.personTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addVehiclePanel = new System.Windows.Forms.Panel();
            this.vehicleTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addVehicleButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cilindradaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTeamPanel = new System.Windows.Forms.Panel();
            this.teamInfoPanel = new System.Windows.Forms.Panel();
            this.viewTeamPersonsLabel = new System.Windows.Forms.Label();
            this.viewTeamVehiclesLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewTeamComboBox = new System.Windows.Forms.ComboBox();
            this.addTeamPanel.SuspendLayout();
            this.addPersonPanel.SuspendLayout();
            this.addVehiclePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.viewTeamPanel.SuspendLayout();
            this.teamInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1067, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a Rally Manager (Por Vicente Gana y Gonzalo Caballero)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarPilotoButton
            // 
            this.AgregarPilotoButton.Location = new System.Drawing.Point(293, 364);
            this.AgregarPilotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarPilotoButton.Name = "AgregarPilotoButton";
            this.AgregarPilotoButton.Size = new System.Drawing.Size(179, 31);
            this.AgregarPilotoButton.TabIndex = 1;
            this.AgregarPilotoButton.Text = "Agregar Piloto";
            this.AgregarPilotoButton.UseVisualStyleBackColor = true;
            this.AgregarPilotoButton.Click += new System.EventHandler(this.AgregarPilotoButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(294, 160);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(481, 22);
            this.NameTextBox.TabIndex = 6;
            // 
            // RolComboBox
            // 
            this.RolComboBox.FormattingEnabled = true;
            this.RolComboBox.Location = new System.Drawing.Point(295, 235);
            this.RolComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.RolComboBox.Name = "RolComboBox";
            this.RolComboBox.Size = new System.Drawing.Size(481, 24);
            this.RolComboBox.TabIndex = 7;
            this.RolComboBox.SelectedIndexChanged += new System.EventHandler(this.RolComboBox_SelectedIndexChanged);
            // 
            // addTeamPanel
            // 
            this.addTeamPanel.Controls.Add(this.addTeamButton);
            this.addTeamPanel.Controls.Add(this.label7);
            this.addTeamPanel.Controls.Add(this.teamNameTextBox);
            this.addTeamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeamPanel.Location = new System.Drawing.Point(0, 30);
            this.addTeamPanel.Name = "addTeamPanel";
            this.addTeamPanel.Size = new System.Drawing.Size(1067, 524);
            this.addTeamPanel.TabIndex = 8;
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(293, 202);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(179, 31);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Agregar Equipo";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(293, 157);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(481, 22);
            this.teamNameTextBox.TabIndex = 11;
            // 
            // addPersonPanel
            // 
            this.addPersonPanel.Controls.Add(this.personTeamComboBox);
            this.addPersonPanel.Controls.Add(this.label2);
            this.addPersonPanel.Controls.Add(this.RolComboBox);
            this.addPersonPanel.Controls.Add(this.label9);
            this.addPersonPanel.Controls.Add(this.label10);
            this.addPersonPanel.Controls.Add(this.AgregarPilotoButton);
            this.addPersonPanel.Controls.Add(this.NameTextBox);
            this.addPersonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPersonPanel.Location = new System.Drawing.Point(0, 30);
            this.addPersonPanel.Name = "addPersonPanel";
            this.addPersonPanel.Size = new System.Drawing.Size(1067, 524);
            this.addPersonPanel.TabIndex = 8;
            this.addPersonPanel.Visible = false;
            // 
            // personTeamComboBox
            // 
            this.personTeamComboBox.FormattingEnabled = true;
            this.personTeamComboBox.Location = new System.Drawing.Point(294, 310);
            this.personTeamComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.personTeamComboBox.Name = "personTeamComboBox";
            this.personTeamComboBox.Size = new System.Drawing.Size(481, 24);
            this.personTeamComboBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Equipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(291, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Nombre";
            // 
            // addVehiclePanel
            // 
            this.addVehiclePanel.Controls.Add(this.vehicleTeamComboBox);
            this.addVehiclePanel.Controls.Add(this.label4);
            this.addVehiclePanel.Controls.Add(this.addVehicleButton);
            this.addVehiclePanel.Controls.Add(this.label6);
            this.addVehiclePanel.Controls.Add(this.cilindradaTextBox);
            this.addVehiclePanel.Controls.Add(this.label5);
            this.addVehiclePanel.Controls.Add(this.marcaTextBox);
            this.addVehiclePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVehiclePanel.Location = new System.Drawing.Point(0, 30);
            this.addVehiclePanel.Name = "addVehiclePanel";
            this.addVehiclePanel.Size = new System.Drawing.Size(1067, 524);
            this.addVehiclePanel.TabIndex = 10;
            this.addVehiclePanel.Visible = false;
            // 
            // vehicleTeamComboBox
            // 
            this.vehicleTeamComboBox.FormattingEnabled = true;
            this.vehicleTeamComboBox.Location = new System.Drawing.Point(294, 307);
            this.vehicleTeamComboBox.Name = "vehicleTeamComboBox";
            this.vehicleTeamComboBox.Size = new System.Drawing.Size(481, 24);
            this.vehicleTeamComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipo";
            // 
            // addVehicleButton
            // 
            this.addVehicleButton.Location = new System.Drawing.Point(293, 364);
            this.addVehicleButton.Name = "addVehicleButton";
            this.addVehicleButton.Size = new System.Drawing.Size(179, 31);
            this.addVehicleButton.TabIndex = 4;
            this.addVehicleButton.Text = "Agregar Vehiculo";
            this.addVehicleButton.UseVisualStyleBackColor = true;
            this.addVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cilindrada";
            // 
            // cilindradaTextBox
            // 
            this.cilindradaTextBox.Location = new System.Drawing.Point(294, 232);
            this.cilindradaTextBox.Name = "cilindradaTextBox";
            this.cilindradaTextBox.Size = new System.Drawing.Size(481, 22);
            this.cilindradaTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Marca";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(293, 157);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(481, 22);
            this.marcaTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem,
            this.agregarVehiculoToolStripMenuItem,
            this.agregarPersonaToolStripMenuItem,
            this.verEquiposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.agregarEquipoToolStripMenuItem.Text = "Agregar Equipo";
            this.agregarEquipoToolStripMenuItem.Click += new System.EventHandler(this.AgregarEquipoToolStripMenuItem_Click);
            // 
            // agregarVehiculoToolStripMenuItem
            // 
            this.agregarVehiculoToolStripMenuItem.Name = "agregarVehiculoToolStripMenuItem";
            this.agregarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.agregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo";
            this.agregarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.AgregarVehiculoToolStripMenuItem_Click);
            // 
            // agregarPersonaToolStripMenuItem
            // 
            this.agregarPersonaToolStripMenuItem.Name = "agregarPersonaToolStripMenuItem";
            this.agregarPersonaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.agregarPersonaToolStripMenuItem.Text = "Agregar Persona";
            this.agregarPersonaToolStripMenuItem.Click += new System.EventHandler(this.AgregarPersonaToolStripMenuItem_Click);
            // 
            // verEquiposToolStripMenuItem
            // 
            this.verEquiposToolStripMenuItem.Name = "verEquiposToolStripMenuItem";
            this.verEquiposToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.verEquiposToolStripMenuItem.Text = "Ver Equipos";
            this.verEquiposToolStripMenuItem.Click += new System.EventHandler(this.VerEquiposToolStripMenuItem_Click);
            // 
            // viewTeamPanel
            // 
            this.viewTeamPanel.Controls.Add(this.teamInfoPanel);
            this.viewTeamPanel.Controls.Add(this.label3);
            this.viewTeamPanel.Controls.Add(this.viewTeamComboBox);
            this.viewTeamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTeamPanel.Location = new System.Drawing.Point(0, 30);
            this.viewTeamPanel.Name = "viewTeamPanel";
            this.viewTeamPanel.Size = new System.Drawing.Size(1067, 524);
            this.viewTeamPanel.TabIndex = 11;
            this.viewTeamPanel.Visible = false;
            // 
            // teamInfoPanel
            // 
            this.teamInfoPanel.Controls.Add(this.viewTeamPersonsLabel);
            this.teamInfoPanel.Controls.Add(this.viewTeamVehiclesLabel);
            this.teamInfoPanel.Controls.Add(this.label11);
            this.teamInfoPanel.Controls.Add(this.label8);
            this.teamInfoPanel.Location = new System.Drawing.Point(12, 105);
            this.teamInfoPanel.Name = "teamInfoPanel";
            this.teamInfoPanel.Size = new System.Drawing.Size(1043, 409);
            this.teamInfoPanel.TabIndex = 3;
            this.teamInfoPanel.Visible = false;
            // 
            // viewTeamPersonsLabel
            // 
            this.viewTeamPersonsLabel.AutoSize = true;
            this.viewTeamPersonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeamPersonsLabel.Location = new System.Drawing.Point(244, 227);
            this.viewTeamPersonsLabel.Name = "viewTeamPersonsLabel";
            this.viewTeamPersonsLabel.Size = new System.Drawing.Size(29, 29);
            this.viewTeamPersonsLabel.TabIndex = 3;
            this.viewTeamPersonsLabel.Text = "--";
            // 
            // viewTeamVehiclesLabel
            // 
            this.viewTeamVehiclesLabel.AutoSize = true;
            this.viewTeamVehiclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTeamVehiclesLabel.Location = new System.Drawing.Point(244, 31);
            this.viewTeamVehiclesLabel.Name = "viewTeamVehiclesLabel";
            this.viewTeamVehiclesLabel.Size = new System.Drawing.Size(29, 29);
            this.viewTeamVehiclesLabel.TabIndex = 2;
            this.viewTeamVehiclesLabel.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "Personas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vehiculos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equipo";
            // 
            // viewTeamComboBox
            // 
            this.viewTeamComboBox.FormattingEnabled = true;
            this.viewTeamComboBox.Location = new System.Drawing.Point(119, 58);
            this.viewTeamComboBox.Name = "viewTeamComboBox";
            this.viewTeamComboBox.Size = new System.Drawing.Size(245, 24);
            this.viewTeamComboBox.TabIndex = 0;
            this.viewTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewTeamComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPersonPanel);
            this.Controls.Add(this.viewTeamPanel);
            this.Controls.Add(this.addTeamPanel);
            this.Controls.Add(this.addVehiclePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addTeamPanel.ResumeLayout(false);
            this.addTeamPanel.PerformLayout();
            this.addPersonPanel.ResumeLayout(false);
            this.addPersonPanel.PerformLayout();
            this.addVehiclePanel.ResumeLayout(false);
            this.addVehiclePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.viewTeamPanel.ResumeLayout(false);
            this.viewTeamPanel.PerformLayout();
            this.teamInfoPanel.ResumeLayout(false);
            this.teamInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarPilotoButton;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox RolComboBox;
        private System.Windows.Forms.Panel addTeamPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarVehiculoToolStripMenuItem;
        private System.Windows.Forms.Panel addPersonPanel;
        private System.Windows.Forms.Panel addVehiclePanel;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cilindradaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addVehicleButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.ComboBox vehicleTeamComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem verEquiposToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox personTeamComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel viewTeamPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox viewTeamComboBox;
        private System.Windows.Forms.Panel teamInfoPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label viewTeamVehiclesLabel;
        private System.Windows.Forms.Label viewTeamPersonsLabel;
    }
}

