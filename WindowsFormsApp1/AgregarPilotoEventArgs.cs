﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasRally
{
    public class AgregarPilotoEventArgs : EventArgs
    {
        public string nombre { get; set; }
        public int rol { get; set; }
        public int equipo { get; set; }
    }
}
