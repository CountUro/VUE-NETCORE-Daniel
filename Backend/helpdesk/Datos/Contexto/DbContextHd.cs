using Datos.Mapeo;
using Entidades.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Contexto
{
    // DbContext es lo que se usa para conectarse a la base de datos (clase nativa)
    // DbContextHd es la base de datos del "Help Desk" - la app en si
    public class DbContextHd : DbContext
    {
        public DbSet<Cia> Cias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<ConsecutivoHd> ConsecutivoHds { get; set; }
        public DbSet<Dominio> Dominios { get; set; }
        public DbSet<DominioDet> DominioDets { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<GrupoCia> GrupoCias { get; set; }
        public DbSet<HdArchivo> HdArchivos { get; set; }
        public DbSet<HdDoc> HdDocs { get; set; }
        public DbSet<HdSeguimiento> HdSeguimientos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Soporte> Soportes { get; set; }

        public DbContextHd(DbContextOptions<DbContextHd> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CiaMapa());
            modelBuilder.ApplyConfiguration(new CiudadMapa());
            modelBuilder.ApplyConfiguration(new ConsecutivoHdMapa());
            modelBuilder.ApplyConfiguration(new DominioMapa());
            modelBuilder.ApplyConfiguration(new DominioDetMapa());
            modelBuilder.ApplyConfiguration(new EstadoMapa());
            modelBuilder.ApplyConfiguration(new GrupoCiaMapa());
            modelBuilder.ApplyConfiguration(new HdArchivoMapa());
            modelBuilder.ApplyConfiguration(new HdDocMapa());
            modelBuilder.ApplyConfiguration(new HdSeguimientoMapa());
            modelBuilder.ApplyConfiguration(new MunicipioMapa());
            modelBuilder.ApplyConfiguration(new PaisMapa());
            modelBuilder.ApplyConfiguration(new PersonaMapa());
            modelBuilder.ApplyConfiguration(new RolMapa());
            modelBuilder.ApplyConfiguration(new SucursalMapa());
            modelBuilder.ApplyConfiguration(new UsuarioMapa());
            modelBuilder.ApplyConfiguration(new SoporteMapa());

        }
      
    }
}
