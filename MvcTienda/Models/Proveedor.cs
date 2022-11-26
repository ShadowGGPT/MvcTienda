using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? Descripcion { get; set; }

    public string? UrlFoto { get; set; }

    public string? NombreFoto { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();
}
