// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dominio
{
    public partial class Atencion
    {
        public string IDAtencion { get; set; }
        public int? NroAtencion { get; set; }
        public string IDMascota { get; set; }
        public string DNI { get; set; }
        public string IDCita { get; set; }
        public string IDHistoriaC { get; set; }
        public int? PagoAtencion { get; set; }

        public virtual Usuario DNINavigation { get; set; }
        public virtual Cita IDCitaNavigation { get; set; }
        public virtual HistoriaClinica IDHistoriaCNavigation { get; set; }
        public virtual Mascota IDMascotaNavigation { get; set; }
    }
}