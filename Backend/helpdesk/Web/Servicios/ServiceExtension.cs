using Microsoft.Extensions.DependencyInjection;
using Negocios.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Servicios
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection service)
        {

            service.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                  builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
        }

        public static void ConfigureServiceDB(this IServiceCollection services)
        {
            services.AddTransient<ICiaService, CiaService>();
            services.AddTransient<ICiudadService, CiudadService>();
            services.AddTransient<IDominioDetService, DominioDetService>();
            services.AddTransient<IDominioService, DominioService>();
            services.AddTransient<IEstadoService, EstadoService>();
            services.AddTransient<IGrupoCiaService, GrupoCiaService>();
            services.AddTransient<IHdArchivoService, HdArchivoService>();
            services.AddTransient<IHdDocService, HdDocService>();
            services.AddTransient<IHdSeguimientoService, HdSeguimientoService>();
            services.AddTransient<IMunicipioService, MunicipioService>();
            services.AddTransient<IPaisService, PaisService>();
            services.AddTransient<IPersonaService, PersonaService>();
            services.AddTransient<IRolService, RolService>();
            services.AddTransient<ISucursalService, SucursalService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ISoporteService, SoporteService>();
            //services.AddTransient<IDatosIniciales, DatosIniciales>();


        }
    }
}
