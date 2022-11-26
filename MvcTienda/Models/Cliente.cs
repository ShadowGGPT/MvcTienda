    using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? Clave { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Domicilio> Domicilios { get; } = new List<Domicilio>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
