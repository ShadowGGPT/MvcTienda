using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public string? NumeroVenta { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdCliente { get; set; }

    public int? IdDomicilio { get; set; }

    public int? IdMetodoPago { get; set; }

    public string? IdTransaccion { get; set; }

    public decimal? Total { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Domicilio? IdDomicilioNavigation { get; set; }

    public virtual MetodoPago? IdMetodoPagoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
