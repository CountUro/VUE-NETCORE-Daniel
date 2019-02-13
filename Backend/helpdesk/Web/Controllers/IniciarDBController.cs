using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Datos.Contexto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocios.Managers;
using Negocios.Servicios;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IniciarDBController : ControllerBase
    {
        private readonly DbContextHd _context;
        private readonly IPaisService _servicePais;
        private readonly IEstadoService _serviceEstado;
        private readonly ICiudadService _serviceCiudad;
        private readonly IMunicipioService _serviceMunicipio;
        private readonly IDominioService _serviceDominio;
        private readonly IDominioDetService _serviceDominioDet;

        public IniciarDBController(DbContextHd context,
                                    IPaisService servicePais,
                                    IEstadoService serviceEstado,
                                    ICiudadService serviceCiudad,
                                    IMunicipioService serviceMunicipio,
                                    IDominioService serviceDominio,
                                    IDominioDetService serviceDominioDet)
        {
            _context = context;
            _servicePais = servicePais;
            _serviceEstado = serviceEstado;
            _serviceCiudad = serviceCiudad;
            _serviceMunicipio = serviceMunicipio;
            _serviceDominio = serviceDominio;
            _serviceDominioDet = serviceDominioDet;
        }

        // GET: api/IniciarDB/Inicio
        [HttpGet("[action]")]
        public async Task<IActionResult> Inicio()
        {
            try
            {
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    DatosIniciales inicioDb = new DatosIniciales(_servicePais, _serviceEstado, _serviceCiudad, _serviceMunicipio, _serviceDominio, _serviceDominioDet);

                    await inicioDb.CrearPaisesAsync();
                    await inicioDb.CreaEstadosMunipiosCiudadesDeVzla();
                    await inicioDb.CreaDominios();

                    await inicioDb.CreaDominiosDetalleDeVzla();

                    var paises = await _servicePais.GetAll();

                    scope.Complete(); // <---- Esta instrucción hace el commit

                    return Ok(paises);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}