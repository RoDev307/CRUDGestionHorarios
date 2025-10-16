using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class Horario
{
    public int IdHorario { get; set; }

    public int Carrera { get; set; }

    public int Materia { get; set; }

    public int Aula { get; set; }

    public int Docente { get; set; }

    public string Dia { get; set; } = null!;

    public string? Grupo { get; set; }

    public string? Familia { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public TimeOnly? HoraInicio { get; set; }

    public int? CantidadHoras { get; set; }

    public virtual Aula AulaNavigation { get; set; } = null!;

    public virtual Carrera CarreraNavigation { get; set; } = null!;

    public virtual Docente DocenteNavigation { get; set; } = null!;

    public virtual Materia MateriaNavigation { get; set; } = null!;
}
