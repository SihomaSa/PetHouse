﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dominio
{
    public partial class AnimAdoptable
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Especie { get; set; }
        public string IDAdoptable { get; set; }
        public int? Edad { get; set; }
        public string Sexo { get; set; }

        public virtual Usuario DNINavigation { get; set; }
    }
}