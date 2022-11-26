using System;
using System.Collections.Generic;

namespace MvcTienda.Models;

public partial class Domicilio
{
    public int IdDomicilio { get; set; }

    public int? IdCliente { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdMunicipio { get; set; }

    public string? Direccion { get; set; }

    public bool? Activo { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Departamento? IdDepartamentoNavigation { get; set; }

    public virtual Municipio? IdMunicipioNavigation { get; set; }

    public virtual ICollection<Venta> Venta { get; } = new List<Venta>();
}
