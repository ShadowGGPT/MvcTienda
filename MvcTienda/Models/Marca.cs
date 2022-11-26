using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Marca
{
    public int IdMarca { get; set; }

    public string? Nombre { get; set; }

    public string? UrlFoto { get; set; }

    public string? NombreFoto { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
