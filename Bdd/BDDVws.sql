SELECT * FROM docentes
CREATE VIEW vw_Docentes_Informacion
AS
SELECT 
    d.idDocente,
    d.nombres,
    d.apellidos,
    CONCAT(d.nombres, ' ', d.apellidos) AS nombreCompleto,
    d.direccion,
    d.telefono,
    d.nivelAcademico,
    d.tipoDocente,
    d.horariosDisponibles,
    -- Información resumida de horarios
    (SELECT COUNT(*) FROM Horario WHERE docente = d.idDocente) AS totalClasesAsignadas,
    (SELECT SUM(cantidadHoras) FROM Horario WHERE docente = d.idDocente) AS totalHorasSemanales
FROM docentes d;
GO

SELECT * FROM vw_Docentes_Informacion;