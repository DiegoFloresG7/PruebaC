//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manag.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        public long IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string HistoriaClinica { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string TemperaturaCorporal { get; set; }
        public string Peso { get; set; }
        public Nullable<int> Edad { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Pulso { get; set; }
        public string PresionArteriar { get; set; }
        public Nullable<bool> Inactivo { get; set; }
        public Nullable<System.DateTime> FechaCaptura { get; set; }
        public string Usuario { get; set; }
    }
}
