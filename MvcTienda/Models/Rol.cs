using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string? Descripcion { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<RolMenu> RolMenus { get; } = new List<RolMenu>();

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
