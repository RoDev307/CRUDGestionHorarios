using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class Materia
{
    public int IdMateria { get; set; }

    public string Nombre { get; set; } = null!;

    public string? TipoMateria { get; set; }

    public int Carrera { get; set; }

    public int? HorasSemanales { get; set; }

    public virtual Carrera CarreraNavigation { get; set; } = null!;

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
}
