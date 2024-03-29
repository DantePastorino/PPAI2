﻿using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaPPAI.Entidades
{
    public class CentroInvestigación
    {
        public String Nombre { get; set; }
        public String sigla { get; set; }
        public String direccion { get; set; }
        public String edificio { get; set; }
        public int piso { get; set; }
        public int coordenadas { get; set; }
        public String telefonoContacto { get; set; }
        public String correoElectronico { get; set; }
        public int numeroResolucion { get; set; }
        public DateTime fechaREsolucionCreacion { get; set; }
        public String reglamento { get; set; }
        public String caracteristicasGenerales { get; set; }
        public DateTime fechaAlta { get; set; }
        public int tiempoAntelacionReserva { get; set; }
        public DateTime fechaBaja { get; set; }
        public String motivoBaja { get; set; }




    }
}
