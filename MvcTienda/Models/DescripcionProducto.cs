using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class DescripcionProducto
{
    public int IdDescripcion { get; set; }

    public int? IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
