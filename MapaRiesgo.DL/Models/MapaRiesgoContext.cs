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

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<SistemaOrigen> SistemaOrigens { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:MapaRiesgoSQLServerDatabase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.IdGeoposicion).HasName("PK__unidad__C97F4B4C9D9F70A9");

            entity.ToTable("unidad");

            entity.Property(e => e.IdGeoposicion).HasColumnName("id_geoposicion");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.IdSistemaOrigen).HasColumnName("id_sistema_origen");
            entity.Property(e => e.IdUnidad).HasColumnName("id_unidad");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("latitud");
            entity.Property(e => e.Longitud)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("longitud");
            entity.Property(e => e.Unidad1)
                .HasMaxLength(50)
                .HasColumnName("unidad1");
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
