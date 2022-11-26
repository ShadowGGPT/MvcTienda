using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Codigo { get; set; }

    public string? CodigoBarra { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdMarca { get; set; }

    public int? IdCategoria { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public string? UrlFoto { get; set; }

    public string? NombreFoto { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Carrito> Carritos { get; } = new List<Carrito>();

    public virtual ICollection<DescripcionProducto> DescripcionProductos { get; } = new List<DescripcionProducto>();

    public virtual ICollection<DetalleCompra> DetalleCompras { get; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleVenta> DetalleVenta { get; } = new List<DetalleVenta>();

    public virtual Categoria? IdCategoriaNavigation { get; set; }

    public virtual Marca? IdMarcaNavigation { get; set; }
}
