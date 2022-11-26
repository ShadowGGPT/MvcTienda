using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class MetodoPago
{
    public int IdMetodoPago { get; set; }

    public string? IdNombre { get; set; }

    public string? UrlFoto { get; set; }

    public string? NombreFoto { get; set; }

    public virtual ICollection<Compra> Compras { get; } = new List<Compra>();

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
