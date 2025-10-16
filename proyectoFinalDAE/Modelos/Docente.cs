using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class Docente
{
    public int IdDocente { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? NivelAcademico { get; set; }

    public string? TipoDocente { get; set; }

    public string? HorariosDisponibles { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
}
