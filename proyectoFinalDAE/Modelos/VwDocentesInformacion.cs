using System;
using System.Collections.Generic;

namespace proyectoFinalDAE.Modelos;

public partial class VwDocentesInformacion
{
    public int IdDocente { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string NombreCompleto { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? NivelAcademico { get; set; }

    public string? TipoDocente { get; set; }

    public string? HorariosDisponibles { get; set; }

    public int? TotalClasesAsignadas { get; set; }

    public int? TotalHorasSemanales { get; set; }
}
