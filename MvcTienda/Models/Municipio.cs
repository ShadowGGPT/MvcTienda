using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Municipio
{
    public int IdMunicipio { get; set; }

    public int? IdDepartamento { get; set; }

    public string? Nombre { get; set; }

    public bool? Activo { get; set; }

    public virtual ICollection<Domicilio> Domicilios { get; } = new List<Domicilio>();

    public virtual Departamento? IdDepartamentoNavigation { get; set; }
}
