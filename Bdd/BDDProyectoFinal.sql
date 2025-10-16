-- Crear la base de datos
CREATE DATABASE SistemaHorariosItca;
GO

USE SistemaHorariosItca;
GO

-- Tabla Carreras
CREATE TABLE carreras (
    idCarrera INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    ciclo VARCHAR(50),
    tipoHorario VARCHAR(50),
    especialidad VARCHAR(100)
);
GO

-- Tabla Aula
CREATE TABLE aula (
    idAula INT IDENTITY(1,1) PRIMARY KEY,
    edificio VARCHAR(50) NOT NULL,
    tipoAula VARCHAR(50),
    nombre VARCHAR(50) NOT NULL,
    capacidad INT,
    ubicacion VARCHAR(100)
);
GO

-- Tabla Docentes
CREATE TABLE docentes (
    idDocente INT IDENTITY(1,1) PRIMARY KEY,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    direccion VARCHAR(200),
    telefono VARCHAR(20),
    nivelAcademico VARCHAR(50),
    tipoDocente VARCHAR(50),
    horariosDisponibles VARCHAR(200)
);
GO

-- Tabla Materias
CREATE TABLE materias (
    idMateria INT IDENTITY(1,1) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    tipoMateria VARCHAR(50),
    carrera INT NOT NULL,
    horasSemanales INT,
    CONSTRAINT FK_materias_carrera FOREIGN KEY (carrera) REFERENCES carreras(idCarrera)
);
GO

-- Tabla Horario (tabla principal de relaciones)
CREATE TABLE Horario (
    idHorario INT IDENTITY(1,1) PRIMARY KEY,
    carrera INT NOT NULL,
    materia INT NOT NULL,
    aula INT NOT NULL,
    docente INT NOT NULL,
    dia VARCHAR(15) NOT NULL,
    grupo VARCHAR(20),
    familia VARCHAR(50),
    fechaInicio DATE,
    fechaFin DATE,
    horaInicio TIME,
    cantidadHoras INT,
    CONSTRAINT FK_horario_carrera FOREIGN KEY (carrera) REFERENCES carreras(idCarrera),
    CONSTRAINT FK_horario_materia FOREIGN KEY (materia) REFERENCES materias(idMateria),
    CONSTRAINT FK_horario_aula FOREIGN KEY (aula) REFERENCES aula(idAula),
    CONSTRAINT FK_horario_docente FOREIGN KEY (docente) REFERENCES docentes(idDocente)
);
GO

-- Índices para mejorar el rendimiento
CREATE INDEX IX_horario_carrera ON Horario(carrera);
CREATE INDEX IX_horario_materia ON Horario(materia);
CREATE INDEX IX_horario_aula ON Horario(aula);
CREATE INDEX IX_horario_docente ON Horario(docente);
CREATE INDEX IX_materias_carrera ON materias(carrera);
GO

-- Insertar datos de ejemplo
INSERT INTO carreras (nombre, ciclo, tipoHorario, especialidad) VALUES
('INGENIERÍA EN DESARROLLO DE SOFTWARE', '1', 'Matutino', 'Técnico'),
('INGENIERÍA DE INFRAESTRUCTURA DE REDES INFORMÁTICAS', '1', 'Matutino', 'Técnico'),
('INGENIERÍA ELECTRÓNICA', '1', 'Matutino', 'Ingeniería');
GO


INSERT INTO aula (edificio, tipoAula, nombre, capacidad, ubicacion) VALUES
('NA', 'NA', 'NA', 20, 'NA'),
('Edificio C', 'Aula', 'Aula C101', 40, 'Primer piso'),
('Edificio C', 'Aula', 'Aula C102', 40, 'Primer piso'),
('Edificio C', 'Aula', 'Aula C103', 40, 'Primer piso'),
('Edificio F', 'Laboratorio', 'LAB F301', 20, 'Tercer piso'),
('Edificio F', 'Laboratorio', 'LAB F302', 20, 'Tercer piso'),
('Edificio F', 'Laboratorio', 'LAB F303', 20, 'Tercer piso');
GO

select * from docentes

INSERT INTO docentes (nombres, apellidos, direccion, telefono, nivelAcademico, tipoDocente, horariosDisponibles) VALUES
('María Elena', 'Gómez López', 'Av. Principal 123', '555-1234', 'Técnico', 'Tiempo Completo', 'Lunes a Viernes 7:00-15:00'),
('Carlos Antonio', 'Rodríguez Paz', 'Calle Secundaria 456', '555-5678', 'Ingeniería', 'Medio Tiempo', 'Lunes, Miércoles, Viernes 14:00-18:00'),
('Ana Patricia', 'Martínez Cruz', 'Jardines 789', '555-9012', 'Licenciatura', 'Por Horas', 'Martes y Jueves 8:00-12:00');
GO

INSERT INTO materias (nombre, tipoMateria, carrera, horasSemanales) VALUES
('Programación I', 'Técnica', 1, 6),
('Bases de Datos', 'Técnica', 1, 5),
('Planes de negocios', 'Transversal', 3, 4);
GO

INSERT INTO Horario (carrera, materia, aula, docente, dia, grupo, familia, fechaInicio, fechaFin, horaInicio, cantidadHoras) VALUES
(1, 1, 1, 1, 'Lunes', 'TDS112', 'A', '2025-02-24', '2025-05-15', '07:00', 4),
(1, 2, 2, 2, 'Miércoles', 'TDS113', 'B', '2025-06-15', '2025-11-15', '09:00', 2),
(2, 3, 3, 3, 'Viernes', 'TDS112', 'B', '2025-06-17', '2025-11-22', '14:00', 2);
GO

-- Consultas de verificación
SELECT 'Base de datos creada exitosamente' AS Mensaje;

-- Mostrar las tablas creadas
SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE';
GO