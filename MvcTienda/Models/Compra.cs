using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public string? NumeroCompra { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdProveedor { get; set; }

    public int? IdMetodoPago { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaCompra { get; set; }

    public virtual ICollection<DetalleCompra> DetalleCompras { get; } = new List<DetalleCompra>();

    public virtual MetodoPago? IdMetodoPagoNavigation { get; set; }

    public virtual Proveedor? IdProveedorNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
