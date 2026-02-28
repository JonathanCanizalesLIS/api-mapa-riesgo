using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MapaRiesgo.DL.Models;

public partial class MapaRiesgoContext : DbContext
{
    public MapaRiesgoContext()
    {
    }

    public MapaRiesgoContext(DbContextOptions<MapaRiesgoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmpresasBdConexion> EmpresasBdConexions { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<SistemaOrigen> SistemaOrigens { get; set; }

    public virtual DbSet<TipoEvento> TipoEventos { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:MapaRiesgoSQLServerDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmpresasBdConexion>(entity =>
        {
            entity.HasKey(e => e.IdConexion).HasName("PK_empresas_bd_conexion_id_conexion");

            entity.ToTable("empresas_bd_conexion");

            entity.Property(e => e.IdConexion)
                .ValueGeneratedNever()
                .HasColumnName("id_conexion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdSistemaOrigen).HasColumnName("id_sistema_origen");
            entity.Property(e => e.NameBd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("name_bd");
            entity.Property(e => e.PasswordBd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("password_bd");
            entity.Property(e => e.ServerBd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("server_bd");
            entity.Property(e => e.UsuarioBd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("usuario_bd");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("pk_evento");

            entity.ToTable("evento");

            entity.Property(e => e.IdEvento).HasColumnName("id_evento");
            entity.Property(e => e.Evidencia)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("evidencia");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdSistemaOrigen).HasColumnName("id_sistema_origen");
            entity.Property(e => e.IdTipoEvento).HasColumnName("id_tipo_evento");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("longitud");

            entity.HasOne(d => d.IdSistemaOrigenNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdSistemaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_evento_sistema_origen");

            entity.HasOne(d => d.IdTipoEventoNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdTipoEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_evento_evento");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => e.IdSesion).HasName("pk_edi_sesion_usuario");

            entity.ToTable("sesion");

            entity.Property(e => e.IdSesion).HasColumnName("id_sesion");
            entity.Property(e => e.FechaInicio)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Navegador)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("navegador");
            entity.Property(e => e.Token)
                .IsUnicode(false)
                .HasColumnName("token");
            entity.Property(e => e.UltimaActividad)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("ultima_actividad");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Sesions)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sesion_sesion");
        });

        modelBuilder.Entity<SistemaOrigen>(entity =>
        {
            entity.HasKey(e => e.IdSistemaOrigen).HasName("pk_Tbl");

            entity.ToTable("sistema_origen");

            entity.Property(e => e.IdSistemaOrigen)
                .ValueGeneratedNever()
                .HasColumnName("id_sistema_origen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoEvento>(entity =>
        {
            entity.HasKey(e => e.IdTipoEvento).HasName("pk_tipo_evento");

            entity.ToTable("tipo_evento");

            entity.Property(e => e.IdTipoEvento)
                .ValueGeneratedNever()
                .HasColumnName("id_tipo_evento");
            entity.Property(e => e.Conteo)
                .HasComment("Numero de eventos requeridos para ser mostrado en el mapa")
                .HasColumnName("conteo");
            entity.Property(e => e.Duracion)
                .HasDefaultValueSql("((60))")
                .HasComment("Duracion en minutos que el evento se mostrará en pantalla")
                .HasColumnName("duracion");
            entity.Property(e => e.Radio)
                .HasComment("Radio en kilómetros que se debe considerar")
                .HasColumnName("radio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => new { e.IdSistemaOrigen, e.IdUnidad }).HasName("pk_unidad");

            entity.ToTable("unidad");

            entity.Property(e => e.IdSistemaOrigen).HasColumnName("id_sistema_origen");
            entity.Property(e => e.IdUnidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id_unidad");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("longitud");
            entity.Property(e => e.Unidad1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("unidad");

            entity.HasOne(d => d.IdSistemaOrigenNavigation).WithMany(p => p.Unidads)
                .HasForeignKey(d => d.IdSistemaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_unidad_sistema_origen");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_edi_usuario");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idUsuario");
            entity.Property(e => e.Encripcion).HasColumnName("encripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estatus");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdSistemaOrigen).HasColumnName("id_sistema_origen");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.IdSistemaOrigenNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdSistemaOrigen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
