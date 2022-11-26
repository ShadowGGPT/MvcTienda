using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string? Nombre { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Domicilio> Domicilios { get; } = new List<Domicilio>();

    public virtual ICollection<Municipio> Municipios { get; } = new List<Municipio>();
}
