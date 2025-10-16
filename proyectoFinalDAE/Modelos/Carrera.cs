using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class Carrera
{
    public int IdCarrera { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Ciclo { get; set; }

    public string? TipoHorario { get; set; }

    public string? Especialidad { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
