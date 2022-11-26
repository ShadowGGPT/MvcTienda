using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Correo { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Clave { get; set; }

    public int? IdRol { get; set; }

    public string? UrlFoto { get; set; }

    public string? NombreFoto { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Carrito> Carritos { get; } = new List<Carrito>();

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
