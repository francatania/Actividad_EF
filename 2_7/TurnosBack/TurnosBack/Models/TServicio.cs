﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TurnosBack.Models;

public partial class TServicio
{
    public int IdServicio { get; set; }

    public string Nombre { get; set; }

    public int Costo { get; set; }

    public bool? EnPromocion { get; set; }

    public virtual ICollection<TDetallesTurno> TDetallesTurnos { get; set; } = new List<TDetallesTurno>();
}