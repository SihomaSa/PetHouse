﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dominio
{
    public partial class Usuario
    {
        public Usuario()
        {
            AnimAdoptable = new HashSet<AnimAdoptable>();
            Atencion = new HashSet<Atencion>();
            Mascota = new HashSet<Mascota>();
            Pedido = new HashSet<Pedido>();
        }

        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual ICollection<AnimAdoptable> AnimAdoptable { get; set; }
        public virtual ICollection<Atencion> Atencion { get; set; }
        public virtual ICollection<Mascota> Mascota { get; set; }
        public virtual ICollection<Pedido> Pedido { get; set; }
    }
}