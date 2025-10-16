using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyectoFinalDAE.Modelos;

public partial class SistemaHorariosItcaContext : DbContext
{
    public SistemaHorariosItcaContext()
    {
    }

    public SistemaHorariosItcaContext(DbContextOptions<SistemaHorariosItcaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<Docente> Docentes { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<VwDocentesInformacion> VwDocentesInformacions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=SistemaHorariosItca; Trusted_Connection=True; Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.IdAula).HasName("PK__aula__D861CCCB5E99E44C");

            entity.ToTable("aula");

            entity.Property(e => e.IdAula).HasColumnName("idAula");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.Edificio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoAula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoAula");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.IdCarrera).HasName("PK__carreras__7B19E791A93AED0E");

            entity.ToTable("carreras");

            entity.Property(e => e.IdCarrera).HasColumnName("idCarrera");
            entity.Property(e => e.Ciclo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ciclo");
            entity.Property(e => e.Especialidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("especialidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoHorario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoHorario");
        });

        modelBuilder.Entity<Docente>(entity =>
        {
            entity.HasKey(e => e.IdDocente).HasName("PK__docentes__595F5B9CCC522656");

            entity.ToTable("docentes");

            entity.Property(e => e.IdDocente).HasColumnName("idDocente");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.HorariosDisponibles)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("horariosDisponibles");
            entity.Property(e => e.NivelAcademico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nivelAcademico");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoDocente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocente");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK__Horario__DE60F33A61F36BFD");

            entity.ToTable("Horario");

            entity.HasIndex(e => e.Aula, "IX_horario_aula");

            entity.HasIndex(e => e.Carrera, "IX_horario_carrera");

            entity.HasIndex(e => e.Docente, "IX_horario_docente");

            entity.HasIndex(e => e.Materia, "IX_horario_materia");

            entity.Property(e => e.IdHorario).HasColumnName("idHorario");
            entity.Property(e => e.Aula).HasColumnName("aula");
            entity.Property(e => e.CantidadHoras).HasColumnName("cantidadHoras");
            entity.Property(e => e.Carrera).HasColumnName("carrera");
            entity.Property(e => e.Dia)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("dia");
            entity.Property(e => e.Docente).HasColumnName("docente");
            entity.Property(e => e.Familia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("familia");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.Grupo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.HoraInicio).HasColumnName("horaInicio");
            entity.Property(e => e.Materia).HasColumnName("materia");

            entity.HasOne(d => d.AulaNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.Aula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_horario_aula");

            entity.HasOne(d => d.CarreraNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.Carrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_horario_carrera");

            entity.HasOne(d => d.DocenteNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.Docente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_horario_docente");

            entity.HasOne(d => d.MateriaNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.Materia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_horario_materia");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.IdMateria).HasName("PK__materias__4B740AB3E253B12B");

            entity.ToTable("materias");

            entity.HasIndex(e => e.Carrera, "IX_materias_carrera");

            entity.Property(e => e.IdMateria).HasColumnName("idMateria");
            entity.Property(e => e.Carrera).HasColumnName("carrera");
            entity.Property(e => e.HorasSemanales).HasColumnName("horasSemanales");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoMateria");

            entity.HasOne(d => d.CarreraNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.Carrera)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_materias_carrera");
        });

        modelBuilder.Entity<VwDocentesInformacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Docentes_Informacion");

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.HorariosDisponibles)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("horariosDisponibles");
            entity.Property(e => e.IdDocente)
                .ValueGeneratedOnAdd()
                .HasColumnName("idDocente");
            entity.Property(e => e.NivelAcademico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nivelAcademico");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoDocente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoDocente");
            entity.Property(e => e.TotalClasesAsignadas).HasColumnName("totalClasesAsignadas");
            entity.Property(e => e.TotalHorasSemanales).HasColumnName("totalHorasSemanales");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
