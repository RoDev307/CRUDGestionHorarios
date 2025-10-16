using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class Aula
{
    public int IdAula { get; set; }

    public string Edificio { get; set; } = null!;

    public string? TipoAula { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Capacidad { get; set; }

    public string? Ubicacion { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
}
