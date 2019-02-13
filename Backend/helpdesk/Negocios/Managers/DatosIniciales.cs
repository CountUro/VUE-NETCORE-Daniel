using Datos.Contexto;
using Entidades.Modelo;
using Negocios.Servicios;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Managers
{
     

    public class DatosIniciales
    {
         
        private IPaisService _paisService;
        private IEstadoService _estadoService;
        private ICiudadService _ciudadService;
        private IMunicipioService _municipioService;
        private IDominioService _dominioService;
        private IDominioDetService _dominioDetService;
        
        public DatosIniciales(IPaisService paisService, IEstadoService estadoService, ICiudadService ciudadService, IMunicipioService municipioService, IDominioService dominioService, IDominioDetService dominioDetService)
        {
            _paisService = paisService;
            _estadoService = estadoService;
            _ciudadService = ciudadService;
            _municipioService = municipioService;
            _dominioService = dominioService;
            _dominioDetService = dominioDetService;
        }

        //------------------------------------------------------------------
        // Crear los dominios
        //------------------------------------------------------------------

        public async Task CreaDominios()
        {
            try
            {
                var listaDominio = new List<Dominio>();

                await _dominioService.AgregarDom(listaDominio, 1, "Costo de Repuestos para calculo de PVP");
                await _dominioService.AgregarDom(listaDominio, 2, "Tipo de Departamento");
                await _dominioService.AgregarDom(listaDominio, 3, "Tipo de Dirección");
                await _dominioService.AgregarDom(listaDominio, 4, "Tipo de Teléfono");
                await _dominioService.AgregarDom(listaDominio, 5, "Tipo de Material");
                await _dominioService.AgregarDom(listaDominio, 6, "Sexo");
                await _dominioService.AgregarDom(listaDominio, 7, "Estado Civil");
                await _dominioService.AgregarDom(listaDominio, 8, "Tipo de Clasificación");
                await _dominioService.AgregarDom(listaDominio, 9, "Ambito de Tab");
                await _dominioService.AgregarDom(listaDominio, 10, "Tipo de Clasificación de Dirección");
                await _dominioService.AgregarDom(listaDominio, 11, "Tipo de Persona Departamental");
                await _dominioService.AgregarDom(listaDominio, 12, "Tipo de Dato de Parámetro");
                await _dominioService.AgregarDom(listaDominio, 13, "Tipo de Descuento en Cliente");
                await _dominioService.AgregarDom(listaDominio, 14, "Tipo de Parámetro");
                await _dominioService.AgregarDom(listaDominio, 15, "Tipo Documento");
                await _dominioService.AgregarDom(listaDominio, 16, "Procesos");
                await _dominioService.AgregarDom(listaDominio, 17, "Tipo de Transferencia");
                await _dominioService.AgregarDom(listaDominio, 18, "Tipo de Garantía");
                await _dominioService.AgregarDom(listaDominio, 19, "Origen de Renglón de Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 20, "Forma de Pago de Unidades");
                await _dominioService.AgregarDom(listaDominio, 21, "Tipo de Observaciones en Unidades");
                await _dominioService.AgregarDom(listaDominio, 22, "Nivel de Ubicación en Depósito");
                await _dominioService.AgregarDom(listaDominio, 23, "Tipo de Extensión para Archivos Imagen");
                await _dominioService.AgregarDom(listaDominio, 24, "Modalidad del Documento");
                await _dominioService.AgregarDom(listaDominio, 25, "Tipo de Impresora");
                await _dominioService.AgregarDom(listaDominio, 26, "Tipo de Usuario");
                await _dominioService.AgregarDom(listaDominio, 27, "Tipo de Personal Interno para el Departamento");
                await _dominioService.AgregarDom(listaDominio, 28, "Tipo de Costo para Ajustes de Inventario");
                await _dominioService.AgregarDom(listaDominio, 29, "Tipo de Diferencia en Recepción de Transferencias");
                await _dominioService.AgregarDom(listaDominio, 30, "Meses del Año");
                await _dominioService.AgregarDom(listaDominio, 31, "Modalidad de Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 32, "Estatus de Maquinaria");
                await _dominioService.AgregarDom(listaDominio, 33, "Procedencia de la Unidad");
                await _dominioService.AgregarDom(listaDominio, 34, "Cantidad de Gasolina");
                await _dominioService.AgregarDom(listaDominio, 35, "Situación de un renglón de O/S");
                await _dominioService.AgregarDom(listaDominio, 36, "Estatus de la Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 37, "Ubicación de Unidad");
                await _dominioService.AgregarDom(listaDominio, 38, "Tipo de redondeo en precios");
                await _dominioService.AgregarDom(listaDominio, 39, "Origen del Comprobante Contable");
                await _dominioService.AgregarDom(listaDominio, 40, "Tipo de Documento Bancario");
                await _dominioService.AgregarDom(listaDominio, 41, "Tipo de Recibo de Ingreso");
                await _dominioService.AgregarDom(listaDominio, 42, "Tipo de Abono a un Documento");
                await _dominioService.AgregarDom(listaDominio, 43, "Instrumentos de Pago");
                await _dominioService.AgregarDom(listaDominio, 44, "Estado de Avalúo");
                await _dominioService.AgregarDom(listaDominio, 45, "Tipo de Cuenta Contable");
                await _dominioService.AgregarDom(listaDominio, 46, "Tipo de Cuenta Contable por Modelo");
                await _dominioService.AgregarDom(listaDominio, 47, "Estado de Partes de Unidad para Revisión");
                await _dominioService.AgregarDom(listaDominio, 48, "Zona de la Unidad para Revisión");
                await _dominioService.AgregarDom(listaDominio, 49, "Procedencia Unidad Ventas");
                await _dominioService.AgregarDom(listaDominio, 50, "Tipo de Pedido de Unidades");
                await _dominioService.AgregarDom(listaDominio, 51, "Tipo de Extension para Archivos Documentos");
                await _dominioService.AgregarDom(listaDominio, 52, "Estatus de Unidad en Inventario");
                await _dominioService.AgregarDom(listaDominio, 53, "Estatus de Unidad en Compra");
                await _dominioService.AgregarDom(listaDominio, 54, "Estatus de Unidad en Venta");
                await _dominioService.AgregarDom(listaDominio, 55, "Nivel de Ubicación para Unidades");
                await _dominioService.AgregarDom(listaDominio, 56, "Opciones de Recepción de Unidades");
                await _dominioService.AgregarDom(listaDominio, 57, "Opciones de Entrega de Unidades");
                await _dominioService.AgregarDom(listaDominio, 59, "Tipo de Modalidad para Impuestos");
                await _dominioService.AgregarDom(listaDominio, 60, "Estatus de Recibo de Ingreso en Caja");
                await _dominioService.AgregarDom(listaDominio, 61, "Estatus de cierre de las cajas");
                await _dominioService.AgregarDom(listaDominio, 62, "Procesos de ventanas para seguridad");
                await _dominioService.AgregarDom(listaDominio, 63, "Tipo de Tarjeta");
                await _dominioService.AgregarDom(listaDominio, 64, "Tipo de Persona en General");
                await _dominioService.AgregarDom(listaDominio, 65, "Tipo de Origen de Renglón de Unidad Comprado");
                await _dominioService.AgregarDom(listaDominio, 66, "Clasificacion 01 de Documentos en CXC y CXP");
                await _dominioService.AgregarDom(listaDominio, 67, "Clasificacion 02 de Documentos en CXC y CXP");
                await _dominioService.AgregarDom(listaDominio, 68, "Modalidad de Frequencia en Refinanciamiento");
                await _dominioService.AgregarDom(listaDominio, 69, "Tipo de Compra General");
                await _dominioService.AgregarDom(listaDominio, 70, "Tipo de Comprobante Contable");
                await _dominioService.AgregarDom(listaDominio, 71, "Estatus de Activo Fijo");
                await _dominioService.AgregarDom(listaDominio, 72, "Tipo de Personal Interno para la Compania");
                await _dominioService.AgregarDom(listaDominio, 73, "Forma de Pago");
                await _dominioService.AgregarDom(listaDominio, 74, "Ubicacion del Documento");
                await _dominioService.AgregarDom(listaDominio, 75, "Tipo de Clasificacion para AF");
                await _dominioService.AgregarDom(listaDominio, 76, "Origen de Depósito");
                await _dominioService.AgregarDom(listaDominio, 77, "Modalidad de la Orden de Compra (Repuestos)");
                await _dominioService.AgregarDom(listaDominio, 78, "Asociaciones por Marca");
                await _dominioService.AgregarDom(listaDominio, 79, "Modalidad de Descuento");
                await _dominioService.AgregarDom(listaDominio, 80, "Modalidad de Pago a Mecánico");
                await _dominioService.AgregarDom(listaDominio, 81, "Modalidad de Comisión");
                await _dominioService.AgregarDom(listaDominio, 82, "Tipo de desglose Contable");
                await _dominioService.AgregarDom(listaDominio, 83, "Tipo de Documento en Contabilidad");
                await _dominioService.AgregarDom(listaDominio, 84, "Tipo de Ajuste por Inflación");
                await _dominioService.AgregarDom(listaDominio, 85, "Tipo de Auxiliar Contable");
                await _dominioService.AgregarDom(listaDominio, 86, "Tipo de Asociación por Modelo");
                await _dominioService.AgregarDom(listaDominio, 87, "Marcas de Unidades");
                await _dominioService.AgregarDom(listaDominio, 88, "Tipo de arbol");
                await _dominioService.AgregarDom(listaDominio, 89, "Tipo de Tab General asociado a Modelo");
                await _dominioService.AgregarDom(listaDominio, 90, "Tipo de Mano de Obra");
                await _dominioService.AgregarDom(listaDominio, 91, "Tipo de asociacion de Modelo con Tabcia");
                await _dominioService.AgregarDom(listaDominio, 92, "Tipo de Observacion en Unidades");
                await _dominioService.AgregarDom(listaDominio, 93, "Modalidad de Precios");
                await _dominioService.AgregarDom(listaDominio, 94, "Tipo de Replicación");
                await _dominioService.AgregarDom(listaDominio, 95, "Tipo de Subscripción");
                await _dominioService.AgregarDom(listaDominio, 96, "Tipo de Departamento de Servicio");
                await _dominioService.AgregarDom(listaDominio, 97, "Configuracion Contable");
                await _dominioService.AgregarDom(listaDominio, 98, "Base de Cálculo");
                await _dominioService.AgregarDom(listaDominio, 99, "Estatus de Plan Mayor");
                await _dominioService.AgregarDom(listaDominio, 100, "Operacion de Traspaso en la Contabilidad");
                await _dominioService.AgregarDom(listaDominio, 101, "Tamaño del papel de impresión");
                await _dominioService.AgregarDom(listaDominio, 102, "Tipo de Font para impresión");
                await _dominioService.AgregarDom(listaDominio, 103, "Tipo de Consecutivo por Compañía");
                await _dominioService.AgregarDom(listaDominio, 104, "Tipo de Cargo");
                await _dominioService.AgregarDom(listaDominio, 105, "Clase de Mano de Obra");
                await _dominioService.AgregarDom(listaDominio, 106, "Tipo de detalle para reportes contables");
                await _dominioService.AgregarDom(listaDominio, 107, "Funciones para reportes contables");
                await _dominioService.AgregarDom(listaDominio, 108, "Categoria de Unidad");
                await _dominioService.AgregarDom(listaDominio, 109, "Tipo de Comisión");
                await _dominioService.AgregarDom(listaDominio, 110, "Tipo de Refinanciamiento en CXC");
                await _dominioService.AgregarDom(listaDominio, 111, "Nivel de Satisfaccion Citas");
                await _dominioService.AgregarDom(listaDominio, 112, "Contacto Correctivo Citas");
                await _dominioService.AgregarDom(listaDominio, 113, "Problema Correctivo Citas");
                await _dominioService.AgregarDom(listaDominio, 114, "Responsable Correctivo Citas");
                await _dominioService.AgregarDom(listaDominio, 115, "Grupo de Indicador de Cita");
                await _dominioService.AgregarDom(listaDominio, 116, "Indicador de Cita");
                await _dominioService.AgregarDom(listaDominio, 117, "Dias de la Semana");
                await _dominioService.AgregarDom(listaDominio, 118, "Tipo de Relacion en Movimientos Bancarios");
                await _dominioService.AgregarDom(listaDominio, 119, "Tipo de Observacion en Servicio");
                await _dominioService.AgregarDom(listaDominio, 120, "Tipo de Contabilizacion en Servicio");
                await _dominioService.AgregarDom(listaDominio, 121, "Parametros de la Contabilidad");
                await _dominioService.AgregarDom(listaDominio, 122, "Reclamos de Garantia en O/S");
                await _dominioService.AgregarDom(listaDominio, 123, "Estatus de Conciliación");
                await _dominioService.AgregarDom(listaDominio, 124, "Tipo de Venta Perdida");
                await _dominioService.AgregarDom(listaDominio, 125, "Tipo de Cambio en la Venta");
                await _dominioService.AgregarDom(listaDominio, 126, "Estatus del detalle de la Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 127, "Tipo de Hora para Técnicos");
                await _dominioService.AgregarDom(listaDominio, 128, "Grupo de Parametros");
                await _dominioService.AgregarDom(listaDominio, 129, "Tipo de Oferta en precios");
                await _dominioService.AgregarDom(listaDominio, 130, "Tipo de Oferta en fecha");
                await _dominioService.AgregarDom(listaDominio, 131, "Tipo de Configuración de Usuario");
                await _dominioService.AgregarDom(listaDominio, 132, "Tipo de Pedido Sugerido");
                await _dominioService.AgregarDom(listaDominio, 133, "Tipo de Anulación en Compra/Venta de Repuestos");
                await _dominioService.AgregarDom(listaDominio, 134, "Estatus de Reclamo de Garantía");
                await _dominioService.AgregarDom(listaDominio, 135, "Tipo de Costos para Importación");
                await _dominioService.AgregarDom(listaDominio, 136, "Tipo de Presupuesto");
                await _dominioService.AgregarDom(listaDominio, 137, "Estado de la Unidad");
                await _dominioService.AgregarDom(listaDominio, 138, "Estatus de Importación");
                await _dominioService.AgregarDom(listaDominio, 139, "Tipo de Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 140, "Tipo de Expediente");
                await _dominioService.AgregarDom(listaDominio, 141, "Tipo de Precio para Garantía con Fuente");
                await _dominioService.AgregarDom(listaDominio, 142, "Tipo de Dato por Persona");
                await _dominioService.AgregarDom(listaDominio, 143, "Tipo de Importación de datos de Garantías");
                await _dominioService.AgregarDom(listaDominio, 144, "Tipo de Status Logístico");
                await _dominioService.AgregarDom(listaDominio, 145, "Tipo de Status Comercial");
                await _dominioService.AgregarDom(listaDominio, 146, "Tipo de Traslado");
                await _dominioService.AgregarDom(listaDominio, 147, "Tipo de Certificado para Unidades");
                await _dominioService.AgregarDom(listaDominio, 148, "Modalidad de Cálculo para PVP unico");
                await _dominioService.AgregarDom(listaDominio, 149, "Modalidad en Reconocimiento de Garantía");
                await _dominioService.AgregarDom(listaDominio, 150, "Tipo de Relación Persona/Tabg");
                await _dominioService.AgregarDom(listaDominio, 151, "Tipo de Paquete");
                await _dominioService.AgregarDom(listaDominio, 152, "Tipo de Análisis de Repuestos");
                await _dominioService.AgregarDom(listaDominio, 153, "Tipo de Consecutivo por Base de Datos");
                await _dominioService.AgregarDom(listaDominio, 154, "Tipo de Pago de Cadivi");
                await _dominioService.AgregarDom(listaDominio, 155, "Estatus de Expediente Cadivi");
                await _dominioService.AgregarDom(listaDominio, 156, "Tipo de Resumen de Sugerido");
                await _dominioService.AgregarDom(listaDominio, 157, "Tipo de Programa para Unidades");
                await _dominioService.AgregarDom(listaDominio, 158, "Operación Contable");
                await _dominioService.AgregarDom(listaDominio, 159, "Auxiliar Contable");
                await _dominioService.AgregarDom(listaDominio, 160, "Origen Contable Detallado");
                await _dominioService.AgregarDom(listaDominio, 161, "Tipo de Consecutivo para Documentos");
                await _dominioService.AgregarDom(listaDominio, 162, "Tipo de Documentos para Consecutivos");
                await _dominioService.AgregarDom(listaDominio, 163, "Tipo de Producto");
                await _dominioService.AgregarDom(listaDominio, 164, "Tipo de Impuesto");
                await _dominioService.AgregarDom(listaDominio, 165, "Colores para Unidades en Tablero");
                await _dominioService.AgregarDom(listaDominio, 166, "Tipo de Compañía");
                await _dominioService.AgregarDom(listaDominio, 167, "Tipo de Toma de Inventario");
                await _dominioService.AgregarDom(listaDominio, 168, "Tamaño del Daño");
                await _dominioService.AgregarDom(listaDominio, 169, "Responsable del Daño");
                await _dominioService.AgregarDom(listaDominio, 170, "Tipo de Urgencia para Casos");
                await _dominioService.AgregarDom(listaDominio, 171, "Tipo de Aplicación para Casos");
                await _dominioService.AgregarDom(listaDominio, 172, "Tipo de Caso");
                await _dominioService.AgregarDom(listaDominio, 173, "Estatus de Cliente para Casos");
                await _dominioService.AgregarDom(listaDominio, 174, "Estatus de Consultor para Casos");
                await _dominioService.AgregarDom(listaDominio, 175, "Estatus de Analista para Casos");
                await _dominioService.AgregarDom(listaDominio, 176, "Tipo de Suspensión de Soporte");
                await _dominioService.AgregarDom(listaDominio, 177, "Tipo de Usuario de Help desk");
                await _dominioService.AgregarDom(listaDominio, 178, "Tipo de Aplicación");
                await _dominioService.AgregarDom(listaDominio, 179, "Estatus de Revisión de Unidad");
                await _dominioService.AgregarDom(listaDominio, 180, "Cálculo de Días Excentos");
                await _dominioService.AgregarDom(listaDominio, 181, "Tipo de Reporte a Imprimir");
                await _dominioService.AgregarDom(listaDominio, 182, "Tipo de Ajuste en Precio");
                await _dominioService.AgregarDom(listaDominio, 183, "Tipo de Campaña");
                await _dominioService.AgregarDom(listaDominio, 184, "Estado de la Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 185, "Tipo de Mensaje de Texto");
                await _dominioService.AgregarDom(listaDominio, 186, "Tipo de Reporte Configurable");
                await _dominioService.AgregarDom(listaDominio, 187, "Tipo de Tasa de Interes");
                await _dominioService.AgregarDom(listaDominio, 188, "Tipo de Estatus Star");
                await _dominioService.AgregarDom(listaDominio, 189, "Tipo de Transacción");
                await _dominioService.AgregarDom(listaDominio, 190, "Tipo de Exención de Impuesto");
                await _dominioService.AgregarDom(listaDominio, 191, "Tipo de Archivo GWM");
                await _dominioService.AgregarDom(listaDominio, 192, "Tipo de Departamento de Unidades");
                await _dominioService.AgregarDom(listaDominio, 193, "Clase de Orden de Servicio");
                await _dominioService.AgregarDom(listaDominio, 194, "Tipo de Actividad de Consultores");
                await _dominioService.AgregarDom(listaDominio, 195, "Tipo de Estatus de Mensajería");
                await _dominioService.AgregarDom(listaDominio, 196, "Tipo de Prioridad de Mensajería");
                await _dominioService.AgregarDom(listaDominio, 197, "Consultores de Infoauto");
                await _dominioService.AgregarDom(listaDominio, 198, "Modalidad para el inicio de la Depreciación");
                await _dominioService.AgregarDom(listaDominio, 199, "Tipo de Relación en Personas");
                await _dominioService.AgregarDom(listaDominio, 200, "Tipo de Campo para Facturas");
                await _dominioService.AgregarDom(listaDominio, 201, "Tipo de Campo para Marcas");
                await _dominioService.AgregarDom(listaDominio, 202, "Tipo de Uso en Unidades");
                await _dominioService.AgregarDom(listaDominio, 203, "Tipo de Contacto para Clientes");
                await _dominioService.AgregarDom(listaDominio, 204, "Tipo de Código para Usuario");
                await _dominioService.AgregarDom(listaDominio, 205, "Tipo de Rango para Comisiones de Repuestos");
                await _dominioService.AgregarDom(listaDominio, 206, "Tipo de Impresora Fiscal");
                await _dominioService.AgregarDom(listaDominio, 207, "Nivel de Satisfaccion Citas Mazda");
                await _dominioService.AgregarDom(listaDominio, 208, "Tipo de HardKey");
                await _dominioService.AgregarDom(listaDominio, 209, "Tipo de Pregunta de Seguridad");
                await _dominioService.AgregarDom(listaDominio, 210, "Origen de Lote de Inventario");
                await _dominioService.AgregarDom(listaDominio, 211, "Tipo de Licencia");
                await _dominioService.AgregarDom(listaDominio, 212, "Tipo de Dealer");
                await _dominioService.AgregarDom(listaDominio, 213, "Tipo de Certificación");
                await _dominioService.AgregarDom(listaDominio, 214, "Tipo de Módulo");
                await _dominioService.AgregarDom(listaDominio, 215, "Tipo de Producto N1");
                await _dominioService.AgregarDom(listaDominio, 216, "Tipo de Producto N2");
                await _dominioService.AgregarDom(listaDominio, 217, "Tipo de Producto N3");
                await _dominioService.AgregarDom(listaDominio, 218, "Modalidad Mano de Obra");
                await _dominioService.AgregarDom(listaDominio, 219, "Tipo de llamada CRM");
                await _dominioService.AgregarDom(listaDominio, 220, "Estatus de Prospecto CRM");
                await _dominioService.AgregarDom(listaDominio, 221, "Origen de Prospecto CRM");
                await _dominioService.AgregarDom(listaDominio, 222, "Tipo de Cargo para Vehículos");
                await _dominioService.AgregarDom(listaDominio, 223, "Tipo de Origen para Kms");
                await _dominioService.AgregarDom(listaDominio, 224, "Tipo de Combustible");
                await _dominioService.AgregarDom(listaDominio, 225, "Tipo de Comision Veh");
                await _dominioService.AgregarDom(listaDominio, 226, "Tipo de Valor para Tabla Basica");
                await _dominioService.AgregarDom(listaDominio, 227, "Tipo de Relación Persona/Vehiculo");
                await _dominioService.AgregarDom(listaDominio, 228, "Tipo de Ausencia");
                await _dominioService.AgregarDom(listaDominio, 229, "Tipo de Medida");
                await _dominioService.AgregarDom(listaDominio, 230, "Tipo de Concepto");
                await _dominioService.AgregarDom(listaDominio, 231, "Tipo de Fórmula");
                await _dominioService.AgregarDom(listaDominio, 232, "Tipo de Frecuencia");
                await _dominioService.AgregarDom(listaDominio, 233, "Tipo de Relación Empleado/Persona");
                await _dominioService.AgregarDom(listaDominio, 234, "Estatus de Empleado en la Cia");
                await _dominioService.AgregarDom(listaDominio, 235, "Forma de Pago para Nómina en la Cia");
                await _dominioService.AgregarDom(listaDominio, 236, "Modo de Deducción para CXC en Nómina");
                await _dominioService.AgregarDom(listaDominio, 237, "Origen de Concepto en Nómina");
                await _dominioService.AgregarDom(listaDominio, 238, "Tipo de Regla para CRM");
                await _dominioService.AgregarDom(listaDominio, 239, "Tipo de Servicio para CRM");
                await _dominioService.AgregarDom(listaDominio, 240, "Campo para Vehículo");
                await _dominioService.AgregarDom(listaDominio, 241, "Campo para Persona");
                await _dominioService.AgregarDom(listaDominio, 242, "Tipo de Programa de Correo");
                await _dominioService.AgregarDom(listaDominio, 243, "Modalidad de Concepto de Nomina");
                await _dominioService.AgregarDom(listaDominio, 244, "Tipo de Movimiento en Puesto de Trabajo");
                await _dominioService.AgregarDom(listaDominio, 245, "Tipo de Modalidad de Dcto en Doc de Nomina");
                await _dominioService.AgregarDom(listaDominio, 246, "Tipo de Relación Persona/Persona CRM");
                await _dominioService.AgregarDom(listaDominio, 247, "Tipo de envío de Mensajes de Texto");
                await _dominioService.AgregarDom(listaDominio, 248, "Tipo en Nivel por Departamento");
                await _dominioService.AgregarDom(listaDominio, 249, "Tipo en Nivel por Compañía");
                await _dominioService.AgregarDom(listaDominio, 250, "Condición para Incentivos");
                await _dominioService.AgregarDom(listaDominio, 251, "Tipo de Documento para CRM");
                await _dominioService.AgregarDom(listaDominio, 252, "Estatus de Persona como Cliente");
                await _dominioService.AgregarDom(listaDominio, 253, "Estatus de Persona como Proveedor");
                await _dominioService.AgregarDom(listaDominio, 254, "Formato de Dirección");
                await _dominioService.AgregarDom(listaDominio, 255, "Tipo de Identificación");
                await _dominioService.AgregarDom(listaDominio, 256, "Tipo de Contrato Dana");
                await _dominioService.AgregarDom(listaDominio, 257, "Tipo de Campo de Dirección");
                await _dominioService.AgregarDom(listaDominio, 258, "Tipo de Referencia para Existencias por Ref.");
                await _dominioService.AgregarDom(listaDominio, 259, "Tipo de Formato General para Imprimir");
                await _dominioService.AgregarDom(listaDominio, 260, "Tipo de Código para Lector");
                await _dominioService.AgregarDom(listaDominio, 261, "Subtipo para Edo. Finan.");
                await _dominioService.AgregarDom(listaDominio, 262, "Tipo de Comunicación Dana");
                await _dominioService.AgregarDom(listaDominio, 263, "Estatus SMS Dana");
                await _dominioService.AgregarDom(listaDominio, 264, "Estatus Email Dana");
                await _dominioService.AgregarDom(listaDominio, 265, "Tipo de Operacion Infoauto");
                await _dominioService.AgregarDom(listaDominio, 266, "Estatus de Documento de Rep.");
                await _dominioService.AgregarDom(listaDominio, 267, "Estatus de Cita por Técnico");
                await _dominioService.AgregarDom(listaDominio, 268, "Estatus de Agenda Ford");
                await _dominioService.AgregarDom(listaDominio, 269, "Tipo de Operacion Log Dana");
                await _dominioService.AgregarDom(listaDominio, 270, "Tipo de Fecha Contable para Recibos");
                await _dominioService.AgregarDom(listaDominio, 271, "Tipo de Distribución de Gastos");
                await _dominioService.AgregarDom(listaDominio, 272, "Tipo de Proceso en ASA");
                await _dominioService.AgregarDom(listaDominio, 273, "Tipo de Relación Recibo/Vehiculo");
                await _dominioService.AgregarDom(listaDominio, 274, "Tipo de Grupo IVR");
                await _dominioService.AgregarDom(listaDominio, 275, "Medida de Peso");
                await _dominioService.AgregarDom(listaDominio, 276, "Medida de Volumen");
                await _dominioService.AgregarDom(listaDominio, 277, "Tipo de Frecuencia CRM");
                await _dominioService.AgregarDom(listaDominio, 278, "Variables para Formatos de CRM");
                await _dominioService.AgregarDom(listaDominio, 279, "Tipo de Anexo CRM");
                await _dominioService.AgregarDom(listaDominio, 280, "Estatus de Proceso de CRM");
                await _dominioService.AgregarDom(listaDominio, 281, "Tipo de Repetición de Eventos");
                await _dominioService.AgregarDom(listaDominio, 282, "Tipo de Trigger de Eventos");
                await _dominioService.AgregarDom(listaDominio, 283, "Tipo de Periodo para Eventos");
                await _dominioService.AgregarDom(listaDominio, 284, "Modalidad de disparo de Proceso de CRM");
                await _dominioService.AgregarDom(listaDominio, 285, "Tipo de Evento de disparo de Proceso de CRM");
                await _dominioService.AgregarDom(listaDominio, 286, "Tipo de Concepto para Medios Magnéticos");
                await _dominioService.AgregarDom(listaDominio, 287, "Tipo de Formato para Medios Magnéticos");
                await _dominioService.AgregarDom(listaDominio, 288, "Tipo de Valor para Medios Magnéticos");
                await _dominioService.AgregarDom(listaDominio, 289, "Tipo de Medida para Alto Ancho Profundo");
                await _dominioService.AgregarDom(listaDominio, 290, "Tipo de Rango para Comisiones de Servicio");
                await _dominioService.AgregarDom(listaDominio, 291, "Tipo de Distribución de Expediente");
                await _dominioService.AgregarDom(listaDominio, 292, "Tipo de Item para IF");
                await _dominioService.AgregarDom(listaDominio, 293, "Procedencia Requis. de Rep.");
                await _dominioService.AgregarDom(listaDominio, 294, "Módulo para Videos");
                await _dominioService.AgregarDom(listaDominio, 295, "Status para Leasing Propio");
                await _dominioService.AgregarDom(listaDominio, 296, "Tipo de Operación Bancaria");
                await _dominioService.AgregarDom(listaDominio, 297, "Tablas");
                await _dominioService.AgregarDom(listaDominio, 298, "Motivo de Desatencion de Soporte");
                await _dominioService.AgregarDom(listaDominio, 299, "Tipo de Importacion de Mov. bancarios");
                await _dominioService.AgregarDom(listaDominio, 300, "Tipo de Giro Leasing");
                await _dominioService.AgregarDom(listaDominio, 301, "Tipo de Reglon Leasing");
                await _dominioService.AgregarDom(listaDominio, 302, "Estatus de Contrato Leasing");
                await _dominioService.AgregarDom(listaDominio, 303, "Subtipo de O/S MSI");
                await _dominioService.AgregarDom(listaDominio, 304, "Tipo de SMTP para email");
                await _dominioService.AgregarDom(listaDominio, 305, "Tipo para envio de email");
                await _dominioService.AgregarDom(listaDominio, 306, "Frecuencia para Reportes");
                await _dominioService.AgregarDom(listaDominio, 307, "Tipo de Gasto para Sales Tax");
                await _dominioService.AgregarDom(listaDominio, 308, "Tipo de Comprobante");
                await _dominioService.AgregarDom(listaDominio, 309, "Tipo de Comprobante NIC");
                await _dominioService.AgregarDom(listaDominio, 310, "SubTipo de Documento");
                await _dominioService.AgregarDom(listaDominio, 311, "Tipo Esp. de Impuesto");
                await _dominioService.AgregarDom(listaDominio, 313, "Paises Infoauto");
                await _dominioService.AgregarDom(listaDominio, 314, "Tipo de Archivo de persona");
                await _dominioService.AgregarDom(listaDominio, 315, "Tipo de Redes Sociales");

                await _dominioService.SalvarLista(listaDominio);

                return;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //------------------------------------------------------------------
        // Crear los detalles de los dominios en el pais Vzla
        //------------------------------------------------------------------

        public async Task CreaDominiosDetalleDeVzla()
        {
            try
            {
                int pais = 1862;
                var listaDominioDet = new List<DominioDet>();

                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 0, "No Aplica", "N/A", 0, 0, 0); ;
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 1, "Reposicion", "REPO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 2, "Promedio", "PROM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 3, "Planta", "PLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 4, "Más Alto", "MAXI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 5, "Más Bajo", "MINI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 6, "Último", "ULTI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 7, "Histórico", "HIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 8, "FOB", "FOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 9, "LIFO", "LIFO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 10, "FIFO", "FIFO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 11, "Más Bajo en Exist.", "MINIEX", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 1, 12, "Más Alto en Exist.", "MAXIEX", 0, 0, 0);

                //  2  Tipo de Departamento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 2, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 2, 1, "Repuesto", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 2, 2, "Servicio", "SER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 2, 3, "Unidades", "UNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 2, 4, "Administración", "ADM", 0, 0, 0);

                //  3  Tipo de Dirección
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 3, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 3, 1, "Domicilio", "DOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 3, 2, "Oficina", "OFI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 3, 3, "Postal", "POST", 0, 0, 0);

                //  4  Tipo de Teléfono
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 1, "Domicilio", "DOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 2, "Oficina", "OFI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 3, "Móvil", "MOV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 4, "Fax", "FAX", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 4, 5, "Chevy Star", "CSTAR", 1, 0, 0);

                //  5  Tipo de Material
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 1, "Repuesto", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 2, "Mano de Obra", "MO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 3, "Paquete", "PAQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 4, "Otros Componentes", "COM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 5, "Trabajo en Otros Talleres", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 6, "Cargos", "CAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 7, "Descuentos", "DCTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 8, "Opciones de Planta", "OPC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 5, 9, "Clasificación de Servicio Express", "CSX", 0, 0, 0);

                //  6  Sexo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 6, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 6, 1, "Masculino", "M", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 6, 2, "Femenino", "F", 0, 0, 0);

                //  7  Estado Civil
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 7, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 7, 1, "Soltero", "S", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 7, 2, "Casado", "C", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 7, 3, "Viudo", "V", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 7, 4, "Divorciado", "D", 0, 0, 0);

                //  8  Tipo de Clasificación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 8, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 8, 1, "Dirección", "DIR", 0, 0, 0);

                //  9  Ambito de Tab
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 9, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 9, 1, "General", "G", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 9, 2, "Compañía", "C", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 9, 3, "Departamento", "D", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 9, 4, "Grupo Economico", "E", 0, 0, 0);

                //  10  Tipo de Clasificación de Dirección
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 1, "País", "PA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 2, "Estado", "ES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 3, "Ciudad", "CI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 4, "Urbanización", "UR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 10, 5, "Calle", "CA", 0, 0, 0);

                //  11  Tipo de Persona Departamental
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 2, "Proveedor", "PROV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 8, "Taller", "TAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 9, "Transportista", "TRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 15, "Caravanero", "CAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 16, "Garantia de Unidad", "GAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 11, 17, "Facturador a Terceros", "FACT3", 0, 0, 0);

                //  12  Tipo de Dato de Parámetro
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 1, "String", "STRING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 2, "Entero", "INT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 3, "Decimal", "DEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 4, "Boolean", "BOOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 12, 5, "BLOB", "BLOB", 0, 0, 0);

                //  13  Tipo de Descuento en Cliente
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 13, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 13, 1, "Descuento sobre PVP", "PVP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 13, 2, "Incremento del Costo", "COSTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 13, 3, "Utilidad en la Venta", "UTIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 13, 4, "Dcto sobre Precio en Etiqueta", "DCTO_PV_JUSTO", 0, 0, 0);

                //  14  Tipo de Parámetro
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 14, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 14, 1, "General", "GEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 14, 2, "Compañía", "CIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 14, 3, "Departamento", "DPTO", 0, 0, 0);

                //  15  Tipo Documento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 1, "Factura", "FAC", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 2, "Nota de Débito", "ND", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 3, "Nota de Crédito", "NC", -1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 4, "Pedido", "PED", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 5, "Cotización", "COT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 6, "Solicitud de Devolución", "SDV", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 7, "Solicitud de Nota de Crédito", "SNC", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 8, "Solicitud de Nota de Débito", "SND", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 9, "Devolución de Mercancía", "DEV", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 10, "Orden TOT", "OTOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 11, "NO USADA", "NU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 12, "Orden de Compra", "OC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 13, "Solicitud de Cotización", "SCOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 14, "Nota de Entrega", "NE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 15, "Recepción", "REC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 16, "Cierre de Inventario", "CIE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 17, "Nota de Entrada al Inventario", "NEI", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 18, "Nota de Salida al Inventario", "NSI", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 19, "Transferencia", "TRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 20, "Devolución de Transferencia", "DTRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 21, "Solicitud de Transferencia", "STRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 22, "Solicitud de Devolución de Transferencia", "SDTRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 23, "Cotización de O/S", "COTOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 24, "Orden de Servicio", "OS", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 25, "Reclamo de Garantía", "RGPL", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 26, "Prefactura", "PREF", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 27, "Anticipo", "ANTI", -1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 28, "Cheque Devuelto", "CHDEV", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 29, "Giro", "GIR", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 30, "Nota de Débito por Mora", "NDMORA", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 31, "Reclamo de Devolución", "RECLA", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 32, "Cheque", "CHQ", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 33, "Depósito", "DEP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 34, "Ajuste de Unidades de Unidades", "AJUUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 35, "Recibo", "RECIBO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 36, "Servicio a Ventas", "SERINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 37, "Factura Proforma", "FACTPRO", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 38, "Voucher para Cheques", "VOUCH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 39, "Transferencia de Débitos", "NDTRA", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 40, "Transferencia de Créditos", "NCTRA", -1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 41, "Préstamo", "PREST", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 42, "Remesa se Envío", "REME", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 43, "Remesa de Recepción", "REMR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 44, "Transferencia de Anticipo", "TRFANT", -1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 45, "Expediente de Importación", "EXPIMP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 46, "Ajuste Contable", "AJUCONT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 47, "Reclamo de Garantía a Fuentes", "RGPLFUE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 48, "Autorización de Reclamo de Garantía", "AUTRECLA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 49, "Documento Notariado", "DOCNOTAR", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 50, "Expediente de Nacionalización", "EXPNAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 51, "Traslado de Unidades", "TRASUNI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 52, "Expediente de In Bound", "EXPINB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 53, "Revisión de Daños y Accesorios", "REVACC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 54, "Transferencia de Efectos", "TRFEFE", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 55, "Débito Interno", "NDI", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 56, "Crédito Interno", "CRI", -1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 57, "Orden de Repación", "ORDREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 58, "Factura de Cotejo de Garantía", "FACTGAR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 59, "Transferencia de Unidades", "TRFVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 60, "Traslado de Ubicación de Unidades", "UBIVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 61, "Factura de Reclamo de Garantía", "FACTRECGAR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 62, "Pagaré Bancario", "PAGAREBAN", 1, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 63, "Certificado de Origen", "CERTORIG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 64, "Carta de Autorización en Servicio", "CARTAUT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 65, "Pre Nota de Crédito", "PRENC", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 66, "Comprobante de Requisición", "COMPREQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 67, "Ticket de Requisición", "TICKREQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 68, "Recepción Física de Vehículos", "RECFISVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 69, "Recepción Física de Productos", "RECFISPRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 70, "Entrega de Unidad (Fact.)", "ENTUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 71, "Etiqueta Pieza en Gtia. Estándar", "ETIQGARST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 72, "Cotización Integral de Veh.", "COTIINTVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 73, "Entrega de Unidad (Cotiz.)", "ENTINTVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 74, "Reclamo de Garantia (Formato Cliente)", "RECGARCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 75, "Etiquetas para Precios de Facturas", "ETIQPRECFACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 76, "Etiquetas para Precios de Existencias", "ETIQPRECINV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 77, "Etiquetas para Tomas de Inventario", "ETIQINVENT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 78, "Nota de Despacho", "NOTADESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 79, "Recepción de Repuestos en compra", "RECREPCOMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 80, "Preparación de Recepción de Repuesto", "PRERECREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 81, "Prueba de Carretera", "PRUCAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 82, "Presupuesto", "PRESUPUESTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 83, "Guia de Despacho", "GUIADESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 84, "Requisición de Repuestos", "REQUIREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 85, "Packing List", "PACKLIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 86, "Autorización de Salida de Servicio", "AUTSALSERNOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 87, "Autorización Especial de Salida de Servicio", "AUTSALSERESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 88, "Contrato Leasing", "INILEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 89, "Finiquito Leasing", "FINLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 90, "Recuperacion Leasing", "RECUPLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 91, "Perdida Leasing", "PERDLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 92, "Nota de Crédito Leasing", "NCREDLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 93, "Carta de Aceptación", "CARTAACEPT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 94, "Datos de la Póliza", "DATOSPOLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 95, "Ajuste de Costo de Inventario", "AJUCOSINV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 15, 96, "Etiqueta de despacho", "ETIQDESPACHO", 0, 0, 0);

                //  16  Procesos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 16, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 16, 1, "Venta de Repuestos", "VREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 16, 2, "Compra de Repuestos", "CREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 16, 3, "Recepción de Repuesto", "RREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 16, 36, "Factura Proforma", "FACPRO", 0, 0, 0);

                //  17  Tipo de Transferencia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 17, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 17, 1, "Depósito", "DEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 17, 2, "Orden de Servicio", "OS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 17, 3, "Unidad", "UNID", 0, 0, 0);

                //  18  Tipo de Garantía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 18, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 18, 1, "Garantía por Planta", "PLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 18, 2, "Garantía por Taller", "TAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 18, 3, "Garantía de Otra Concesionaria", "OCO", 0, 0, 0);

                //  19  Origen de Renglón de Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 0, "Sin Definir", "SIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 1, "Jaula de Taller", "JAU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 2, "Transferencia", "TRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 3, "Compra", "COM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 4, "TOT", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 5, "Mano de Obra", "MO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 19, 6, "Aportado por Cliente", "CLI", 0, 0, 0);

                //  20  Forma de Pago de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 1, "Contado", "CONT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 2, "Crédito", "CRED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 3, "Tarjeta Crédito", "TCRD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 4, "Financiamiento Interno", "FININT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 5, "Financiamiento Externo", "FINEXT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 20, 6, "Leasing Propio", "LEASEPROP", 0, 0, 0);

                //  22  Nivel de Ubicación en Depósito
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 22, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 22, 1, "Area", "AREA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 22, 2, "Pasillo", "PAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 22, 3, "Estante", "EST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 22, 4, "Entrepaño", "ENT", 0, 0, 0);

                //  23  Tipo de Extensión para Archivos Imagen
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 1, "BMP", "BMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 2, "JPG", "JPG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 3, "JPEG", "JPEG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 4, "RLE", "RLE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 5, "WMF", "WMF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 6, "GIF", "GIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 23, 7, "AVI", "AVI", 0, 0, 0);

                //  24  Modalidad del Documento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 24, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 24, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 24, 2, "Proveedor", "PRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 24, 3, "Interno", "INT", 0, 0, 0);

                //  25  Tipo de Impresora
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 25, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 25, 1, "Tinta", "TIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 25, 2, "Laser", "LAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 25, 3, "Impacto", "IMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 25, 4, "Térmica", "TER", 0, 0, 0);

                //llenaDom(26, "Tipo de Usuario")
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 26, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 26, 1, "Usuario", "USU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 26, 2, "Administrador Cia", "UCIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 26, 3, "Consultor", "CON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 26, 4, "Administrador", "ADM", 0, 0, 0);

                //  27  Tipo de Personal Interno para el Departamento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 1, "Asesor", "VEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 2, "Gerente", "GER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 3, "Mecánico", "MEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 4, "Almacenista", "ALM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 5, "Jefe", "JEME", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 6, "Administrativo", "ADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 7, "Supervisor", "JEVE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 8, "Asesor de Garantía", "ASEGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 9, "Asesor de Citas", "ASECITA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 10, "Asesor Transf. a Depósitos", "ASETRFDEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 11, "Asesor Transf. a O/S", "ASETRFOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 12, "Asesor Transf. a Vehículos", "ASETRFVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 13, "Asesor Precios IVR", "ASEPREIVR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 14, "Asesor Pedido IVR", "ASEPEDIVR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 15, "Asesor Orden de Compra IVR", "ASEOCIVR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 27, 16, "Gerente de F&I", "GERFI", 0, 0, 0);

                //  28  Tipo de Costo para Ajustes de Inventario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 28, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 28, 1, "Reposición", "REPOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 28, 2, "Promedio", "PROM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 28, 3, "Planta", "PLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 28, 4, "Ultimo", "ULT", 0, 0, 0);

                //  29  Tipo de Diferencia en Recepción de Transferencias
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 29, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 29, 1, "Sobrante", "SOB", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 29, 2, "Faltante", "FAL", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 29, 3, "Defectuoso", "DEF", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 29, 4, "No Corresponde", "NCO", -1, 0, 0);

                //  30  Meses del Año
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 1, "Enero", "ENE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 2, "Febrero", "FEB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 3, "Marzo", "MAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 4, "Abril", "ABR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 5, "Mayo", "MAY", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 6, "Junio", "JUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 7, "Julio", "JUL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 8, "Agosto", "AGO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 9, "Septiembre", "SEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 10, "Octubre", "OCT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 11, "Noviembre", "NOV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 30, 12, "Diciembre", "DIC", 0, 0, 0);

                //  31  Modalidad de Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 0, "Sin Definir", "SIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 2, "Daño Colateral", "DAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 3, "Exonerado", "EXO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 4, "Garantía Planta", "GPL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 5, "Garantía Propia", "GPR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 6, "Garantía Otros Talleres", "GOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 7, "Seguro", "SEG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 8, "Retrabajo", "RET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 31, 9, "Aportado por Cliente", "APCLI", 0, 0, 0);

                //  32  Estatus de Maquinaria
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 1, "Activa", "ACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 2, "En Reparación", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 3, "Dañada", "DAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 4, "No Disponible", "NOD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 32, 5, "Desincorporada", "DES", 0, 0, 0);

                //  33  Procedencia de la Unidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 33, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 33, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 33, 3, "Ventas", "VEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 33, 4, "Compañía", "CIA", 0, 0, 0);

                //  34  Cantidad de Gasolina
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 34, 0, "Tanque Vacío", "0", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 34, 1, "1/4 de Tanque", "1/4", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 34, 2, "1/2 Tanque", "1/2", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 34, 3, "3/4 de Tanque", "3/4", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 34, 4, "Tanque Lleno", "1", 0, 0, 0);

                //  35  Situación de un renglón de O/S
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 1, "Pedido", "PED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 2, "Iniciado", "INI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 3, "Recibido Parcialmente", "RECP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 4, "Solicitada Devolución de Compras", "SDVC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 5, "Solicitada Devolución de Transferencias", "SDVT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 6, "Devuelto", "DEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 7, "Paralizado x Autorización", "PARAUTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 8, "Paralizado x Repuesto", "PARAREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 9, "Paralizado x TOT", "PARATOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 10, "Detenido", "STOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 11, "Recibido", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 35, 12, "Finalizado", "FIN", 0, 0, 0);

                //  36  Estatus de la Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 36, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 36, 1, "Abierta", "ABI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 36, 2, "Paralizada", "PAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 36, 3, "Cerrada", "CER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 36, 4, "En Espera", "ESP", 0, 0, 0);

                //  37  Ubicación de Unidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 1, "Taller", "TAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 2, "TOT", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 3, "Estacionamiento", "EST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 4, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 5, "Ventas", "VEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 6, "Entregado", "ENTRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 7, "Pulmón", "PULM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 37, 160, "Pagos con Tarjeta", "PAGOTDC", 0, 0, 0);

                //  38  Tipo de redondeo en precios
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 38, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 38, 1, "Sin Redondeo", "NO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 38, 2, "Redondeo", "RED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 38, 3, "Más Alto", "MAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 38, 4, "Más Bajo", "MBA", 0, 0, 0);

                //  39  Origen del Comprobante Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 1, "Venta", "VTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 2, "Compra", "COMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 3, "Transferencia", "TRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 4, "Ajustes", "AJU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 5, "Orden de Servicio", "OS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 6, "Recibo de Caja", "RECI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 7, "Diferencial Cambiario", "DIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 8, "Depreciacion AF", "DEPAF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 9, "Transaccion Bancaria", "TRFBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 10, "Nomina", "NOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 11, "Cotejo", "COT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 12, "Garantia", "GAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 13, "Reclamo", "RECLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 14, "Traslado de Vehiculo", "TRAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 15, "CxC Documento Administrativo", "CXCADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 16, "CxP Documento Administrativo", "CXPADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 17, "Venta de Unidades", "VTAUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 18, "Compras Generales", "COMGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 19, "Activos Fijos", "AF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 20, "Garantías a las Concesionarias", "GARCON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 21, "Diferencial Cambiario en Documentos", "DIFDOC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 22, "Diferencial Cambiario en Bancos", "DIFBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 39, 99, "Manual", "MANUAL", 0, 0, 0);

                //  40  Tipo de Documento Bancario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 1, "Cheque", "CHQ", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 2, "Depósito", "DEP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 3, "Nota de Débito", "NDB", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 4, "Nota de Crédito", "NCR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 5, "Reverso de Cheque", "RCHQ", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 6, "Reverso de Depósito", "RDEP", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 7, "Reverso de Débito", "RNDB", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 8, "Reverso de Crédito", "RNCR", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 9, "Debito Bancario", "DEB", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 10, "Reverso de Debito Bancario", "RDEB", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 40, 11, "Crédito Bancario", "CREDBAN", 1, 0, 0);

                //  41  Tipo de Recibo de Ingreso
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 1, "Cobranza", "RING", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 2, "Anticipo de Clientes", "ANT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 3, "Cruce NC de Clientes", "XNC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 4, "Otros Ingresos de Caja Contra Conceptos", "OING", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 5, "Refinanciamiento a Clientes", "REF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 6, "Pago a Proveedor con Cheque/Nota de Debito", "PAGP", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 7, "Pago a Cliente con Cheque", "PAGC", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 8, "Incobrable", "INCOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 9, "Traspaso de Cuentas Por Cobrar", "TRASP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 10, "Cruce CXC y CXP", "XCCCCP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 11, "Pago a Cliente con Efectivo", "PAGEF", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 12, "Pago a Proveedor en Efectivo", "PAGPREF", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 13, "Cruce de Anticipos de Clientes", "XAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 14, "Anticipo a Proveedores con Cheque", "ANTP", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 15, "Cruce NC de Proveedores", "XNCP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 16, "Cruce de Anticipos de Proveedores", "XANP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 17, "Cruce de NC/DP Bancarios y CXC", "XBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 18, "Retenciones", "RETEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 20, "Retiro de Caja", "RETCAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 21, "Cierre de Caja", "CIECAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 22, "Otros Egresos de Caja Contra Conceptos", "OEGRE", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 23, "Otros Pagos Bancarios Contra Cuentas Contables", "OPAGO", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 24, "Otros Pagos Bancarios Contra Conceptos", "PAGOCPTO", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 25, "Dotaciones a Caja desde Tesoreria", "DOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 26, "Dotaciones a Tesoreria con Cheque", "DOTBAN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 27, "Cambio de Cheque Por Efectivo", "CAMEF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 28, "Retiro de Documento de Tesoreria", "RETTES", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 29, "Traspaso de Cuentas Por Pagar", "TCXP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 30, "Reposicion de Caja Chica Con Cheque", "CAJACHICA", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 31, "Pago a Proveedores Con Cheques de Cobranza", "PAGOCOB", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 32, "Reposicion de Caja Chica con Efectivo", "CAJACHICAE", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 33, "Anticipo a Proveedores Con Cheques de Cobranza", "ANTPCHCO", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 34, "Anticipo a Proveedores Con Efectivo de Cobranza", "ANTPEFCO", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 35, "Pagos Bancarios Contra Varios Conceptos", "PCPTOS", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 36, "Reintegro", "REINTE", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 37, "Conversión de Factura de Unidad en Giros", "FAVEGI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 38, "Transferencias Bancarias", "TRABCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 39, "Renovacion", "RECREN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 40, "Refinanciamiento", "RECREF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 41, "Préstamo", "PREST", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 42, "Pago con Cheque / Nota de Débito Bancaria", "PAGBAN", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 43, "Documentos al Descuento", "DOCDCTO", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 44, "Crédito sobre Documentos", "CREDOC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 45, "Comprobante de Retención de IVA", "RETIVA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 46, "Recibo de Pagaré Bancario", "RECPAGBAN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 47, "Anticipo con Depósito Bancario", "ANTDEPBAN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 48, "Comprobante de Retención Municipal", "COMRETMUNI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 49, "Comprobante de Retención de ISLR", "COMRETISLR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 50, "Recibo de Cobro a Terceros", "COBTERCE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 51, "Recibo de Pago a Terceros", "PAGTERCE", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 52, "Reverso de Traspaso", "REVTRASP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 53, "Recibo de Facturación de Giro Leasing", "RECFACTGIRLEA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 54, "Recibo de Recuperar Leasing", "RECRECUPLEA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 55, "Recibo de Perdida de Leasing", "RECPERDILEA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 41, 56, "Pagos con Tarjeta", "PAGOTDC", -1, 0, 0);

                //  42  Tipo de Abono a un Documento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 42, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 42, 1, "Abono", "ABO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 42, 2, "Descuento", "DES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 42, 3, "Retención", "RET", 0, 0, 0);

                //  43  Instrumentos de Pago
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 1, "Efectivo", "EFE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 2, "Cheque", "CHQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 3, "Tarjeta de Crédito", "TCR", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 4, "Tarjeta de Débito", "TDB", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 5, "Nota de Débito", "NDB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 6, "Nota de Crédito Bancaria", "NCRBAN", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 43, 7, "Depósito Bancario", "DEPBAN", 0, 0, 0);

                //  44  Estado de Avalúo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 1, "Excelente", "EXC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 2, "Bueno", "BUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 3, "Regular", "REG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 4, "Deteriorado", "DET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 44, 5, "Inservible", "INS", 0, 0, 0);

                //  45  Tipo de Cuenta Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 1, "Activos", "ACT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 2, "Pasivos", "PAS", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 3, "Capital", "CAP", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 4, "Ingresos", "INGR", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 5, "Egresos", "EGR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 6, "Per Orden", "ORD", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 45, 7, "Per Contra", "CON", -1, 0, 0);

                //  47  Estado de Partes de Unidad para Revisión
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 47, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 47, 1, "Bueno", "BUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 47, 2, "Regular", "REG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 47, 3, "Malo", "MAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 47, 4, "Faltante", "FAL", 0, 0, 0);

                //  49  Procedencia Unidad Ventas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 1, "No Definida", "NOD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 2, "Pedido a Planta", "PLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 3, "Stock", "STO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 4, "Otra Concesionaria", "OCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 49, 5, "Recuperación de Leasing", "RECLEAS", 0, 0, 0);

                //  50  Tipo de Pedido de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 50, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 50, 1, "Reposición de Inventario", "REPOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 50, 2, "Emergencia", "EMER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 50, 3, "Flotilla", "FLOT", 0, 0, 0);

                //  51  Tipo de Extension para Archivos Documentos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 51, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 51, 1, "Excel", "XLS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 51, 2, "Word", "DOC", 0, 0, 0);

                //  52  Estatus de Unidad en Inventario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 1, "Departamento", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 2, "Taller", "PED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 3, "T.O.T.", "RES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 4, "Demostración", "DEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 5, "Evento", "EVE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 6, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 7, "Disponible", "DISP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 52, 8, "Tránsito", "TRAN", 0, 0, 0);

                //  53  Estatus de Unidad en Compra
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 1, "Pedido", "PED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 2, "Confirmado", "CON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 3, "Recibido", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 4, "Facturado", "FAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 5, "En proceso de recepción", "PRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 53, 6, "Creado por Vendedor", "CREAVEND", 0, 0, 0);

                //  54  Estatus de Unidad en Venta
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 54, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 54, 1, "Reservado", "RES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 54, 2, "Facturado", "FAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 54, 3, "Entregado", "RET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 54, 4, "Disponible", "DIS", 0, 0, 0);

                //  55  Nivel de Ubicación para Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 55, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 55, 1, "Area", "DEPO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 55, 2, "Piso", "PISO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 55, 3, "Número", "NUM", 0, 0, 0);

                //  56  Opciones de Recepción de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 1, "Compra", "COMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 2, "Traspaso", "TRAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 3, "Custodia", "CUST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 4, "Consignación", "CONSI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 56, 5, "Tránsito", "TRANSI", 0, 0, 0);

                //  57  Opciones de Entrega de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 1, "Venta", "VTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 2, "Devolución de Consignación", "CONS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 3, "Devolución de Custodia", "CUST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 4, "Siniestro", "SIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 5, "Pase a Activo Fijo", "ACTF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 6, "Robo", "ROB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 57, 7, "Salida de Inventario", "SAL", 0, 0, 0);

                //  59  Tipo de Modalidad para Impuestos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 59, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 59, 1, "Sobre el Monto", "PCT_MTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 59, 2, "Sobre el Impuesto", "PCT_IMP", 0, 0, 0);

                //  60  Estatus de Recibo de Ingreso en Caja
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 1, "Caja", "CAJA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 2, "Retirado", "RET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 3, "Depositado", "DEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 4, "Recibo de Egreso", "EGR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 5, "Transacción Electrónica", "TRAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 6, "Faltante", "FAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 60, 7, "Dotación", "DOT", 0, 0, 0);

                //  61  Estatus de cierre de las cajas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 61, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 61, 1, "Aperturada", "APER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 61, 2, "Cerrada", "CERR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 61, 3, "Descuadre", "DESC", 0, 0, 0);

                //  62  Procesos de ventanas para seguridad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 1, "Anular", "ANUL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 2, "Aprobar", "APRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 3, "Confirmar", "CONF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 4, "Recibir", "RECIB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 5, "Entregar", "ENTR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 62, 6, "Facturar", "FACT", 0, 0, 0);

                //  63  Tipo de Tarjeta
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 63, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 63, 1, "Crédito", "CRED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 63, 2, "Débito", "DEBIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 63, 3, "Afiliado", "AFIL", 0, 0, 0);

                //  64  Tipo de Persona en General
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 1, "Cía del Grupo", "CIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 2, "Ent. Financiera", "ENTFIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 3, "Cía de Seguros", "SEG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 4, "Emisor de Tarjetas", "EMITAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 5, "Concesionaria", "CONCE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 6, "Planta", "PLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 7, "Corr. de Seguro", "CORR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 8, "Fuente de Prod.", "FUEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 9, "Transportista", "TRANSP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 10, "Ag. Aduanal", "ADUA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 11, "Teso. Nacional", "TESOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 12, "Hacienda", "HACI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 13, "Cliente HD", "HDESK", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 14, "Contrib. Formal", "CONTFORM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 15, "Contrib. Especial", "CONTESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 16, "Contrib. Ordinario", "CONTORD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 17, "Chevy Plan", "CHEVYPLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 18, "Ford Credit", "FORDCREDIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 19, "Casa de Repuestos", "CASAREPUESTOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 20, "Casa de Repuestos Autorizada", "CASAREPAUTOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 21, "Talleres Independientes", "TALLERINDEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 22, "Talleres Autorizados", "TALLERAUTOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 23, "Servicio Expreso", "SERVIEXPRESO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 24, "Flotilla", "FLOTILLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 25, "Empresa del Estado", "EMPRESTADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 26, "Institución del Estado", "INTITUESTADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 27, "Estación de Servicio", "ESTACIONSERV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 28, "Agente Autoretenedor", "AGENAUTORET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 64, 29, "Courier", "COURIER", 0, 0, 0);

                //  65  Tipo de Origen de Renglón de Unidad Comprado
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 0, "Presupuesto", "PRESU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 1, "Recepción de Unidades", "RECUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 2, "TOT de Unidades", "TOTUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 3, "Compra de Repuestos", "COMREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 4, "Orden de Servicio", "OS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 5, "Transferencia", "TRANSF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 65, 6, "Ajustes a Unidad", "AJUS", 0, 0, 0);

                //  66  Clasificacion 01 de Documentos en CXC y CXP
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 0, "No Aplica", "NA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 1, "Cotejar Garantías", "BON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 2, "Reclamos de devolución", "DEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 3, "Notas de Entrega de Repuestos", "NE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 4, "Notas de Entrega de TOT", "NETOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 5, "Notas de Entrega de Unidad", "NEUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 6, "Reconocimiento de Garantías a Concesionarios", "RECGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 7, "Reconocimiento de Garantías del Provvedor", "REPGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 8, "Factura generada x Refinanciamiento", "FACTREFIN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 9, "Factura a Terceros", "FACT3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 10, "Nota de Debito por Mora", "NDMORA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 11, "Documentos de Importación", "DOCIMPORT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 12, "Nota de Débito por compra de Vehículo Usado", "NDVEHUSADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 13, "Nota de Débito por Rebate de compra de Vehículo", "NDIREBVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 14, "Nota de Débito por Reserva de Banco de Vehículo", "NDIBANVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 15, "Nota de Débito por Reserva de Seguro de Vehículo", "NDISEGVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 16, "Nota de Crédito por compra de Vehículo Usado", "NCVEHUSADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 17, "Nota de Débito por Prod. Adic. en Vta Vehiculos", "NDISEGVID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 18, "NCR por Upsidedown en Venta de Vehículo", "NCIUPSIDE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 19, "NDB por Upsidedown en Compra de Vehículo", "NDIUPSIDE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 20, "NDB por Póliza No Devengada en Vehículo", "NDIPOLNODEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 21, "Nota de Débito por Financiamiento Externo ", "NDIFINEXTVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 22, "Giro Leasing", "GIROLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 23, "Factura Inicio Leasing", "FACTINILEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 24, "Factura Finiquito Leasing", "FACTFINLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 25, "Factura Giro Leasing", "FACTGIROLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 26, "Factura Aporte a Capital Leasing", "FACTCAPLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 27, "Factura de Pago Total Leasing", "FACTTOTLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 28, "Giro Rescate", "GIRORESCATE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 29, "Nota de Credito Giro Leasing", "NCRGIROLEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 30, "Nota de Credito Inicio Leasing", "NCRINILEASING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 66, 31, "Nota de Credito Aporte Capital Leasing", "NCRAPOCAPLEASING", 0, 0, 0);

                //  67  Clasificacion 02 de Documentos en CXC y CXP
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 67, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 67, 1, "Giro Normal", "GIRNOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 67, 2, "Giro Especial", "GIRESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 67, 3, "Prorrateable", "PRORR", 0, 0, 0);

                //  68  Modalidad de Frequencia en Refinanciamiento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 68, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 68, 1, "Dias", "DIAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 68, 2, "Mensual", "MENS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 68, 3, "Anual", "ANU", 0, 0, 0);

                //  69  Tipo de Compra General
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 69, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 69, 1, "Gasto", "GAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 69, 2, "Consumible", "CONS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 69, 3, "Activo Fijo", "ACT", 0, 0, 0);

                //  70  Tipo de Comprobante Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 70, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 70, 1, "Apertura", "APER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 70, 2, "Diario", "DIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 70, 3, "Cierre", "CIER", 0, 0, 0);

                //  71  Estatus de Activo Fijo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 71, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 71, 1, "Activo", "ACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 71, 2, "Desincorporado", "DES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 71, 3, "Depreciado", "DEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 71, 4, "En Depreciación", "END", 0, 0, 0);

                //  72  Tipo de Personal Interno para la Compania
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 1, "Cajero", "CAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 2, "Tesorero", "TES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 5, "Cobrador", "COBRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 6, "Empleado", "EMPLEADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 7, "Socio", "SOCIO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 8, "Contacto Soporte", "CONTSOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 9, "Operador de CRM", "OPERCRM", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 10, "Adm. Observaciones", "ADMOBS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 11, "Abrir Casos de Soporte", "ABRIRSOPORTE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 72, 12, "Administrador Versiones", "ADMIN_VERSION", 0, 0, 0);

                //  73  Forma de Pago
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 73, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 73, 1, "Contado", "CONT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 73, 2, "Crédito", "CRED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 73, 3, "Tarjeta Crédito", "TCRD", 0, 0, 0);

                //  74  Ubicacion del Documento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 74, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 74, 1, "Oficina", "OFI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 74, 2, "Cobrador", "COB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 74, 3, "Cliente", "CLI", 0, 0, 0);

                //  75  Tipo de Clasificacion para AF
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 75, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 75, 1, "Ubicaciones", "UBI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 75, 2, "Clasificaciones", "CLA", 0, 0, 0);

                //  76  Origen de Depósito
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 76, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 76, 1, "Caja", "CAJA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 76, 2, "Tesorería", "TESO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 76, 3, "Impuesto Prorrateable", "IMPPRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 76, 4, "Terminal Financiero", "TERMFIN", 0, 0, 0);

                //  77  Modalidad de la Orden de Compra (Repuestos)
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 77, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 77, 1, "Repuestos", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 77, 2, "Taller", "TAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 77, 3, "Unidades", "UNID", 0, 0, 0);

                //  78  Asociaciones por Marca
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 1, "Colores", "COL", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 2, "Secciones", "SEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 3, "ComplaintCodes", "COMPLCODE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 4, "Código Aprobación / Rechazo", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 5, "Tipos de Bono de Garantía", "BON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 6, "Tipo de Tapicería", "TAP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 7, "% Descuento para Repuestos", "GRP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 8, "Tipo de Frenos", "FRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 9, "Tipo de Motor", "MOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 10, "Tipo de Unidad", "UNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 11, "Clase de Unidad", "CLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 12, "Sistemas", "SIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 13, "Modalidad de O/C para Repuestos", "OCR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 14, "Modalidad de O/C para Taller", "OCT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 15, "Modalidad de O/C para Unidades", "OCV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 16, "Precio de Mano de Obra", "PMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 17, "Resolución de Fallas", "RFA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 18, "Categoría de Unidad", "CAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 19, "% Incremento para Repuestos en Garantía", "GAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 20, "Código de Concesionaria", "CODCON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 21, "% Descuento para Opciones de Planta", "DMOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 22, "Tempario de Mecánica", "TMECA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 23, "Archivo para el Logo de la Marca", "LOGO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 24, "CauseCodes", "CAUSECODE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 25, "% Incremento para TOT en Garantía", "GARTOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 26, "Tipo de mano de Obra General", "TIPOMO1", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 27, "Tipo de Mano de Obra Específica", "TIPOMO2", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 28, "Tipo de Garantía para Repuestos", "TIPOGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 29, "Tempario de Latonería", "TLATO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 30, "Tempario de Pintura", "TPINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 32, "Precio de MO para Cliente", "PREMOCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 33, "Precio de MO para Planta", "PREMOPLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 34, "Precio de MO para Interno", "PREMOINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 35, "Costo de MO", "COSTOMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 40, "TransactionTypeCodes", "TRANSTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 41, "Transaction Flag", "TRANSFLAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 42, "Net Item Type", "NETTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 43, "Transaction Expense Category", "TRANSEXPEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 44, "RentalReasonCodes", "RENTREASON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 45, "Supplemental Hour Type", "SUPPLEHOUR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 46, "AuthorizationCodes", "AUTHCODE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 49, "LaborOperationDependencyTypeCodes", "LABDEPTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 50, "Debit Reason", "DEBITREAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 51, "Warranty Clasification", "WARRACLAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 52, "Component Identifier", "COMPOIDENT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 53, "AdjsutmentReasonCodes", "ADJUREASON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 54, "LaborRateType", "LABRATETYP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 55, "LaborOperationTypeCodes", "LABORTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 56, "3CsRelationshipCodes", "3CSRELA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 57, "BusinessUnit", "BUSINESS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 58, "ComplaintCodeClarifyingQuestions", "CLARIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 59, "SyntaxTableDataElements", "STDATAELEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 60, "SyntaxTableTransactionFlags", "STTRANFLAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 61, "SyntaxTableNetItemTypeCodes", "STNETTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 62, "SyntaxTableNetItemFields", "STNETFIELD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 63, "SyntaxTableLaborTypes", "STLABTYPE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 64, "WarrantyClassificationByLaborOperationCodes", "WARCLASXLO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 65, "Prospección en Km/Millas", "PROSPKM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 66, "Prospección en Meses", "PROSPMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 67, "Costo de MO para Garantía", "COSTOMOGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 68, "Tipo de Caja", "TIPCAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 78, 69, "Tipo de Transmisión", "TIPTRANS", 0, 0, 0);

                //  79  Modalidad de Descuento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 79, 1, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 79, 2, "Global", "GLO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 79, 3, "Por Renglón", "REN", 0, 0, 0);

                //  80  Modalidad de Pago a Mecánico
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 1, "Nómina", "NOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 2, "Monto por Hora Trab.", "MHT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 3, "Monto por Hora Fact.", "MHF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 4, "% por Hora Trab.", "PHT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 5, "% por Hora Fact.", "PHF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 6, "% por Monto Fact.", "PMF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 7, "Monto Fijo por renglón", "MFIRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 8, "% sobre Utilidad Bruta", "PUTIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 9, "Monto Fijo por Factura", "MFIFA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 10, "% por Monto Fact. y Exonerados", "PMFE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 11, "Monto por Hora Comisión", "MHC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 12, "Monto asignado de Comisión", "MAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 13, "% por Costo", "PCF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 80, 14, "Monto por Cant. de M.O.", "MXC", 0, 0, 0);

                //  82  Tipo de desglose Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 1, "Cuenta", "CTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 2, "Impuesto", "IMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 3, "Banco", "BCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 4, "Concepto", "CON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 5, "Otros Ingresos", "OING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 6, "Otros Egresos", "OEGR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 7, "Retención", "RET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 8, "Anticipo a Clientes", "ANCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 9, "Anticipo a Proveedores", "ANTPR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 10, "Caja", "CAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 11, "Cuentas Por Cobrar", "CXC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 12, "Cuentas Por Pagar", "CXP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 13, "Inventario de Repuesto", "INV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 14, "Costo de Inventario de Repuesto", "COSIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 15, "Moras", "MOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 16, "Inventario de Unidades", "INVV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 82, 17, "Costo del Inventario de Unidades", "COSIV", 0, 0, 0);

                //  83  Tipo de Documento en Contabilidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 1, "Factura", "FAC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 2, "Nota de Débito", "ND", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 3, "Nota de Crédito", "NC", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 4, "Pedido", "PED", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 5, "Cotización", "COT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 6, "Solicitud de Devolución", "SDV", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 7, "Solicitud de Nota de Crédito", "SNC", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 8, "Solicitud de Nota de Débito", "SND", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 9, "Devolución de Mercancía", "DEV", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 10, "Orden TOT", "OTOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 11, "NO USADA", "NU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 12, "Orden de Compra", "OC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 13, "Solicitud de Cotización", "SCOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 14, "Nota de Entrega", "NE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 15, "Recepción", "REC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 16, "Cierre de Inventario", "CIE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 17, "Nota de Entrada al Inventario", "NEI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 18, "Nota de Salida al Inventario", "NSI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 19, "Transferencia", "TRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 20, "Devolución de Transferencia", "DTRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 21, "Solicitud de Transferencia", "STRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 22, "Solicitud de Devolución de Transferencia", "SDTRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 23, "Cotización de O/S", "COTOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 24, "Orden de Servicio", "OS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 25, "Reclamo de Garantía", "RGPL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 26, "Prefactura", "PREF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 27, "Anticipo", "ANTI", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 28, "Cheque Devuelto", "CHE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 29, "Giro", "GIR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 30, "Mora", "MORA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 31, "Reclamo de Devolución", "RECLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 32, "Cheque", "CHQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 83, 33, "Depósito Bancario", "DEP", 0, 0, 0);

                //  84  Tipo de Ajuste por Inflación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 84, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 84, 1, "Normal", "NOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 84, 2, "Simple", "SIM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 84, 3, "Otra Moneda", "OMON", 0, 0, 0);

                //  85  Tipo de Auxiliar Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 1, "Persona", "PER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 2, "Unidad", "UNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 3, "Activo Fijo", "AF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 4, "Caja", "CAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 85, 5, "Banco", "BCO", 0, 0, 0);

                //  86  Tipo de Asociación por Modelo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 1, "Acondicionamiento en Recepción", "ACON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 2, "Cargos Básicos en Recepción", "CAREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 3, "Cargos Básicos en Ventas", "CARVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 4, "TOT Básico en Ventas", "TOTVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 86, 5, "Accesorios Básicos en Ventas", "ACCEVTA", 0, 0, 0);

                //  87  Marcas de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 1, "Renault", "RENA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 2, "Volkswagen", "VOLK", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 3, "Audi", "AUDI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 4, "Chevrolet", "CHEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 5, "Ford", "FORD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 6, "Mazda", "MAZD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 7, "Hyundai", "HYUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 8, "Skoda", "SKOD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 9, "Toyota", "TOYO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 10, "New Holland", "NEW-H", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 11, "Case", "CASE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 12, "Nissan", "NIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 13, "Peugeot", "PEU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 14, "KIA", "KIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 15, "Mitsubishi", "MIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 16, "Iveco", "IVE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 17, "Chrysler", "CHR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 18, "Mercedes Benz", "MERC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 19, "Fuso", "FUSO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 20, "Fiat", "FIAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 21, "International", "INTER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 22, "JAC", "JAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 23, "Hyundai Col.", "HYUCOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 24, "Isuzu", "ISUZU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 25, "Gmac", "GMAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 26, "Hino", "HINO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 27, "Chery", "CHERY", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 28, "Jeep", "JEEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 29, "Piaggio", "PIAGGIO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 30, "Guzzi", "GUZZI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 31, "DongFeng", "DONGFENG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 32, "Empire Keeway", "EMPKEYWAY", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 33, "Citroën", "CITROEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 34, "MD", "MD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 35, "BMW", "BMW", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 36, "Alfa Romeo", "ALFAROMEO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 37, "Geely", "GEELY", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 38, "Honda", "HONDA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 39, "Lexus", "LEXUS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 40, "Land Rover", "LANDROVER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 41, "Seat", "SEAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 42, "Dodge", "DODGE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 43, "Yamaha", "YAMAHA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 44, "Higer", "HIGER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 45, "Daewoo", "DAEWOO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 46, "General", "GENERAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 87, 47, "Suzuki", "SUZUKI", 0, 0, 0);

                //  88  Tipo de arbol
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 1, "Ubicaciones de Repuestos en Depósitos", "UBIREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 2, "Direcciones", "DIR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 3, "Centros de Costo", "CC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 4, "Proyectos", "PRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 5, "Clasificación de prod_serv", "CLAREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 6, "Clasificación de prod_serv_cia", "CLAREPC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 7, "Clasificación de Activos Fijos", "CLAAF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 8, "Ubicación de Activos Fijos", "UBIAF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 9, "Ubicación de Unidades", "UBIUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 88, 10, "Sustitutos", "SUST", 0, 0, 0);

                //  90  Tipo de Mano de Obra
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 1, "Mecánica", "MEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 2, "Lavado", "LAV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 3, "Latonería", "LAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 4, "Pintura", "PINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 5, "Preentrega", "PRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 6, "Electricidad", "ELEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 7, "Transmisión", "TRANS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 8, "Tapicería", "TAP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 9, "Diagnóstico", "DIAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 10, "Control de Calidad", "CTRLCAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 11, "Pulitura", "PULIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 90, 12, "Monta Carga", "MONCAR", 0, 0, 0);

                //  91  Tipo de asociacion de Modelo con Tabcia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 91, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 91, 1, "Lista de Entrega de Unidad", "ENT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 91, 2, "Prospección Kms", "PROSKMS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 91, 3, "Prospección Meses", "PROSMES", 0, 0, 0);

                //  92  Tipo de Observacion en Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 92, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 92, 1, "Recepcion", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 92, 2, "Entrega", "ENT", 0, 0, 0);

                //  93  Modalidad de Precios
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 93, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 93, 1, "Incremento del Costo", "COS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 93, 2, "Descuento del PVP", "PVP", 0, 0, 0);

                //  94  Tipo de Replicación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 1, "Grupo Económico", "GRU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 2, "Compañía", "CIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 3, "Sucursal", "SUC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 4, "Departamento", "DEP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 94, 5, "Asesor de Ventas de Unidades", "UNID", 0, 0, 0);

                //  95  Tipo de Subscripción
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 95, 0, "Nada", "NADA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 95, 1, "Todo", "TODO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 95, 2, "Columna", "COL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 95, 3, "Clausula", "CLA", 0, 0, 0);

                //  96  Tipo de Departamento de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 96, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 96, 1, "Mecánica", "MEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 96, 2, "Latonería y Pintura", "LAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 96, 3, "Servicio Express", "SEX", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 96, 4, "Accesorios Venta", "ACC", 0, 0, 0);

                //  97  Configuracion Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 1, "Descuento en las Ventas", "DESCCXC", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 2, "Descuento en las Compras", "DESCCXP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 3, "Descuento en la Cobranza", "DESCCOB", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 4, "Descuento en los Pagos", "DESCPAGO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 5, "Cuentas Por Cobrar Crédito", "CXCCRED", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 6, "Efectos Por Cobrar", "EXC", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 7, "Cuentas Por Pagar Crédito", "CXPCRED", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 8, "Efectos Por Pagar", "EXP", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 9, "Moras en Cuentas Por Cobrar", "MORAC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 10, "Anticipos de Clientes", "ANTCXC", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 11, "Anticipos a Proveedores", "ANTCXP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 12, "Incobrables en CXC", "INCOB", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 13, "Tesoreria", "TESO", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 14, "Ventas de Repuestos", "VTAREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 15, "Gastos en Unidades de la Compañía", "GTOVEHCIA", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 16, "Costo de Venta de Repuestos", "COSTVTA", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 17, "Inventario de Repuestos", "INVENT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 18, "Comisiones Bancarias por Documentos al dcto", "COMBAN", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 19, "Pasivo Contigente en Notas de Entrega", "PCR", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 20, "Cheque Devuelto de Cliente", "CHDEVCLI", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 21, "Reclamos de Devolución", "PCS", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 22, "Costo de Venta de Opciones de Planta", "OSR", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 23, "Venta de TOT", "OSTOT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 24, "Venta de Mano de Obra", "OSMO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 25, "Inventario de repuestos  en Proceso", "INVTRA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 26, "Reclamos de Garantia Rechazados", "RECHGA", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 27, "Costo de Venta de TOT", "CVTOT", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 28, "CxC Temporal de NE a Clientes", "CXCTMPNE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 29, "Reclamos de Devolución Rechazados", "RDRECH", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 30, "Costo de Venta de Repuestos de Garantias", "VTAREPG", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 31, "Inventario en Proceso de TOT", "INVPTOT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 32, "Venta de Opciones de Planta", "TOTV", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 33, "Descuentos en Compra de Unidades", "DESVH", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 34, "Debito Bancario", "DEBBCO", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 35, "Préstamo", "PREST", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 36, "Inventario de Opciones de Planta", "OP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 37, "Cargos", "CARGOS", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 38, "Descuentos", "DESC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 39, "Cuentas Por Cobrar Contado", "CXCCONTA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 43, "Venta de Unidades", "VTAUNID", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 44, "Costo de Venta de Unidades", "COSTUNID", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 45, "Inventario de Unidades", "INVUNID", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 46, "Cuentas Por Cobrar Temporal de Garantia", "CXCGAR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 47, "Otros Gastos en Reclamo de Garantia", "OTROG", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 48, "Comision Bancaria en Tarjetas", "COMIBCO", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 49, "Impuestos en Tarjetas de Credito", "IMPCOBCO", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 50, "Venta de Mano de Obra de Garantia", "VTAMOGA", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 51, "Venta de Repuesto de Garantia", "VTAREPGA", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 52, "Venta de TOT de Garantia", "VTATOTGA", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 53, "Venta de Mano de Obra de Preentrega", "VTAMOP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 54, "Gastos de Preentrega", "GTOPRE", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 55, "Giros Especiales", "GIROESP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 56, "Intereses en Refinanciamiento de Clientes", "INTE_CLI", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 57, "Gastos en Refinaciamiento de Clientes", "CARG_CXC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 58, "Reclamo de Mano de Obra por Garantia", "RECLA_MO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 59, "Ctas Inexistentes en anulaciones", "CTAINEX", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 60, "Gastos por Cheque devuelto", "GASCHD", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 61, "Gastos Estimados en Ajuste de Unidades", "GASTMP", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 62, "Gastos Estimados en Ajuste de Repuestos", "GTOMPR", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 63, "Gastos en Documentos del Expediente", "GTODOC", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 64, "Garantías Reconocidas a los Concesionarios", "GARCON", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 65, "Garantías Reconocidas por las Fuentes", "GARFUE", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 66, "Diferencial Cambiario en CxC y CxP", "DIFCAM", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 67, "Costo de Venta de TOT en Garantía", "CTOTG", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 68, "Cuenta para Ajustes Automáticos", "CTAAJA", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 69, "Gastos en O/S Internas", "GASOSINT", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 70, "Renglones Exonerados en O/S", "EXONOS", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 71, "Inventario de Productos Terminados", "INVPT", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 72, "Costo de Mano de Obra Estimada", "CTOMOES", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 73, "Costo Indirecto de Produccion", "CTOIND", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 74, "Costo de Venta de Mano de Obra", "CTOVMO", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 75, "Costo de Venta de Carga Fabril", "CTOVCF", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 76, "Gastos de Mano de Obra", "GTOMO", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 77, "Impuesto IVA en Tarjetas", "IVATARJ", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 78, "Impuestos Municipales en Tarjetas", "MUNTARJ", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 79, "Cantidad de Unidades Vendidas", "CANVTAUN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 80, "Cantidad de Unidades Compradas", "CANCMPUN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 81, "Utilidad ó Pérdida en Compra de Usados", "UTILCMPUSA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 82, "Contrapartida en Toma de Inventario", "CIEINV", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 83, "Inventario en Proceso de Vehículo", "INVPVEH", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 84, "Inventario en Proceso en Importación de Repuestos", "INVPREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 85, "Reconstrucción de Costos", "RECOST", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 86, "Ajuste de Balance de Cancelación en Trade In", "AJUBALTI", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 87, "Cuentas Por Pagar Contado", "CXPCONTA", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 88, "IVA sin Credito Fiscal", "IVANOCRFIS", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 89, "Cheque Devuelto a Proveedor", "CHDEVPROV", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 90, "Control Leasing", "LEASECTRL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 91, "Perdida Venta Leasing", "LEASEPERDVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 92, "Perdida Inventario Leasing", "LEASEPERDINV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 93, "Inventario Leasing", "LEASEINV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 94, "Costo de Venta Leasing", "LEASECOSTVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 95, "Venta Leasing", "LEASEVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 96, "CXC Capital Leasing", "CXCCAPLEASE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 97, "CXC Intereses Leasing", "CXCINTLEASE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 98, "CXP Capital Leasing", "CXPCAPLEASE", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 99, "CXP Intereses Leasing", "CXPINTLEASE", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 100, "Consignación", "CXPCONSIGNA", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 97, 101, "Inventario de Vehículos en Consignacion", "INVVEHCONSI", 2, 0, 0);

                //  98  Base de Cálculo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 98, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 98, 1, "Dias Contínuos / Año de 365 días", "DIAS/365", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 98, 2, "Meses de 30 días y Año de 360 días", "30/360", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 98, 3, "Meses de 30 días y Año de 365 días", "30/365", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 98, 4, "Días contínuos y Año de 360 días", "DIAS/360", 0, 0, 0);

                //  100  Operacion de Traspaso en la Contabilidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 1, "Caja", "CAJA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 2, "Activo Fijo", "AF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 3, "Banco", "BANCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 4, "Departamento", "DPTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 5, "Diferencial Cambiario en Documentos", "DIFCAMB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 100, 6, "Diferencial Cambiario en Bancos", "DIFBAN", 0, 0, 0);

                //  101  Tamaño del papel de impresión
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 101, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 101, 1, "Carta 8.5' X 11.5'", "CAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 101, 2, "Media Carta 8.5' X 5.5'", "MCAR", 0, 0, 0);

                //  102  Tipo de Font para impresión
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 102, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 102, 1, "True Type", "TRUET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 102, 2, "Draft", "DRAFT", 0, 0, 0);

                //  103  Tipo de Consecutivo por Compañía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 1, "Corrida Contable", "CORR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 2, "Equivalente", "EQUIV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 3, "Comprobante de Reten. IVA", "COMPRORET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 4, "Comprobante de Reten. ISLR", "COMPROISLR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 5, "Comprobante de Reten. Municipal", "COMPROMUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 103, 6, "Consecutivo OC de Repuestos de Ford", "CONFORDOC", 0, 0, 0);

                //  104  Tipo de Cargo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 1, "Matriculación", "MATRI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 2, "Comisión Flat", "COMFLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 6, "Embalaje", "EMBAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 7, "Seguro", "SEGU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 8, "Flete", "FLETE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 12, "Agente Aduanal", "ADUA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 13, "Nacionalización", "NACIO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 14, "Transporte", "TRANS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 15, "Fondo de Capitalización", "FONCAP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 16, "Prepago", "PREPAGO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 104, 17, "Descuento Promoción", "DTOPROM", 0, 0, 0);

                //  105  Clase de Mano de Obra
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 1, "Nivel 1", "NIV1", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 2, "Nivel 2", "NIV2", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 3, "Nivel 3", "NIV3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 4, "Nivel 4", "NIV4", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 5, "Nivel 5", "NIV5", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 6, "Nivel 6", "NIV6", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 105, 7, "Nivel 7", "NIV7", 0, 0, 0);

                //  106  Tipo de detalle para reportes contables
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 1, "Cuenta Contable", "CTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 2, "Función", "FUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 3, "Titulo", "TITU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 4, "Suma Renglones", "SUMA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 106, 5, "Valor Fijo", "VAL", 0, 0, 0);

                //  107  Funciones para reportes contables
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 107, 0, "No Aplica", "N/A", 0, 0, 0);

                //  108  Categoria de Unidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 1, "AUTOMOVIL", "AUTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 2, "COMERCIAL", "COM", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 3, "PASAJEROS", "PAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 4, "PARTICULAR", "PART", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 5, "CARGA", "CAR", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 6, "TAXI", "TAXI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 7, "TRANSPORTE PRIVADO", "TRAPRIV", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 8, "URBANO", "URBAN", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 9, "PUBLICO", "PUBLIC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 10, "COLECTIVO PRIVADO", "COLPROV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 108, 11, "PRIVADO", "PRIVADO", 0, 0, 0);

                //  109  Tipo de Comisión
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 109, 0, "Sin Comisión", "0", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 109, 1, "Comisión +", "+", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 109, 2, "Comisión -", "-", 0, 0, 0);

                //  110  Tipo de Refinanciamiento en CXC
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 1, "Automatico", "AUTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 2, "Manual", "MANU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 3, "Giro Baloon", "BALOON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 4, "Giros Especiales", "GIRESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 5, "Giros Configurables", "GIRCONF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 6, "Giros Modificables", "GIRMOD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 7, "Giros Autom. Amortiza ", "GIRAMOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 8, "Giros Especiales Amortiza", "GIRESPAM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 9, "Giro Leasing Francés (C+I)", "GIROLEASING01", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 10, "Giro Leasing Francés", "GIROLEASING02", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 110, 11, "Giro Leasing Alemán", "GIROLEASING03", 0, 0, 0);

                //  111  Nivel de Satisfaccion Citas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 1, "Muy Insatisfecho", "MINSATIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 2, "Insatisfecho", "INSATIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 3, "Medianamente Satisfecho", "MEDSAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 4, "Satisfecho", "SATIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 111, 5, "Muy Satisfecho", "MSATIS", 0, 0, 0);

                //  112  Contacto Correctivo Citas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 112, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 112, 1, "Concesionario", "CONC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 112, 2, "Llamada Seguimiento", "LLAM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 112, 3, "Reclamo Escrito", "RECLA", 0, 0, 0);

                //  113  Problema Correctivo Citas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 113, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 113, 1, "Calidad", "CAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 113, 2, "Precio", "PRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 113, 3, "Trato con Cliente", "TRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 113, 4, "Otro", "OTRO", 0, 0, 0);

                //  114  Responsable Correctivo Citas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 114, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 114, 1, "Gerente de Servicio", "GTESER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 114, 2, "Gerente de Repuestos", "GTEREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 114, 3, "Gerente General", "GTEGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 114, 4, "Otro", "OTRO", 0, 0, 0);

                //  115  Grupo de Indicador de Cita
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 1, "Cita Previa", "CIPRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 2, "Proceso de Recepción", "PROREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 3, "Reserva de Recambio", "RESREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 4, "Entrega de la Unidad", "ENTUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 5, "Seguimiento", "SEG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 6, "Control de Taller", "CONTAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 115, 7, "Mostrador", "MOST", 0, 0, 0);

                //  116  Indicador de Cita
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 1, "1.- Entrada de Unidades", "ENTUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 2, "2.- Número de Citas", "NUMCIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 3, "2.1- Citas Realizadas", "CITREA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 4, "% Citas", "%CIT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 5, "% Citas Realizadas", "%CITREA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 11, "3.- Unidades Inspeccionados ", "UNIDINS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 12, "4.- Presupuestos Entregados", "PREENT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 13, "5.- Reparaciones Repetidas", "REPREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 14, "% Unidades Inspeccionados ", "%UNIDINS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 15, "% Presupuestos Entregados", "%PREENT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 16, "% Reparaciones Repetidas", "%REPREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 21, "6.- Itenes Requisitados", "ITEREQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 22, "7.- Itenes Disponibles en Stock", "ITEDIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 23, "8.- Reservas", "RESER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 24, "% Fill Rate Taller Mecánico", "%FIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 25, "% Reservas ", "%RESER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 31, "9.- OR y Unidad Revisados a Tiempo", "ORDUNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 32, "10.- Explicación del Trabajo", "EXPTRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 33, "% Cumplimiento Hora de Entrega", "%CUMHO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 34, "% Explicación del Trabajo", "%EXPTRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 41, "11.- Clientes a Contactar", "CLIACON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 42, "12.- Clientes Contactados", "CLICON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 43, "13.- Clientes Completamente Satisfechos", "CLISAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 44, "% Clientes Contactados ", "%CLICON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 45, "% Clientes Satisfechos", "%CLISAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 51, "14.- Horas Presencia", "HORPRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 52, "15.- Horas Trabajadas (int., ext., gar.)", "HORTRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 53, "16.- Horas Facturadas OR Cerradas (int., ext., gar", "HORFAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 54, "17.- Horas Facturadas OR Cerradas (ext., gar.)", "HORFEG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 55, "18.- Facturación  Rptos. OR Cerradas (ext., gar.) ", "FACREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 56, "19.- Numero de OR  (Unidades) Cerradas (ext., gar", "NUMORC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 57, "% Ocupación  ", "%OCUP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 58, "% Eficiencia", "%EFIC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 59, "% Productividad", "%PROD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 60, "Horas Facturadas / OR", "HOR/OR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 116, 61, "Repuestos Facturados / OR", "REP/OR", 0, 0, 0);

                //  117  Dias de la Semana
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 1, "Domingo", "DOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 2, "Lunes", "LUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 3, "Martes", "MAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 4, "Miercoles", "MIE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 5, "Jueves", "JUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 6, "Viernes", "VIE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 117, 7, "Sabado", "SAB", 0, 0, 0);

                //  118  Tipo de Relacion en Movimientos Bancarios
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 1, "Reverso", "REV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 2, "Impuesto al Debito Bancario", "IDB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 3, "Comision por Depósito de Tarjeta", "COMTARJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 4, "Impuesto por Depósito de Tarjeta", "IMPTARJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 5, "Impuesto IVA por Tarjeta", "IVATARJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 118, 6, "Impuestos Municipales por Tarjeta", "MUNTARJ", 0, 0, 0);

                //  119  Tipo de Observacion en Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 119, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 119, 1, "Notas Accesorios", "ACC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 119, 2, "Notas Factura", "FACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 119, 3, "Revisión Motor", "REVMOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 119, 4, "Revisión Inferior", "REVINF", 0, 0, 0);

                //  120  Tipo de Contabilizacion en Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 1, "Venta de Repuesto desde Servicio", "VREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 2, "Venta de Mano de Obra desde Servicio", "VMO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 3, "Venta de TOT desde Servicio", "VTOT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 4, "Venta de Repuesto de Garantia desde Servicio", "VGREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 5, "Venta de Mano de Obra de Garantia desde Servicio", "VGMO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 6, "Venta de TOT de Garantia desde Servicio", "VGTOT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 7, "Costo de Mano de Obra en Servicio", "CTOMO", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 8, "Venta de Cargos de Garantia desde Servicio", "VGCAR", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 9, "Costo de Venta de Repuesto desde Servicio", "CVREP", 5, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 120, 10, "Costo de Venta de Repuesto de Garantia", "CVREPG", 5, 0, 0);

                //  121  Parametros de la Contabilidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 121, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 121, 1, "TOT Afectan el Inventario de los Unidades", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 121, 2, "Los Cargos Afectan el Inventario de los Unidades", "CARGOS", 0, 0, 0);

                //  122  Reclamos de Garantia en O/S
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 0, "Sin Procesar", "SINPROC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 1, "Satisfecho Totalmente", "SATOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 2, "Satisf. Parcial Con Opción", "SATPAROP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 3, "Satisf. Parcial Sin Opción", "SATPARSO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 4, "Rechazado Definitivamente", "RECDEF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 5, "Rechazado Con Opción", "RECOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 6, "Ultimo Reconocimiento Parcial", "ULTPAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 122, 7, "Por Autorizar", "PORAUT", 0, 0, 0);

                //  123  Estatus de Conciliación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 123, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 123, 1, "Conciliado", "CONCIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 123, 2, "En Tránsito", "TRANS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 123, 3, "No Contabilizado", "NOCONT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 123, 4, "Reversado", "REV", 0, 0, 0);

                //  124  Tipo de Venta Perdida
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 124, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 124, 1, "Precio", "PREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 124, 2, "Existencia", "EXIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 124, 3, "Otro", "OTRO", 0, 0, 0);

                //  125  Tipo de Cambio en la Venta
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 125, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 125, 1, "Venta de Repuestos", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 125, 2, "Venta de Unidades", "UNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 125, 3, "Precios de Repuestos", "PRECIOREP", 0, 0, 0);

                //  126  Estatus del detalle de la Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 126, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 126, 1, "Factura de Cotejo de Garantía", "COT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 126, 2, "Factura Multiple O/S", "MULTO/S", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 126, 3, "Aprobado Star", "APRSTAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 126, 4, "Rechazado Star", "RECHSTAR", 0, 0, 0);

                //  127  Tipo de Hora para Técnicos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 1, "En Espera", "ESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 2, "Finalizado", "FIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 3, "Iniciado", "INI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 4, "No Iniciado", "NOINI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 5, "Sin Asignar", "SIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 11, "Anterior En Espera", "ANTESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 13, "Anterior Iniciado", "ANTINI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 14, "Anterior No Iniciado", "ANTNOINI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 21, "Inventario", "INVEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 127, 22, "Facturado", "FACT", 0, 0, 0);

                //  128  Grupo de Parametros
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 128, 0, "No Aplica", "N/A", 0, 0, 0);

                //  129  Tipo de Oferta en precios
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 129, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 129, 1, "Monto Global", "MTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 129, 2, "Porcentaje Global", "PORC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 129, 3, "Oferta en Detalle", "DET", 0, 0, 0);

                //  130  Tipo de Oferta en fecha
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 130, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 130, 1, "Sin fechas", "SF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 130, 2, "Fecha de Inicio", "FINI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 130, 3, "Fechas de Inico y Fin", "FIF", 0, 0, 0);

                //  132  Tipo de Pedido Sugerido
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 132, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 132, 2, "Volkswagen", "VOLK", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 132, 9, "Toyota", "TOYO", 0, 0, 0);

                //  133  Tipo de Anulación en Compra/Venta de Repuestos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 133, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 133, 1, "No se puede Anular", "NO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 133, 2, "En el mismo Día", "DIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 133, 3, "En el mismo Mes", "MES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 133, 4, "Siempre se puede Anular", "SI", 0, 0, 0);

                //  134  Estatus de Reclamo de Garantía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 134, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 134, 1, "Aprobado", "APRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 134, 2, "Rechazado", "RECH", 0, 0, 0);

                //  135  Tipo de Costos para Importación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 1, "Repuestos FOB", "REPFOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 2, "Seguro", "SEGURO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 3, "Transporte", "TRANSP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 4, "Almacenamiento", "ALMA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 5, "Aranceles de Importación", "ARAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 6, "Gastos Aduanales", "GASTAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 7, "Otros Gastos", "OTROG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 135, 8, "Unidades FOB", "UNIDFOB", 0, 0, 0);

                //  136  Tipo de Presupuesto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 136, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 136, 1, "Ventas", "VTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 136, 2, "Compras", "COMP", 0, 0, 0);

                //  137  Estado de la Unidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 137, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 137, 1, "Paralizada", "PARAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 137, 2, "Funcionando", "FUNC", 0, 0, 0);

                //  138  Estatus de Importación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 138, 0, "No Aplica", "N/A", 0, 0, 0);

                //  139  Tipo de Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 139, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 139, 1, "Mecánica", "MEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 139, 2, "Latonería", "LAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 139, 3, "Servicio Express", "SEX", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 139, 4, "Accesorios Venta", "ACCE", 0, 0, 0);

                //  140  Tipo de Expediente
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 140, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 140, 1, "Unidades", "UNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 140, 2, "Repuestos", "REP", 0, 0, 0);

                //  141  Tipo de Precio para Garantía con Fuente
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 141, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 141, 1, "FOB PVP", "PVP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 141, 2, "FOB Precio", "PRECIO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 141, 3, "FOB Emergencia", "EMER", 0, 0, 0);

                //  142  Tipo de Dato por Persona
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 142, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 142, 1, "Naturaleza de la Falla", "NAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 142, 2, "Diagnóstico de la Falla", "DIAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 142, 3, "Reparación de la Falla", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 142, 4, "Sección de la Unidad", "SECC", 0, 0, 0);

                //  143  Tipo de Importación de datos de Garantías
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 143, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 143, 1, "SEGA", "SEGA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 143, 2, "Manual", "MAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 143, 3, "Infoauto TXT", "INFTXT", 0, 0, 0);

                //  144  Tipo de Status Logístico
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 1, "Tránsito", "TR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 2, "Arrived", "AR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 3, "Proceso In Bond", "PIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 4, "In Bond", "IN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 5, "Proceso de Nacionalización", "PN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 6, "Nacionalizado", "NA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 7, "Orden de Traslado", "OT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 8, "Trasladado", "TA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 144, 9, "Desincorporado", "DS", 0, 0, 0);

                //  145  Tipo de Status Comercial
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 1, "Consignación", "CO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 2, "Demo", "DE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 3, "Desincorporado", "DS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 4, "Devolución", "DV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 5, "Abonado", "AB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 6, "Reservado", "RE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 7, "Usado", "US", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 8, "Vendido a Concesionario", "VCON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 145, 9, "Vendido a Cliente", "VCLI", 0, 0, 0);

                //  146  Tipo de Traslado
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 1, "Concesionario", "CON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 2, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 3, "Demostración", "DEMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 4, "Evento", "EVEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 5, "Depósito", "DEPO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 6, "Taller", "TAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 146, 7, "TOT", "TOT", 0, 0, 0);

                //  147  Tipo de Certificado para Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 147, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 147, 1, "Constancia de Nro de Identificación", "CNID", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 147, 2, "Certificado de Emisiones", "CEREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 147, 3, "Sencamer", "SEN", 0, 0, 0);

                //  148  Modalidad de Cálculo para PVP unico
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 148, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 148, 1, "Costo FOB más Bajo", "FOBBAJO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 148, 2, "Costo FOB más Alto", "FOBALTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 148, 3, "Costo FOB Último", "FOBULT", 0, 0, 0);

                //  149  Modalidad en Reconocimiento de Garantía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 149, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 149, 1, "Nota de Crédito en CXP", "NCCXP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 149, 2, "Nota de Crédito Bancaria", "NCBAN", 0, 0, 0);

                //  150  Tipo de Relación Persona/Tabg
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 150, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 150, 1, "Precio de Mano de Obra a Concesionario", "PREMO", 0, 0, 0);

                //  151  Tipo de Paquete
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 1, "Revisión", "REVIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 2, "Campaña", "CAMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 3, "Lubricación", "LUBRIC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 4, "Reparación", "REPAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 5, "Pintura", "PINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 6, "Seguridad", "SEGUR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 7, "Accesorios", "ACCES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 151, 8, "Servicio Rápido", "SRVRAP", 0, 0, 0);

                //  152  Tipo de Análisis de Repuestos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 106, "Monto Individual %", "MTOIND%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 107, "Cantidad Individual %", "CANIND%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 108, "Utilidad Individual %", "UTIIND%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 109, "Meses con Venta", "MESVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 110, "Monto Acumulado %", "MTOACU%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 112, "Cantidad Individual Rango", "CANINDRG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 113, "Costo Individual Rango", "COSINDRG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 114, "Cantidad Acumulado %", "CANACU%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 115, "Utilidad Acumulado %", "UTIACU%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 116, "Monto Individual Rango", "MTOINDRG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 117, "Utilidad Individual Rango", "UTIINDRG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 152, 118, "Utilidad Individual Rango %", "UTIINDRG%", 0, 0, 0);

                //  153  Tipo de Consecutivo por Base de Datos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 153, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 153, 1, "Control de Visitas", "CTLVIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 153, 2, "Control de Lotes de Repuestos", "LOTEREP", 0, 0, 0);

                //  154  Tipo de Pago de Cadivi
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 154, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 154, 1, "Aladi", "ALADI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 154, 2, "Crédito Directo", "CREDIR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 154, 3, "Pago Anticipado", "PAGANTI", 0, 0, 0);

                //  155  Estatus de Expediente Cadivi
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 1, "En Proceso de AAD", "PROCAAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 2, "AAD", "AAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 3, "En Proceso de Nacionalización", "PROCNAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 4, "Nacionalizado", "NAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 5, "En Proceso de Cierre", "PROCCIE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 155, 6, "Cerrado", "CERRADO", 0, 0, 0);

                //  156  Tipo de Resumen de Sugerido
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 156, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 156, 1, "Código Costo Planta menor", "CODPLANMENOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 156, 2, "Código Unif. Costo Planta menor", "CODUNIFPLANMENOR", 0, 0, 0);

                //  157  Tipo de Programa para Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 1, "Vehículo Familiar", "VEHFAM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 2, "Transporte Público", "TRANSPUB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 3, "Vehículo Utilitario", "VEHUTIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 4, "Venezuela Móvil", "VENMOV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 157, 5, "Venezuela en Movimiento", "VENMOVIM", 0, 0, 0);

                //  158  Operación Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 1, "Abono CxC", "ABOCXC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 2, "Abono CxP", "ABOCXP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 3, "Retencion", "RETEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 4, "Descuento", "DCTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 5, "Inventario", "INVEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 6, "Costo de Venta", "COSTVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 7, "Venta", "VENTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 8, "Ingreso", "INGRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 9, "Egreso", "EGRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 10, "Impuesto", "IMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 11, "Anticipo", "ANTI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 12, "Mora", "MORA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 13, "Refinanciamiento", "REFI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 14, "Incobrable", "INCOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 15, "Traspasos", "TRASP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 16, "Retiro de Caja", "RETI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 17, "Prestamo", "PREST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 18, "Comision", "COMIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 19, "Depreciacion AF", "DEPAF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 20, "Cheque Devuelto", "CHDEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 21, "Garantia Reconocida", "GARREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 22, "Debito Bancario", "DEBBCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 23, "Compra", "COMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 24, "Reclamo de Devolucion", "RECLADEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 25, "Pasivo Contingente NE", "PASCONE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 26, "Inventario de Repuestos en Proceso", "INVPRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 27, "Pasivo Contingente en Reclamo Devolucion", "PASCORD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 28, "Ajustes", "AJUS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 29, "Gastos Internos", "GASTIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 30, "Cortesias", "CORTE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 31, "Inventario de TOT en Proceso", "INVTOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 32, "Gastos de Preentrega", "GASTPRE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 33, "Gastos en Vehiculos de la Cia", "GTOVEHCIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 34, "Cargos en O/S", "CAROS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 35, "Reclamos de Mano de Obra", "RECMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 36, "CxC Temporal de Garantia", "CXCGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 37, "Inventario de Opciones de Planta", "INVOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 38, "Costo de Venta de Opciones de Planta", "CTOVTAOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 39, "Venta de Opciones de Planta", "VTAOP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 40, "Documentos Administrativos", "DOCADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 41, "Ajustes de Diferencial Cambiario", "AJUDIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 158, 42, "Pagaré Bancario", "PAGAREBAN", 0, 0, 0);

                //  159  Auxiliar Contable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 1, "Persona", "PERS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 2, "Activo Fijo", "AF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 3, "Vehiculo", "VEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 4, "Banco", "BANCO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 5, "Concepto", "CPTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 6, "Impuesto", "IMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 8, "TOT", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 10, "Cargo", "CARGO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 159, 11, "Retencion", "RETEN", 0, 0, 0);

                //  160  Origen Contable Detallado
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 1, "Repuesto", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 2, "Vehiculo", "VEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 3, "Servicio", "SER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 4, "Activo Fijo", "AF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 5, "Garantias", "GTIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 6, "Administracion", "ADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 7, "TOT", "TOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 8, "Generales", "GEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 9, "Orden de Servicio", "OS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 11, "Deposito", "DEPO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 12, "Cierre de Inventario ", "CIEINV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 13, "Nota de Entrada de Repuesto", "NEREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 14, "Nota de Salida de Repuesto", "NSREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 15, "Nota de Entrada de Vehiculo", "NEVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 16, "Nota de Salida de Vehiculo", "NSVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 17, "Cierre de O/S", "CIEOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 18, "Reclamo de Garantia", "RECGAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 19, "Recibos de Ingresos", "RECING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 20, "Egresos en Efectivo", "EGREFEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 21, "Cruce de Documentos", "CRUDOC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 22, "Incobrables", "INCOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 23, "Egresos Bancarios", "EGREBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 24, "Cheque Cobranza", "CHQCOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 25, "Refinanciamiento", "REFIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 26, "Traspasos", "TRASP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 27, "Retenciones", "RETEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 28, "Retiros de Caja", "RETCAJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 29, "Reintegros", "REINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 30, "Transferencias Bancarias", "TRFBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 31, "Reclamo de Devolucion", "RECLADEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 32, "Garantias Reconocidas", "GARREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 33, "Diferencial Cambiario en Doc", "DIFDOC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 34, "Diferencial Cambiario en Banco", "DIFBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 35, "Ingresos Banco", "INGBAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 160, 36, "Egresos con cheque de Cobranza", "ECHCOB", 0, 0, 0);

                //  161  Tipo de Consecutivo para Documentos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 161, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 161, 1, "Por Compañía", "CIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 161, 2, "Por Sucursal", "SUC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 161, 3, "Por Departamento", "DPTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 161, 4, "Por Grupo", "GRUP", 0, 0, 0);

                //  162  Tipo de Documentos para Consecutivos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 1, "Factura", "FAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 2, "Nota de Débito", "ND", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 3, "Nota de Crédito", "NC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 9, "Devolución de Mercancía", "DEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 14, "Nota de Entrega", "NE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 29, "Giro", "GIR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 30, "Nota de Débito por Mora", "NDMORA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 162, 58, "Factura de Cotejo de Garantía", "FACTGAR", 0, 0, 0);

                //  163  Tipo de Producto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 163, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 163, 1, "Lubricantes", "LUBRI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 163, 2, "Filtros", "FILTRO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 163, 3, "Correas", "CORREA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 163, 4, "Mangueras", "MANGUE", 0, 0, 0);

                //  164  Tipo de Impuesto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 164, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 164, 1, "Al Valor Agregado", "IVA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 164, 3, "Sobre la Renta", "ISLR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 164, 4, "Municipal", "MUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 164, 5, "Despacho (Surtax)", "SURTAX", 0, 0, 0);

                //  165  Colores para Unidades en Tablero
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 0, "No Aplica", "N/A", -1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 1, "1", "1", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 2, "2", "2", 4194304, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 3, "3", "3", 8388608, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 4, "4", "4", 12582912, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 5, "5", "5", 16711680, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 6, "6", "6", 16384, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 7, "7", "7", 4210688, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 8, "8", "8", 8404992, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 9, "9", "9", 12599296, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 10, "10", "10", 16728064, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 11, "11", "11", 32768, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 12, "12", "12", 4227072, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 13, "13", "13", 8421376, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 14, "14", "14", 12615680, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 15, "15", "15", 16744448, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 16, "16", "16", 49152, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 17, "17", "17", 4243456, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 18, "18", "18", 8437760, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 19, "19", "19", 12632064, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 20, "20", "20", 16760832, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 21, "21", "21", 65280, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 22, "22", "22", 4259584, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 23, "23", "23", 8453888, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 24, "24", "24", 12648192, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 25, "25", "25", 16776960, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 26, "26", "26", 64, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 27, "27", "27", 4194368, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 28, "28", "28", 8388672, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 29, "29", "29", 12582976, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 30, "30", "30", 16711744, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 31, "31", "31", 16448, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 32, "32", "32", 4210752, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 33, "33", "33", 8405056, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 34, "34", "34", 12599360, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 35, "35", "35", 16728128, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 36, "36", "36", 32832, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 37, "37", "37", 4227136, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 38, "38", "38", 8421440, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 39, "39", "39", 12615744, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 40, "40", "40", 16744512, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 41, "41", "41", 49216, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 42, "42", "42", 4243520, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 43, "43", "43", 8437824, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 44, "44", "44", 12632128, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 45, "45", "45", 16760896, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 46, "46", "46", 65344, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 47, "47", "47", 4259648, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 48, "48", "48", 8453952, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 49, "49", "49", 12648256, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 50, "50", "50", 16777024, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 51, "51", "51", 128, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 52, "52", "52", 4194432, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 53, "53", "53", 8388736, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 54, "54", "54", 12583040, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 55, "55", "55", 16711808, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 56, "56", "56", 16512, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 57, "57", "57", 4210816, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 58, "58", "58", 8405120, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 59, "59", "59", 12599424, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 60, "60", "60", 16728192, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 61, "61", "61", 32896, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 62, "62", "62", 4227200, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 63, "63", "63", 8421504, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 64, "64", "64", 12615808, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 65, "65", "65", 16744576, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 66, "66", "66", 49280, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 67, "67", "67", 4243584, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 68, "68", "68", 8437888, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 69, "69", "69", 12632192, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 70, "70", "70", 16760960, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 71, "71", "71", 65408, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 72, "72", "72", 4259712, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 73, "73", "73", 8454016, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 74, "74", "74", 12648320, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 75, "75", "75", 16777088, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 76, "76", "76", 192, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 77, "77", "77", 4194496, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 78, "78", "78", 8388800, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 79, "79", "79", 12583104, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 80, "80", "80", 16711872, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 81, "81", "81", 16576, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 82, "82", "82", 4210880, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 83, "83", "83", 8405184, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 84, "84", "84", 12599488, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 85, "85", "85", 16728256, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 86, "86", "86", 32960, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 87, "87", "87", 4227264, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 88, "88", "88", 8421568, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 89, "89", "89", 12615872, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 90, "90", "90", 16744640, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 91, "91", "91", 49344, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 92, "92", "92", 4243648, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 93, "93", "93", 8437952, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 94, "94", "94", 12632256, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 95, "95", "95", 16761024, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 96, "96", "96", 65472, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 97, "97", "97", 4259776, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 98, "98", "98", 8454080, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 99, "99", "99", 12648384, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 100, "100", "100", 16777152, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 101, "101", "101", 255, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 102, "102", "102", 4194559, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 103, "103", "103", 8388863, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 104, "104", "104", 12583167, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 105, "105", "105", 16711935, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 106, "106", "106", 16639, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 107, "107", "107", 4210943, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 108, "108", "108", 8405247, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 109, "109", "109", 12599551, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 110, "110", "110", 16728319, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 111, "111", "111", 33023, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 112, "112", "112", 4227327, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 113, "113", "113", 8421631, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 114, "114", "114", 12615935, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 115, "115", "115", 16744703, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 116, "116", "116", 49407, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 117, "117", "117", 4243711, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 118, "118", "118", 8438015, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 119, "119", "119", 12632319, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 120, "120", "120", 16761087, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 121, "121", "121", 65535, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 122, "122", "122", 4259839, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 123, "123", "123", 8454143, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 124, "124", "124", 12648447, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 165, 125, "125", "125", 16777215, 0, 0);

                //  166  Tipo de Compañía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 1, "Concesionario", "CONCES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 2, "Distribuidora", "DISTRI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 3, "Repuestero", "REPUES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 4, "Taller", "TALLER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 166, 5, "Administración", "ADMINI", 0, 0, 0);

                //  167  Tipo de Toma de Inventario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 1, "Prod. con Exist, Ubic. ó Movim. en Depósito", "TOTAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 2, "Seleccionados", "SELEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 3, "Prod. con más Movim.", "PRO+", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 4, "Productos Aleatorios", "ALEAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 5, "Prod. con más Movim. y con Exist.", "PRO+E", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 6, "Prod. con Exist. en el Depósito", "DEPOEXIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 7, "Prod. con Exist. o Ubicación en el Depósito", "EXISTUBI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 167, 8, "Prod. con Exist. o Movimiento en el Depósito", "EXISTMOV", 0, 0, 0);

                //  168  Tamaño del Daño
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 168, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 168, 1, "Pequeno", "PEQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 168, 2, "Mediano", "MED", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 168, 3, "Grande", "GRA", 0, 0, 0);

                //  169  Responsable del Daño
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 1, "Planta", "PLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 2, "Transportista", "TRAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 3, "Almacenadora", "ALMA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 4, "Seguro", "SEGU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 169, 5, "Interno", "INTE", 0, 0, 0);

                //  170  Tipo de Urgencia para Casos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 170, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 170, 1, "Baja", "BAJA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 170, 2, "Media", "MEDIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 170, 3, "Alta", "ALTA", 0, 0, 0);

                //  171  Tipo de Aplicación para Casos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 171, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 171, 1, "Infoauto Concesionario", "CONCE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 171, 2, "Infoauto Móvil", "MOV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 171, 3, "Infoauto Conces. Remoto", "CONREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 171, 4, "Infoauto Repuestos", "REP", 0, 0, 0);

                //  172  Tipo de Caso
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 172, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 172, 1, "Pregunta", "PREG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 172, 2, "Requerimiento", "REQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 172, 3, "Error", "ERR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 172, 4, "Sugerencia", "SUGER", 0, 0, 0);

                //  173  Estatus de Cliente para Casos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 173, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 173, 1, "Leido", "LEI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 173, 2, "Esperando Respuesta", "ESP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 173, 3, "Probando", "PROB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 173, 4, "Cerrado", "CERR", 0, 0, 0);

                //  174  Estatus de Consultor para Casos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 1, "Leido", "LEI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 2, "Esperando por Cliente", "ESPCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 3, "Esperando por Analista", "ESPANAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 4, "Probando", "PROB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 174, 5, "Cerrado", "CERR", 0, 0, 0);

                //  175  Estatus de Analista para Casos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 2, "Pendiente", "PEND", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 3, "Probando", "PROB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 4, "Desarrollando", "DES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 5, "Esperando Aprobación", "ESPAPROB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 6, "Esperando Cliente", "ESPCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 7, "Esperando Consultor", "O/C", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 8, "Esperando Programador", "ESPPROG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 9, "Por Asignar", "XASIGN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 10, "Esperando Información solic.", "ESPINFO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 11, "Esperando Analista", "ESPANAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 21, "Cerrado sin Solucionar", "CERRSINSOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 175, 22, "Cerrado Resuelto", "CERRRESUE", 0, 0, 0);

                //  176  Tipo de Suspensión de Soporte
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 176, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 176, 1, "Pago Pendiente", "PAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 176, 2, "Otros", "OTR", 0, 0, 0);

                //  177  Tipo de Usuario de Help desk
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 177, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 177, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 177, 2, "Consultor", "CON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 177, 3, "Programador", "PROG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 177, 4, "Analista", "ANAL", 0, 0, 0);

                //  178  Tipo de Aplicación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 1, "Infoauto Concesionario", "INFOCON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 2, "Infoauto Remoto", "INFOREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 3, "Infoauto Móvil", "INFOMOV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 4, "Infoauto Repuestos", "INFOREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 178, 5, "Infoauto Taller", "INFOTAL", 0, 0, 0);

                //  179  Estatus de Revisión de Unidad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 179, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 179, 1, "Pendiente por Accesorio", "PACC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 179, 2, "Pendiente por Daño", "PDAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 179, 3, "Cerrado", "CER", 0, 0, 0);

                //  180  Cálculo de Días Excentos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 180, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 180, 1, "Fecha de Emisión", "EMIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 180, 2, "Fecha de Recepción", "RECEP", 0, 0, 0);

                //  181  Tipo de Reporte a Imprimir
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 181, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 181, 1, "Tipo de Documento", "DOC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 181, 2, "Tipo de Recibo", "REC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 181, 3, "Tipo de Reporte", "REP", 0, 0, 0);

                //  182  Tipo de Ajuste en Precio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 0, "Sin Redondeo", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 1, "Decimales Arriba", "UPDEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 2, "Decimales Abajo", "DODEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 3, "Redondear Decimales", "REDEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 4, "Unidades Arriba", "UPUNI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 5, "Unidades Abajo", "DOUNI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 182, 6, "Redondear Unidades", "REUNI", 0, 0, 0);

                //  183  Tipo de Campaña
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 183, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 183, 1, "Normal", "NORM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 183, 2, "Sustitución", "SUST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 183, 3, "Promoción", "PROM", 0, 0, 0);

                //  184  Estado de la Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 1, "Por Asignar Técnico", "XASIGTEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 2, "Proceso de Diagnóstico", "PROCDIAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 3, "Elaborando Presupuesto", "ELABPRES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 4, "Pendiente por Autorización", "PENXAUT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 5, "Pendiente por Repuesto", "PENXREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 6, "Pendiente por TOT", "PENXTOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 7, "En Reparación", "ENREPAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 8, "En Control de Calidad", "CTLCALI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 9, "En Lavado", "LAVADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 10, "Prefacturada", "PREFACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 11, "Facturada", "FACTURA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 12, "Cerrada", "CERRADA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 13, "Reclamo Generado", "RECLAMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 14, "Lista Por Cerrar", "PORCERR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 15, "Esper. Autor. de Planta", "AUTPLAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 184, 16, "Esper. Autor. de Seguro", "AUTSEGU", 0, 0, 0);

                //  185  Tipo de Mensaje de Texto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 1, "Aviso", "AVIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 2, "Campaña", "CAMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 3, "Promoción", "PROM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 4, "Agradecimiento", "AGRA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 5, "Cumpleaños", "CUMP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 185, 6, "Recordatorio", "RECO", 1, 0, 0);

                //  186  Tipo de Reporte Configurable
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 1, "Saldo del Mes", "SALDOMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 2, "Acumulado del Mes", "ACUMMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 3, "Saldo Mes Actual y Acumulado", "SALDACUMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 4, "Saldo Mes Actual y Mes de Año Anterior", "SALDMESANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 5, "Acumulado Mes Actual y Mes de Año Anterior", "ACUMMESANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 6, "Saldo Mes Actual con % y Acumulado con %", "SALDACUM%", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 7, "Acumulado Mes Anterior y Mes Actual con %", "ACUMANTACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 8, "Saldo Mes Anterior y Mes Actual con %", "SALDANTACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 9, "Acumulado Mes Anterior y Mes Actual", "ACUMANTAC0", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 10, "Saldo Mes Anterior y Mes Actual", "SALDANTAC0", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 11, "Saldo de los Meses (Neto)", "NETOMESES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 186, 12, "Saldo de los Meses (Acumulado)", "ACUMULADOMESES", 0, 0, 0);

                //  187  Tipo de Tasa de Interes
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 187, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 187, 1, "Variable", "TASAVAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 187, 2, "Fija", "TASAFIJO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 187, 3, "Fija/Variable", "TASAFIVAR", 0, 0, 0);

                //  188  Tipo de Estatus Star
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 1, "Pendiente", "PEND", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 2, "Aceptado", "ACEPT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 3, "Rechazado", "RECHA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 4, "Aceptado y Pagado", "ACEPTPAG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 5, "No Aceptado", "NOACEPT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 188, 6, "Pendiente por Factura", "PENDFISFAC", 0, 0, 0);

                //  189  Tipo de Transacción
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 1, "Factura a Terceros", "FACT3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 2, "Recepción de Vehículos Usados", "CMPUSA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 3, "Factura con Varios Vehículos", "FACTVARVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 4, "Recuperación de Leasing", "RECUPLEASE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 189, 5, "Consignación", "CONSIG", 0, 0, 0);

                //  190  Tipo de Exención de Impuesto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 190, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 190, 1, "Imponible", "IMPONIB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 190, 2, "Exonerado", "EXONERA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 190, 3, "Exento", "EXENTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 190, 4, "No Sujeto", "NOSUJE", 0, 0, 0);

                //  192  Tipo de Departamento de Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 192, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 192, 1, "Nuevos", "NUEVOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 192, 2, "Usados", "USADOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 192, 3, "Facturación a Terceros", "FACT3", 0, 0, 0);

                //  193  Clase de Orden de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 193, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 193, 1, "Factura con Renglon por Trabajo", "FACTRENXJOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 193, 2, "Factura con Renglon por Paquete", "FACTRENXPAQ", 0, 0, 0);

                //  194  Tipo de Actividad de Consultores
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 194, 0, "No Aplica", "N/A", 0, 0, 0);

                //  195  Tipo de Estatus de Mensajería
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 195, 0, "No Aplica", "N/A", 0, 0, 0);

                //  197  Consultores de Infoauto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 1, "Jose Turowiecki", "jturow", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 2, "Jose Rico", "jrico", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 3, "Maria Claret", "mclaret", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 4, "Luisa Estevez", "lestevez", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 5, "Julio Araguainamo", "jaragua", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 6, "Pedro Araguainamo", "paragua", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 7, "Karen Turowiecki", "karen", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 8, "Cesar Cabeza", "ccabeza", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 9, "Williams Mejias", "wmejias", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 10, "Jose Carlos", "josecarlos", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 11, "Carlos Mora", "cmora", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 12, "Carlos Garcia", "cgarcia", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 13, "Keith Inciarte", "keith", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 14, "Kenneth Inciarte", "kenneth", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 15, "Nilmary Morales", "nilmary", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 16, "Agnedy Turowiecki", "agnedy", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 17, "J. Miguel Chavez", "miguel", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 18, "Carla Graterol", "cgraterol", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 19, "Johana Flores", "jflores", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 20, "Erick Peña", "epeña", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 21, "Oswald Padron", "opadron", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 22, "Rafael Bastidas", "rbastidas", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 23, "Victor Dugarte", "vdugarte", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 24, "Agnnia Barroeta", "abarroeta", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 25, "Magdeline Rueda", "mrueda", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 26, "Gabriela Garban", "ggarban", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 27, "Juan Mendoza", "jmendoza", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 28, "Carlos Garrido", "cgarrido", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 29, "Victor Dávila", "vdavila", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 30, "Francis García", "fgarcia", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 31, "Ana Karina Bilbao", "abilbao", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 197, 32, "Juan Carlos Ceballos", "jceballos", 0, 0, 0);

                //  198  Modalidad para el inicio de la Depreciación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 198, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 198, 1, "En el mismo Mes", "MISMOMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 198, 2, "En el Mes siguiente", "MESSIG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 198, 3, "2da Quinc. en Mes siguiente", "2DAQUIN", 0, 0, 0);

                //  199  Tipo de Relación en Personas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 199, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 199, 1, "Representante Legal", "REPRE_LEG", 0, 0, 0);

                //  200  Tipo de Campo para Facturas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 200, 0, "No Aplica", "N/A", 0, 0, 0);

                //  201  Tipo de Campo para Marcas
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 201, 0, "No Aplica", "N/A", 0, 0, 0);

                //  202  Tipo de Uso en Unidades
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 202, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 202, 1, "Particular", "PART", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 202, 2, "Comercial", "COM", 0, 0, 0);

                //  203  Tipo de Contacto para Clientes
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 1, "Instalar Versiones de Infoauto", "INSTVER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 2, "Recibir Facturas de Infoauto", "RECFACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 3, "Chequear Depósitos y Retenciones a Infoauto", "DEPORET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 4, "Informar la Programación de Cursos de Infoauto", "PROGCUR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 5, "Gerente General", "GERGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 6, "Departamento de Repuestos", "DPTOREP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 7, "Departamento de Servicio", "DPTOSERV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 8, "Departamento de Vehículos", "DPTOVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 9, "Departamento de Administración", "DPTOADM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 10, "Gerente de Post Venta", "POSTVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 11, "Responsable de Sistemas", "RESPSIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 203, 12, "Solicitar Asesoría de Infoauto", "SOLASE", 0, 0, 0);

                //  204  Tipo de Código para Usuario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 204, 0, "No Aplica", "N/A", 0, 0, 0);

                //  205  Tipo de Rango para Comisiones de Repuestos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 205, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 205, 1, "Rango", "RANGO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 205, 2, "Rango por Línea", "RANXLIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 205, 3, "Rango Escalon", "RANGOESC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 205, 4, "Rango por Línea Escalon", "RANXLINESC", 0, 0, 0);

                //  206  Tipo de Impresora Fiscal
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 1, "ELEPOS VMAX200AE", "VMAX200AE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 2, "ELEPOS VMAX220AE", "VMAX220AE", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 3, "Epson PF-300 II PNP", "PF-300", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 4, "Bixolon SRP-350 ", "SRP-350", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 5, "Bixolon SRP-270", "SRP-270", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 206, 6, "PD3100DL", "PD3100DL", 3, 0, 0);

                //  207  Nivel de Satisfaccion Citas Mazda
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 1, "Pobre", "POB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 2, "Regular", "REG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 3, "Bueno", "BUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 4, "Muy Bueno", "MBUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 207, 5, "Excelente", "EXCE", 0, 0, 0);

                //  208  Tipo de HardKey
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 1, "Cliente", "CLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 2, "Consultor", "CONS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 3, "Proveedor", "PROV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 4, "Demostracion", "DEMO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 208, 5, "Especial", "ESP", 0, 0, 0);

                //  209  Tipo de Pregunta de Seguridad
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 1, "Ciudad natal materna", "CINAMA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 2, "Nombre de Mascota", "MASNOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 3, "Marca primer carro", "MARCAR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 4, "Primer colegio", "PRIMCOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 5, "Grupo musical favorito", "GRUMUS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 6, "Nombre de sobrino mayor", "NOMSOB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 7, "Ciudad favorita", "CIUDFAV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 8, "Calle favorita", "CALFAV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 209, 9, "Donde conoció a su pareja", "CONOPAR", 0, 0, 0);

                //  210  Origen de Lote de Inventario
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 210, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 210, 1, "Compra Rep.", "DOC_REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 210, 2, "Toma de Inventario", "TOMA", 0, 0, 0);

                //  211  Tipo de Licencia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 211, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 211, 1, "Start", "START", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 211, 2, "Advance", "ADV", 0, 0, 0);

                //  212  Tipo de Dealer
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 212, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 212, 1, "Master Dealer", "MASTDEA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 212, 2, "Distribuidor Gold", "DISTGOLD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 212, 3, "Distribuidor", "DISTRIB", 0, 0, 0);

                //  213  Tipo de Certificación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 1, "Implantador Master", "IMPLMAST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 2, "Implantador", "IMPLANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 3, "Soporte Nivel 1", "SOPORT01", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 4, "Soporte Nivel 2", "SOPORT02", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 213, 5, "Soporte Nivel 3", "SOPORT03", 0, 0, 0);

                //  214  Tipo de Módulo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 1, "Ventas Unidades Nuevas", "VTAVEHNEW", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 2, "Compras Unidades Nuevas", "COMPVEHNEW", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 3, "Inventario Unidades", "INVENVEH", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 4, "Ventas Unidades Usadas", "VTAVEHUSA", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 5, "Compras Unidades Usadas", "COMPVEHUSA", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 6, "Ventas Unidades Leasing", "VTAVEHLEAS", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 7, "Orden de Servicio Mecánica", "SEROSMEC", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 9, "Orden de Servicio Expreso", "SEROSSEX", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 10, "Planificación de Servicio", "PLANIFSER", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 11, "Citas", "CITAS", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 12, "Transferencias", "TRANSF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 13, "CRM Servicio", "CRMSERV", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 14, "CRM Repuestos", "CRMREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 15, "CRM Unidades", "CRMVEH", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 16, "CRM Administración", "CRMADM", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 17, "Seguridad, Eventos y Perfiles", "SEGUR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 18, "Actualización de Versiones", "ACTVER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 19, "Formatos de Impresión", "FORMIMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 20, "Cálculo de Precios de Repuestos", "PRECIOSREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 21, "Cálculo de Comisiones de Repuestos", "COMISREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 22, "Cálculo de Comisiones de Servicio", "COMISSERV", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 23, "Cálculo de Comisiones de Unidades", "COMISVEH", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 24, "TOT", "TOT", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 25, "Venta de Repuestos", "VTAREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 26, "Compra de Repuestos", "COMPREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 27, "Toma de Inventario de Repuestos", "TOMINVREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 28, "Pedido Sugerido Repuestos", "PEDSUGREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 29, "Analisis de Inventario de Repuestos", "ANALINVREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 30, "Importar Datos de Listas de Repuestos", "IMPLISTREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 31, "Importación de Compra de Repuestos", "IMPCOMPREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 32, "Importación de Compra de Unidades", "IMPCOMPVEH", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 33, "Impresora Fiscal Repuestos", "IMPFISREP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 34, "Impresora Fiscal Servicios", "IMPFISSER", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 35, "Impresora Fiscal Unidades", "IMPFISVEH", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 36, "Impresora Fiscal Administración", "IMPFISADM", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 37, "Impresora Fiscal General", "IMPFISGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 38, "Generación Contable", "GENCONT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 39, "Reportes Contables", "REPCONT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 40, "Configuración Contable", "CONFCONT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 41, "Presupuesto Contable", "PRESCONT", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 42, "Recibos de Caja", "CXCREC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 43, "Reportes de Ctas x Cobrar", "CXCREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 44, "Depósitos de Cobranza", "CXCDEPO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 45, "Arqueo de Caja", "CXCARQ", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 46, "Impuestos y Comisiones de Tarjetas", "CXCIMP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 47, "Cotejos de Garantía", "CXPCOTGAR", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 48, "Recibos de CxP", "CXPREC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 49, "Retenciones en Ctas x Pagar", "CXPRET", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 50, "Retenciones en Ctas x Cobrar", "CXCRET", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 51, "Libro de IVA", "CXPLIBIVA", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 52, "Caja Chica", "CXPCAJCHI", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 53, "Reportes de Impuestos sobre la Renta", "CXPREPISLR", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 54, "Reportes de Ctas x Pagar", "CXPREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 55, "Presupuesto de Conceptos", "CXPPRECPTO", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 56, "Configuración de Bancos", "BANCONFIG", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 57, "Movimientos Bancarios", "BANMOV", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 58, "Conciliaciones Bancarias", "BANCONCIL", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 59, "Reportes de Banco", "BANREP", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 60, "Configuración de Activos Fijos", "AFCONF", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 61, "Depreciaciones de Activos Fijos", "AFDEPREC", 4, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 62, "Ficha de Personas", "PERSFICHA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 63, "Direcciones", "PERSDIR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 64, "Parámetros", "PARAM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 65, "Respaldos", "RESPALDO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 66, "Envío de SMS", "MENSTXT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 67, "Envío de email", "EMAIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 68, "Migración", "MIGRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 69, "Histórico de Inventarios", "HIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 70, "Importación de Datos por Marca", "IMPDATMAR", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 71, "Plan Mayor", "PLANMAY", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 72, "Reportes de Compras de Repuestos", "REPREPCOMP", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 73, "Reportes de Ventas de Repuestos", "REPREPVTA", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 74, "Reportes de Compras de Unidades", "REPVEHCOMP", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 75, "Reportes de Ventas de Unidades", "REPVEHVTA", 3, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 76, "Reportes de Servicio", "REPSERVTA", 2, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 77, "Error en Servidor", "ERRSERV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 78, "Actualizar Licencia", "ACTLICEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 214, 79, "Postponer Vencimiento", "POSTVENC", 0, 0, 0);

                //  215  Tipo de Producto N1
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 1, "Repuesto", "REPUE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 2, "Accesorio", "ACCES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 3, "Lubricante", "LUBRI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 4, "Caucho", "CAUCHOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 5, "Batería", "BATER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 6, "Mercadería", "MERCAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 7, "Insumos", "INSUMOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 8, "Consumibles", "CONSUMIB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 215, 9, "Tintas", "TINTAS", 0, 0, 0);

                //  218  Modalidad Mano de Obra
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 218, 0, "No Aplica", "N/A", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 218, 1, "En el Taller", "TAL", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 218, 2, "Fuera del Taller", "FUE", 1, 0, 0);

                //  219  Tipo de llamada CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 0, "No Aplica", "N/A", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 1, "Ninguna Acción", "NINGUNA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 2, "Realizar Encuesta", "ENCUESTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 3, "Concertar Cita", "CONCCITA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 4, "Confirmar Cita", "CONFCITA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 5, "Campaña", "CAMPA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 6, "Informar", "INFORM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 8, "Prosp. Vehículos", "PROSPVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 9, "Contestadora Volver a LLamar", "CNTSILLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 10, "Contestadora (+3veces)/No Llamar", "CNTNOLLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 11, "Cliente Foraneo/No Llamar", "FORNOLLA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 12, "Contacto Invalido-Revisar/Eliminar", "CONTINVAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 13, "Seguimiento de PQR", "SEGPQR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 219, 14, "Llamada de Seguimiento 72 Horas", "LLASEG72H", 0, 0, 0);

                //  220  Estatus de Prospecto CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 220, 0, "No Aplica", "N/A", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 220, 1, "Inicial", "INICIAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 220, 2, "Pendiente Doc.", "PEND. DOC.", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 220, 3, "Esperando Respuesta", "ESP RESP.", 0, 0, 0);

                //  221  Origen de Prospecto CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 221, 0, "No Aplica", "N/A", 1, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 221, 1, "Lista", "LISTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 221, 2, "Web", "WEB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 221, 3, "Concesionario", "CONCE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 221, 4, "Show", "SHOW", 0, 0, 0);

                //  222  Tipo de Cargo para Vehículos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 0, "No Aplica", "N/A", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 1, "LOJACK", "LOJACK", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 2, "TIRES & WHEELS", "TIRES&WHEELS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 3, "PAINT PROTECTOR", "PAINTPROTECT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 4, "DOUBLE PRIMA", "DOBLPRIMA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 5, "GARANTIA EXTENDIDA", "GARANTIA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 6, "SEGURO DE VIDA", "SEGVIDA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 7, "GAP", "GAP", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 8, "SELLOS", "SELLOS", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 9, "REGISTRO/TRASPASO", "REGTRASP", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 10, "GRAVAMEN", "GRAVAMEN", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 11, "SINGLE PRIMA", "SINGPRIMA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 12, "DEALER INCENTIVE", "INC.PLANTA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 13, "TABLILLA", "TABLILLA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 14, "BACK BANCO", "BCK BANK", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 15, "FEES", "FEES", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 16, "DCTO/REBATE DE PLANTA", "DCTOPLANTA", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 17, "GASOLINA", "GAS", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 18, "CERTIFIED P.O.", "CPO", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 19, "SEGURO DE VEHICULO", "SEGVEH", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 20, "UPSIDEDOWN", "UPSDWN", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 222, 21, "POLIZA NO DEVENGADA", "POLNODEV", 0, 1, 0);

                //  223  Tipo de Origen para Kms
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 223, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 223, 1, "Orden de Servicio", "O/S", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 223, 2, "Cita de Servicio", "CITA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 223, 3, "Llamada de Prospección", "LLAMCRM", 0, 0, 0);

                //  224  Tipo de Combustible
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 1, "Gasolina", "GSOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 2, "Diesel", "DIES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 3, "Gas Natural", "GASNAT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 4, "Eléctrico", "ELECT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 5, "Híbrido Gasolina Gas Nat", "HGSOLGASN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 6, "Híbrido Diesel Gas Nat", "HDIESGASN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 7, "Híbrido Diesel Elect", "HDIESELEC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 224, 8, "Híbrido Gasolina Elect", "HGSOLELEC", 0, 0, 0);

                //  225  Tipo de Comision Veh
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 225, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 225, 1, "Pago a la Compañía", "PAGOCIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 225, 2, "Pago a la Persona", "PAGOPERS", 0, 0, 0);

                //  226  Tipo de Valor para Tabla Basica
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 226, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 226, 1, "Prospección Kms", "PROSKMS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 226, 2, "Prospección Meses", "PROSMES", 0, 0, 0);

                //  227  Tipo de Relación Persona/Vehiculo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 227, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 227, 1, "Dueño", "DUEÑO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 227, 2, "Conductor", "COND", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 227, 3, "Administrador", "ADMIN", 0, 0, 0);

                //  228  Tipo de Ausencia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 1, "Curso", "CUR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 2, "Vacaciones", "VAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 3, "Reposo", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 4, "Permiso NO Remunerado", "PNREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 228, 5, "Permiso SI Remunerado", "PSREM", 0, 0, 0);

                //  229  Tipo de Medida
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 1, "Horas", "HOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 2, "Dias", "DIAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 3, "Semanas", "SEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 4, "Bisemanal", "BISEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 5, "Meses", "MES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 229, 6, "Anual", "ANO", 0, 0, 0);

                //  230  Tipo de Concepto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 230, 0, "No Aplica", "N/A", 0, 0, 0);

                //  231  Tipo de Fórmula
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 231, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 231, 1, "Seguro Social Obligatorio", "SSO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 231, 2, "Ley de Politica Habitacional", "LPH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 231, 3, "Ince", "INCE", 0, 0, 0);

                //  232  Tipo de Frecuencia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 1, "Semanal", "SEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 2, "Bisemanal", "BIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 3, "Quincenal", "QUIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 4, "Mensual", "MEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 5, "Trimestral", "TRI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 6, "Semestral", "SEME", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 7, "Anual", "ANO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 232, 8, "Puntual", "PUNT", 0, 0, 0);

                //  233  Tipo de Relación Empleado/Persona
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 1, "Padre", "PAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 2, "Madre", "MAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 3, "Hermano", "HER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 4, "Abuelo", "ABU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 5, "Hijo", "HIJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 233, 6, "Conyuje", "CON", 0, 0, 0);

                //  234  Estatus de Empleado en la Cia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 1, "Activo", "ACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 2, "Vacaciones", "VAC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 3, "Reposo", "REP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 4, "Permiso NO Remunerado", "PNREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 5, "Permiso SI Remunerado", "PSREM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 6, "Retirado", "RET", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 234, 7, "Jubilado", "JUB", 0, 0, 0);

                //  235  Forma de Pago para Nómina en la Cia
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 235, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 235, 1, "Efectivo", "EFE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 235, 2, "Cheque", "CH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 235, 3, "Depósito Bancario", "DP", 0, 0, 0);

                //  236  Modo de Deducción para CXC en Nómina
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 236, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 236, 1, "Monto Fijo", "MTOFI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 236, 2, "Monto Total", "MTOTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 236, 3, "Porcentaje", "PORC", 0, 0, 0);

                //  237  Origen de Concepto en Nómina
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 237, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 237, 1, "Comisiones", "COMIS", 0, 0, 0);

                //  238  Tipo de Regla para CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 238, 0, "No Aplica", "N/A", 0, 0, 0);

                //  239  Tipo de Servicio para CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 239, 0, "No Aplica", "N/A", 0, 0, 0);

                //  240  Campo para Vehículo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 240, 0, "No Aplica", "N/A", 0, 0, 0);

                //  241  Campo para Persona
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 1, "Cédula", "cedula_rif", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 2, "Código Alterno", "cod_alterno", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 3, "Email 1", "email1", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 4, "Email 2", "email2", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 5, "Licencia", "num_licencia", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 6, "Seguro Social", "num_segsoc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 7, "Teléfono Movil", "telefmov", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 8, "Teléfono de Oficina", "telefofi", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 9, "Teléfono de Domicilio", "telefdom", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 10, "Dirección de Domicilio", "dirdom", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 11, "Dirección de Oficina", "dirofi", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 12, "Dirección Postal", "dirpost", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 13, "Profesión", "profesion_tab", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 14, "Cargo Laboral", "cargo_tab", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 15, "Sexo", "sexo_6", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 16, "Estado Civil", "edo_civil_7", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 17, "Fecha de Nacimiento", "fec_nac", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 241, 18, "RIF", "rif", 0, 0, 0);

                //  242  Tipo de Programa de Correo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 242, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 242, 1, "Outlook Express", "OUTEXP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 242, 2, "Microsoft Outlook ", "MICOUT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 242, 3, "Windows Mail", "WINMAIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 242, 4, "Infoauto Mail", "INFOMAIL", 0, 0, 0);

                //  243  Modalidad de Concepto de Nomina
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 243, 0, "No Aplica", "N/A", 0, 0, 0);

                //  244  Tipo de Movimiento en Puesto de Trabajo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 244, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 244, 1, "Asignar Puesto", "ASIGN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 244, 2, "Liberar Puesto", "LIBER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 244, 3, "Desactivar Puesto", "DESACT", 0, 0, 0);

                //  245  Tipo de Modalidad de Dcto en Doc de Nomina
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 1, "Sueldo", "SUEL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 2, "Utilidades", "UTIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 3, "Bonos", "BON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 4, "Comisiones", "COMIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 5, "Todo menos Sueldo", "TOMSUEL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 6, "Utilidades y Bonos", "UTIBON", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 7, "Utilidades y Comisiones", "UTICOM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 245, 8, "Bonos y Comisiones", "BONCOM", 0, 0, 0);

                //  246  Tipo de Relación Persona/Persona CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 1, "Administrador", "ADMIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 2, "Familiar", "FAMIL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 3, "Empleado", "EMPLE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 4, "Conyuge", "CONYU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 5, "Asistente", "ASIST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 246, 6, "Vendedor", "VEND", 0, 0, 0);

                //  247  Tipo de envío de Mensajes de Texto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 247, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 247, 1, "Infoauto Pocket PC", "INFO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 247, 2, "Dana Connect", "DANA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 247, 3, "MLAT Venezuela", "MLATVEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 247, 4, "MLAT International", "MLATINT", 0, 0, 0);

                //  248  Tipo en Nivel por Departamento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 248, 0, "No Aplica", "N/A", 0, 0, 0);

                //  249  Tipo en Nivel por Compañía
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 249, 0, "No Aplica", "N/A", 0, 0, 0);

                //  250  Condición para Incentivos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 250, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 250, 1, "2500 Util. Promedio", "2500", 0, 0, 0);

                //  251  Tipo de Documento para CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 1, "Felicitaciones por Cumpleaños", "CUMPLEA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 2, "Felicitaciones por Veh. Nuevo", "VEHNEW", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 3, "Recordatorio Servicio", "RECSERV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 4, "Oferta Vehículos", "OFERVEH", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 251, 5, "Oferta Servicios", "OFERSERV", 0, 0, 0);

                //  252  Estatus de Persona como Cliente
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 252, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 252, 1, "OK", "OK", 0, 0, 0);

                //  253  Estatus de Persona como Proveedor
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 253, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 253, 1, "OK", "OK", 0, 0, 0);

                //  254  Formato de Dirección
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 254, 0, "No Aplica", "N/A", 0, 0, 0);

                //  255  Tipo de Identificación
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 1, "Cédula Identidad", "CI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 2, "Pasaporte", "PAS", 0, 41, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 3, "Pasaporte Diplomático", "PD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 4, "Registro civil de nacimiento", "RC", 0, 11, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 5, "Tarjeta de identidad", "TI", 0, 12, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 6, "Cédula de ciudadanía", "CC", 0, 13, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 7, "Tarjeta de extranjería", "TE", 0, 21, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 8, "Cédula de extranjería", "CE", 0, 22, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 9, "Número de Ident. Fiscal", "NIT", 0, 31, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 10, "Tipo de documento extranjero", "TDE", 0, 42, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 11, "Sin identificacion del exterior", "SIE", 0, 43, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 12, "Federal Identification Number", "FIN", 0, 43, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 255, 13, "Registro Único de Contribuyente", "RUC", 0, 0, 0);

                //  256  Tipo de Contrato Dana
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 256, 0, "No Aplica", "N/A", 0, 0, 0);

                //  257  Tipo de Campo de Dirección
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 1, "Pais", "PAIS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 2, "Estado", "EST", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 3, "Municipio", "MUN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 4, "Ciudad", "CIU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 5, "Urbanización", "URB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 6, "Calle/Avenida", "CALL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 7, "Dirección", "DIREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 257, 8, "Código Postal", "ZIP", 0, 0, 0);

                //  258  Tipo de Referencia para Existencias por Ref.
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 258, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 258, 1, "Placa", "PLACA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 258, 2, "VIN", "VIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 258, 3, "Cédula/Rif", "CI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 258, 4, "Licencia", "LICEN", 0, 0, 0);

                //  260  Tipo de Código para Lector
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 1, "Código General", "CODGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 2, "Código Unificado", "CODUNIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 3, "Código de Barras", "CODBARRA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 4, "Código EAN", "CODEAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 260, 5, "Código Interno", "CODINTER", 0, 0, 0);

                //  261  Subtipo para Edo. Finan.
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 1, "Activo Corriente", "ACTCOR", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 2, "Activo No Corriente", "ACTNOCOR", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 3, "Pasivo Corriente", "PASCOR", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 4, "Pasivo de Largo Plazo", "PASLAR", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 5, "Patrimonio", "PATRIM", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 6, "Ingresos Operacionales", "INGOPER", 0, 4, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 7, "Ingresos No Operacionales", "INGNOOPER", 0, 4, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 8, "Costo de Venta", "COSVTA", 0, 5, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 9, "Gastos Operacionales", "GASOPER", 0, 5, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 261, 10, "Gastos No Operacionales", "GASNOOPER", 0, 5, 0);

                //  262  Tipo de Comunicación Dana
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 1, "Deuda por Vencer de clientes", "CXCPORVENC", 0, 4, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 2, "Deuda Vencida de clientes", "CXCVENCIDOS", 0, 4, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 3, "Solicitud de Retenciones", "SOLRETEN", 0, 4, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 4, "Estatus Pedido Repuestos", "STAPEDREP", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 5, "Agradecimiento de Compra Rep.", "AGRACOMPREP", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 6, "Promoción de Repuestos", "PROMOREP", 0, 1, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 7, "Campañas de Garantía", "CAMPGAR", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 8, "Promoción de Servicio", "PROMOSERV", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 9, "Estatus de la Orden de Servicio", "STAOS", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 10, "Recordatorio de Servicio", "RECORSERV", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 11, "Recordatorio de Cita", "RECORCITA", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 12, "Agradecimiento de Servicio", "AGRASERV", 0, 2, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 13, "Agradecimiento de Compra Veh.", "AGRACOMPVEH", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 14, "Estatus de Crédito de Veh.", "STACREDVEH", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 15, "Estatus de Documentación Faltante", "STADOCFALT", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 16, "Recordatorio de Vencimiento de Productos", "RECOVENCPROD", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 17, "Promoción de Vehículos", "PROMOVEH", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 18, "Felicitación por Aniversario de Vehículos", "FELIANIVVEH", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 19, "Envío de SMS", "ENVIOSMS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 20, "Documentos Todos", "DOCCXCTODO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 21, "Pagos a Proveedores con Cheques", "CXPCHQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 22, "Pagos a Proveedores con Transferencias", "CXPTRF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 23, "Felicitación de Cumpleaños", "FELIZCUMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 24, "Orden de Servicio Cerrada", "OSCERRADA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 262, 25, "Deuda de clientes", "CXCTOTAL", 0, 0, 0);

                //  266  Estatus de Documento de Rep.
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 266, 0, "No Aplica", "N/A", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 266, 1, "Orden de Compra a Proveedor", "OCPROV", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 266, 2, "Repuestos Recibidos", "REPRECIB", 0, 3, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 266, 3, "Comunicarse con Asesor", "COMUNDPTO", 0, 3, 0);

                //  267  Estatus de Cita por Técnico
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 267, 0, "No Aplica", "N/A", 0, 3, 0);

                //  269  Tipo de Operacion Log Dana
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 269, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 269, 1, "Upload Archivo", "UPLOAD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 269, 2, "Download Archivo", "DOWNLOAD", 0, 0, 0);

                //  270  Tipo de Fecha Contable para Recibos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 270, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 270, 1, "Hoy", "HOY", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 270, 2, "Documento más reciente", "DOCREC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 270, 3, "Documento Bancario", "INGREC", 0, 0, 0);

                //  271  Tipo de Distribución de Gastos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 1, "Valor", "VAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 2, "Peso", "PESO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 3, "Volumen", "VOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 4, "Arancel", "ARAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 5, "Cantidad", "CANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 271, 6, "Renglón", "RENG", 0, 0, 0);

                //  272  Tipo de Proceso en ASA
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 272, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 272, 1, "Detener MO Automatico", "DETMOAUTO", 0, 0, 0);

                //  273  Tipo de Relación Recibo/Vehiculo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 273, 0, "Manual", "MAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 273, 1, "Rebate de Planta", "REBATE", 0, 0, 0);

                //  274  Tipo de Grupo IVR
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 274, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 274, 1, "Red de Concesionarios Oficial", "REDCONCES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 274, 2, "Red Privada", "REDPRIVA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 274, 3, "Red de Repuesteros", "REDREPUESTO", 0, 0, 0);

                //  275  Medida de Peso
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 275, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 275, 1, "Kilogramos", "KGMS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 275, 2, "Gramos", "GMS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 275, 3, "Libras", "LIB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 275, 4, "Onzas", "ONZ", 0, 0, 0);

                //  276  Medida de Volumen
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 276, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 276, 1, "Metros Cúbicos", "MTS3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 276, 2, "Centímetros Cúbicos", "CMTS3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 276, 3, "Pies Cúbicos", "PIE3", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 276, 4, "Litros", "LIT", 0, 0, 0);

                //  277  Tipo de Frecuencia CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 1, "Diario", "DIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 2, "Semanal", "SEMANA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 3, "Quincenal", "QUIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 4, "Mensual", "MENS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 5, "Trimestral", "TRIM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 277, 6, "Año", "ANO", 0, 0, 0);

                //  278  Variables para Formatos de CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 0, "Nombre de la Compañía", "@cia", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 1, "Estimado/a/s", "@estimado", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 2, "Sr./Sra./Sres.", "@tipo_pers", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 3, "Moneda", "@moneda", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 4, "Nombre de la Persona", "@nombre", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 5, "Fecha de Análisis", "@f_analisis", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 6, "Cantidad de Documentos", "@cantdocs", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 7, "Monto Total", "@mtototal", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 8, "Monto Vencido", "@mtovencido", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 9, "Monto por Vencer", "@mtoxvencer", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 10, "Fecha del Documento", "@f_doc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 11, "Número del Documento", "@num_doc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 12, "Número de los Documentos", "@nums_doc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 13, "Dias Vencidos", "@diasvencdoc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 14, "Dias por Vencer", "@diasxvencdoc", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 15, "Tipo de Departamento", "@tipodpto", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 16, "Fecha de la Cita", "@f_cita", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 17, "Marca del Vehículo", "@marcaveh", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 18, "Modelo del Vehículo", "@modeloveh", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 19, "Año del Vehículo", "@anoveh", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 278, 20, "Fecha de Entrega", "@f_entrega", 0, 0, 0);

                //  279  Tipo de Anexo CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 1, "Estado de Cuenta de Cliente", "EDOCTACLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 2, "Retención a Proveedor", "RETPROV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 3, "Feliz Cumpleaños", "FELIZCUMP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 4, "Factura de Cliente", "FACTCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 5, "Prefactura de Cliente", "PREFACTCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 279, 6, "Pago a Proveedor", "PAGOAPROV", 0, 0, 0);

                //  280  Estatus de Proceso de CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 280, 0, "Pendiente", "PENDIENTE", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 280, 1, "Iniciado", "INICIADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 280, 2, "Finalizado", "FINALIZADO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 280, 3, "Abortado", "ABORTADO", 0, 0, 0);

                //  281  Tipo de Repetición de Eventos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 281, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 281, 1, "Horas", "HORA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 281, 2, "Minutos", "MINUT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 281, 3, "Segundos", "SEGUN", 0, 0, 0);

                //  282  Tipo de Trigger de Eventos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 282, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 282, 1, "Dias de la Semana", "DIASEMA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 282, 2, "Dias del Mes", "DIAMES", 0, 0, 0);

                //  283  Tipo de Periodo para Eventos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 1, "Dia Actual", "DIAACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 2, "Semana Actual", "SEMANAACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 3, "Quincena Actual", "QUINACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 4, "Mes Actual", "MESACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 5, "Trimestre Actual", "TRIMESTACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 6, "Semestre Actual", "SEMESTACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 7, "Año Actual", "ANOACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 8, "Dia Anterior", "DIAANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 9, "Semana Anterior", "SEMANAANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 10, "Quincena Anterior", "QUINANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 11, "Mes Anterior", "MESANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 12, "Trimestre Anterior", "TRIMESTANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 13, "Semestre Anterior", "SEMESTANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 14, "Año Anterior", "ANOANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 15, "Dias Atras", "DIASATRAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 16, "Meses Atras", "MESESATRAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 17, "Años Atras", "AÑOSATRAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 283, 18, "Sin Fecha", "SINFECHA", 0, 0, 0);

                //  284  Modalidad de disparo de Proceso de CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 284, 0, "Manual", "MANUAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 284, 1, "Por Horario", "HORARIO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 284, 2, "Por Evento", "EVENTO", 0, 0, 0);

                //  285  Tipo de Evento de disparo de Proceso de CRM
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 285, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 285, 1, "Al Cerrar la O/S", "CERO/S", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 285, 2, "Al Entregar un Vehiculo Nuevo", "ENTVEHVTA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 285, 3, "Al Facturar un Pedido de Repuesto", "FACTREP", 0, 0, 0);

                //  286  Tipo de Concepto para Medios Magnéticos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 286, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 286, 1, "Item", "ITEM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 286, 2, "ItemDev", "ITEMDEV", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 286, 3, "Descuento", "DCTO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 286, 4, "Texto", "TEXTO", 0, 0, 0);

                //  287  Tipo de Formato para Medios Magnéticos
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 1, "Pagos y abonos en cuenta y Retenciones practicadas", "1001", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 2, "Retenciones fuente que le practicaron", "1003", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 3, "Descuentos Tributarios", "1004", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 4, "IVA Descontable de compras y devoluciones ventas", "1005", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 5, "IVA Generado en ventas y devoluciones de compra", "1006", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 6, "Ingresos recibidos", "1007", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 7, "Saldo de cuentas por cobrar", "1008", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 8, "Saldo de cuentas por pagar", "1009", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 9, "Información de socios, accionistas y/o cooperados", "1010", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 10, "Ingresos recibidos para terceros", "1647", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 11, "Pagos o abonos en cuenta y retenciones practicadas", "1043", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 12, "Ingresos brutos recibidos,devoluciones,rebajas y descuentos", "1045", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 13, "IVA descontable y en devoluciones en compras", "1585", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 14, "IVA generado y en devoluciones en ventas", "1586", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 15, "Saldo de los deudores", "1587", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 287, 16, "Saldo de los pasivos", "1588", 0, 0, 0);

                //  289  Tipo de Medida para Alto Ancho Profundo
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 289, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 289, 1, "Centímetros", "CMTS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 289, 2, "Pulgadas", "PULG", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 289, 3, "Pies", "PIES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 289, 4, "Metros", "MTS", 0, 0, 0);

                //  290  Tipo de Rango para Comisiones de Servicio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 290, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 290, 1, "Comisión por Rango", "COMIS_X_RAN", 0, 0, 0);

                //  291  Tipo de Distribución de Expediente
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 1, "Valor", "VAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 2, "Peso", "PESO", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 3, "Volumen", "VOL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 4, "Arancel", "ARAN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 5, "Cantidad", "CANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 291, 6, "Renglón", "RENG", 0, 0, 0);

                //  293  Procedencia Requis. de Rep.
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 293, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 293, 1, "Llamada Telefónica", "LLAMATEL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 293, 2, "Pagina WEB", "PAGWEB", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 293, 3, "Email", "EMAIL", 0, 0, 0);

                //  295  Status para Leasing Propio
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 295, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 295, 1, "Leasing OK", "OK", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 295, 2, "Por Recuperar", "XRECUP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 295, 3, "Por Perdida de Leasing", "XPERDIDA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 295, 4, "Leasing Vencido", "VENC", 0, 0, 0);

                //  296  Tipo de Operación Bancaria
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 296, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 296, 1, "Depósito de Tarjeta", "DEPOTARJ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 296, 2, "Depósito de Chq. y Ef.", "DEPOCHQ", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 296, 3, "Depósito contra Concepto", "DEPOCPTO", 0, 0, 0);

                //  298  Motivo de Desatencion de Soporte
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 1, "No Contesta", "NOCONT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 2, "Conduciendo", "CONDU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 3, "Ocupado con Otro Cliente", "OCUOTRCLI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 4, "Sin Servicio de Internet", "SININTER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 5, "En Implantación", "IMPLANT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 6, "Entrenamiento", "ENTRENA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 7, "Consultoría Local", "CONSLOCAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 8, "Diligencia Personal", "DILPERS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 9, "Permiso Laboral", "PERMLABOR", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 298, 10, "Vacaciones", "VACAC", 0, 0, 0);

                //  299  Tipo de Importacion de Mov. bancarios
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 299, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 299, 1, "Formato Generico VZLA", "GENERICO01", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 299, 2, "Formato Generico USA", "GENERICO02", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 299, 11, "Amex Account Activity", "AMEXACCACT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 299, 12, "Bank Account Activity", "BANKACCACT", 0, 0, 0);

                //  300  Tipo de Giro Leasing
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 1, "Inicial Leasing", "INILEAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 2, "Giro Leasing", "GIRLEAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 3, "Rescate Leasing", "RESCLEAS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 4, "Aporte a Capital Leasing", "APORCAP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 300, 5, "Liquidación del Leasing", "LIQUILEAS", 0, 0, 0);

                //  301  Tipo de Reglon Leasing
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 0, "N/A", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 1, "Capital", "CAPITAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 2, "Intereses", "INTERESES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 3, "Gastos", "GASTOS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 4, "Intereses de Mora", "INTMORA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 301, 5, "Ingresos por Financiamiento", "INGRFINAN", 0, 0, 0);

                //  302  Estatus de Contrato Leasing
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 0, "Sin Procesar", "S/P", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 1, "Iniciado", "INIC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 2, "Finalizado", "FINAL", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 3, "Recuperado", "RECUP", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 4, "Perdido", "PERD", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 5, "Pago Total", "PAGTOT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 302, 6, "Reversado", "REVER", 0, 0, 0);

                //  303  Subtipo de O/S MSI
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 1, "Mantenimiento Periódico", "MANTPER", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 2, "Reparaciones Generales", "REPGEN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 3, "Cambio de Aceite", "CAMBACEI", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 4, "Otros Servicios CPUS", "OTROSRVCPU", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 5, "Garantía", "GARANTIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 6, "Inspecciones 1.000 km", "INSP1000", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 7, "Inspecciones 10.000 km", "INSP10000", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 8, "PDS", "PDS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 9, "Servicios Internos", "SRVINT", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 303, 10, "Otros Servicios Internos", "OTROSRVINT", 0, 0, 0);

                //  304  Tipo de SMTP para email
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 304, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 304, 1, "CRM General", "CRMGEN", 0, 0, 0);

                //  305  Tipo para envio de email
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 305, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 305, 1, "CRM General", "CRMGEN", 0, 0, 0);

                //  306  Frecuencia para Reportes
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 1, "Diario", "DIA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 2, "Semanal", "SEMANA", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 3, "Quincenal", "QUIN", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 4, "Mensual", "MENS", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 5, "Trimestral", "TRIM", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 6, "Semestral", "SEMES", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 306, 7, "Anual", "ANO", 0, 0, 0);

                //  307  Tipo de Gasto para Sales Tax
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 307, 0, "No Aplica", "N/A", 0, 0, 0);

                //  308  Tipo de Comprobante
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 308, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 308, 1, "Provision", "PROVISION", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 308, 2, "Provision Reversa Siguiente Mes", "PROVSIGMES", 0, 0, 0);

                //  309  Tipo de Comprobante NIC
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 309, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 309, 1, "Deterioro de Ingresos", "DETING", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 309, 2, "Deterioro de CXC", "DETCXC", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 309, 3, "Deterioro de Inventario", "DETINV", 0, 0, 0);

                //  310  SubTipo de Documento
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 310, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 310, 1, "Deterioro de Inventario", "DETINV", 0, 0, 0);

                //  311  Tipo Esp. de Impuesto
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 311, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 311, 1, "Venezuela 10%", "VEN10", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 311, 2, "Dcto Imp. Tr. Elec. 3%", "VEN09", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 311, 3, "Dcto Imp. Tr. Elec. 5%", "VEN05", 0, 0, 0);

                //  314  Tipo de Archivo de persona
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 1, "Foto", "Foto", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 2, "Cedula", "Cedula", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 3, "RIF", "RIF", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 4, "Registro Mercantil", "Registro Mercantil", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 314, 5, "Contrato", "Contrato", 0, 0, 0);

                //  315  Tipo de Redes Sociales
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 0, "No Aplica", "N/A", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 1, "Twiter", "Twiter", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 2, "Facebook", "Facebook", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 3, "Instagram", "Instagram", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 4, "LinkedIn", "LinkedIn", 0, 0, 0);
                await _dominioDetService.LlenaDomDet(listaDominioDet, pais, 315, 5, "WhatsApp", "WhatsApp", 0, 0, 0);

                await _dominioDetService.SalvarLista(listaDominioDet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
         

        //------------------------------------------------------------------
        // Crear los Paises
        //------------------------------------------------------------------


        public async Task CrearPaisesAsync()
        {
            try
            {

                var listaDePaises = new List<Pais>();

                await _paisService.AgregarPais(listaDePaises, 93, "Afganistán", "República Islámica de Afganistán", "Asia", " AF ", "AFG", " af ", "93", ".af", "AFG", "004");
                await _paisService.AgregarPais(listaDePaises, 355, "Albania", "República de Albania", "Europa", " AL ", "ALB", " al ", "355", ".al", "AL", "008");
                await _paisService.AgregarPais(listaDePaises, 49, "Alemania", "República Federal de Alemania", "Europa", " DE ", "DEU", " gm ", "49", ".de", "D", "276");
                await _paisService.AgregarPais(listaDePaises, 376, "Andorra", "Principado de Andorra", "Europa", " AD ", "AND", " an ", "376", ".ad", "AND", "020");
                await _paisService.AgregarPais(listaDePaises, 244, "Angola", "República de Angola", "África", " AO ", "AGO", " ao ", "244", ".ao", "ANG", "024");
                await _paisService.AgregarPais(listaDePaises, 9264, "Anguila", "Anguila", "América del Norte", " AI ", "AIA", " av ", "1 264", ".ai", "AXA", "660");
                await _paisService.AgregarPais(listaDePaises, 6721, "Antártida", "Antártida", "Antártida", " AQ ", "ATA", " ay ", "6721", ".aq", "ARK", "010");
                await _paisService.AgregarPais(listaDePaises, 9268, "Antigua y Barbuda", "Antigua y Barbuda", "América del Norte", " AG ", "ATG", " ac ", "1 268", ".ag", "AG", "028");
                await _paisService.AgregarPais(listaDePaises, 966, "Arabia Saudita", "Reino de Arabia Saudí", "Asia", " SA ", "SAU", " sa ", "966", ".sa", "KSA", "682");
                await _paisService.AgregarPais(listaDePaises, 213, "Argelia", "República Argelina Democrática y Popular", "África", " DZ ", "DZA", " ag ", "213", ".dz", "DZ", "012");
                await _paisService.AgregarPais(listaDePaises, 54, "Argentina", "República Argentina", "América del Sur", " AR ", "ARG", " ar ", "54", ".ar", "RA", "032");
                await _paisService.AgregarPais(listaDePaises, 374, "Armenia", "República de Armenia", "Asia", " AM ", "ARM", " am ", "374", ".am", "AM", "051");
                await _paisService.AgregarPais(listaDePaises, 297, "Aruba", "Aruba", "América del Norte", " AW ", "ABW", " aa ", "297", ".aw", "AUA/ ARU", "533");
                await _paisService.AgregarPais(listaDePaises, 9962, "Australia", "Commonwealth de Australia", "Oceanía", " AU ", "AUS", " as ", "61", ".au", "AUS", "036");
                await _paisService.AgregarPais(listaDePaises, 43, "Austria", "República de Austria", "Europa", " AT ", "AUT", " au ", "43", ".at", "A", "040");
                await _paisService.AgregarPais(listaDePaises, 994, "Azerbaiyán", "República de Azerbaiyán", "Asia", " AZ ", "AZE", " aj ", "994", ".az", "AZ", "031");
                await _paisService.AgregarPais(listaDePaises, 9242, "Bahamas", "Commonwealth de las Bahamas", "América del Norte", " BS ", "BHS", " bf ", "1 242", ".bs", "BS", "044");
                await _paisService.AgregarPais(listaDePaises, 880, "Bangladés", "República Popular de Bangladés", "Asia", " BD ", "BGD", " bg ", "880", ".bd", "BD", "050");
                await _paisService.AgregarPais(listaDePaises, 9246, "Barbados", "Barbados", "América del Norte", " BB ", "BRB", " bb ", "1 246", ".bb", "BDS", "052");
                await _paisService.AgregarPais(listaDePaises, 973, "Baréin", "Reino de Baréin", "Asia", " BH ", "BHR", " ba ", "973", ".bh", "BRN", "048");
                await _paisService.AgregarPais(listaDePaises, 32, "Bélgica", "Reino de Bélgica", "Europa", " BE ", "BEL", " be ", "32", ".be", "B", "056");
                await _paisService.AgregarPais(listaDePaises, 501, "Belice", "Belice", "América del Norte", " BZ ", "BLZ", " bh ", "501", ".bz", "BZ", "084");
                await _paisService.AgregarPais(listaDePaises, 229, "Benín", "República de Benín", "África", " BJ ", "BEN", " bn ", "229", ".bj", "DY", "204");
                await _paisService.AgregarPais(listaDePaises, 9441, "Bermudas", "Bermudas", "América del Norte", " BM ", "BMU", " bd ", "1 441", ".bm", " ", "060");
                await _paisService.AgregarPais(listaDePaises, 375, "Bielorrusia", "República de Bielorrusia", "Europa", " BY ", "BLR", " bo ", "375", ".by", "BY", "112");
                await _paisService.AgregarPais(listaDePaises, 591, "Bolivia", "Estado Plurinacional de Bolivia", "América del Sur", " BO ", "BOL", " bl ", "591", ".bo", "BOL", "068");
                await _paisService.AgregarPais(listaDePaises, 5997, "Bonaire, San Eustaquio y Saba", "Bonaire, San Eustaquio y Saba", "América del Norte", " BQ ", "BES", " nl ", "5997", ".bq", " ", "530");
                await _paisService.AgregarPais(listaDePaises, 387, "Bosnia y Herzegovina", "Bosnia y Herzegovina", "Europa", " BA ", "BIH", " bk ", "387", ".ba", "BIH", "070");
                await _paisService.AgregarPais(listaDePaises, 267, "Botsuana", "República de Botsuana", "África", " BW ", "BWA", " bc ", "267", ".bw", "RB/BW", "072");
                await _paisService.AgregarPais(listaDePaises, 55, "Brasil", "República Federativa de Brasil", "América del Sur", " BR ", "BRA", " br ", "55", ".br", "BR", "076");
                await _paisService.AgregarPais(listaDePaises, 673, "Brunéi Darussalam", "Estado de Brunéi Darusalam", "Asia", " BN ", "BRN", " bx ", "673", ".bn", "BRU", "096");
                await _paisService.AgregarPais(listaDePaises, 359, "Bulgaria", "República de Bulgaria", "Europa", " BG ", "BGR", " bu ", "359", ".bg", "BG", "100");
                await _paisService.AgregarPais(listaDePaises, 226, "Burkina Faso", "Burkina Faso", "África", " BF ", "BFA", " uv ", "226", ".bf", "BF", "854");
                await _paisService.AgregarPais(listaDePaises, 257, "Burundi", "República de Burundi", "África", " BI ", "BDI", " by ", "257", ".bi", "RU", "108");
                await _paisService.AgregarPais(listaDePaises, 975, "Bután", "Reino de Bután", "Asia", " BT ", "BTN", " bt ", "975", ".bt", "BHT", "064");
                await _paisService.AgregarPais(listaDePaises, 238, "Cabo Verde", "República de Cabo Verde", "África", " CV ", "CPV", " cv ", "238", ".cv", "CV", "132");
                await _paisService.AgregarPais(listaDePaises, 855, "Camboya", "Reino de Camboya", "Asia", " KH ", "KHM", " cb ", "855", ".kh", "K", "116");
                await _paisService.AgregarPais(listaDePaises, 237, "Camerún", "República de Camerún", "África", " CM ", "CMR", " cm ", "237", ".cm", "CAM", "120");
                await _paisService.AgregarPais(listaDePaises, 9111, "Canadá", "Canadá", "América del Norte", " CA ", "CAN", " ca ", "1", ".ca", "CDN", "124");
                await _paisService.AgregarPais(listaDePaises, 235, "Chad", "República de Chad", "África", " TD ", "TCD", " cd ", "235", ".td", "TCH", "148");
                await _paisService.AgregarPais(listaDePaises, 56, "Chile", "República de Chile", "América del Sur", " CL ", "CHL", " ci ", "56", ".cl", "RCH", "152");
                await _paisService.AgregarPais(listaDePaises, 86, "China", "República Popular China", "Asia", " CN ", "CHN", " ch ", "86", ".cn", "CN", "156");
                await _paisService.AgregarPais(listaDePaises, 357, "Chipre", "República de Chipre", "Asia", " CY ", "CYP", " cy ", "357", ".cy", "CY", "196");
                await _paisService.AgregarPais(listaDePaises, 57, "Colombia", "República de Colombia", "América del Sur", " CO ", "COL", " co ", "57", ".co", "CO", "170");
                await _paisService.AgregarPais(listaDePaises, 269, "Comoras", "Unión de las Comoras", "África", " KM ", "COM", " cn ", "269", ".km", "COM", "174");
                await _paisService.AgregarPais(listaDePaises, 243, "Congo", "República del Congo", "África", " CG ", "COG", " cg ", "243", ".cg", "RCB", "178");
                await _paisService.AgregarPais(listaDePaises, 242, "Congo RD", "República Democrática del Congo", "África", " CD ", "COD", " cf ", "242", ".cd", "ZRE", "180");
                await _paisService.AgregarPais(listaDePaises, 82, "Corea del Sur", "República de Corea", "Asia", " KR ", "KOR", " ks ", "82", ".kr", "ROK", "410");
                await _paisService.AgregarPais(listaDePaises, 850, "Corea del Norte", "República Popular Democrática de Corea", "Asia", " KP ", "PRK", " kn ", "850", ".kp", "KP", "408");
                await _paisService.AgregarPais(listaDePaises, 225, "Costa de Marfil", "República de Costa de Marfil", "África", " CI ", "CIV", " iv ", "225", ".ci", "CI", "384");
                await _paisService.AgregarPais(listaDePaises, 506, "Costa Rica", "República de Costa Rica", "América del Norte", " CR ", "CRI", " cs ", "506", ".cr", "CR", "188");
                await _paisService.AgregarPais(listaDePaises, 385, "Croacia", "República de Croacia", "Europa", " HR ", "HRV", " hr ", "385", ".hr", "HR", "191");
                await _paisService.AgregarPais(listaDePaises, 53, "Cuba", "República de Cuba", "América del Norte", " CU ", "CUB", " cu ", "53", ".cu", "C", "192");
                await _paisService.AgregarPais(listaDePaises, 599, "Curazao", "Curazao", "América del Norte", " CW ", "CUW", " cc ", "599", ".cw", " ", "531");
                await _paisService.AgregarPais(listaDePaises, 45, "Dinamarca", "Reino de Dinamarca", "Europa", " DK ", "DNK", " da ", "45", ".dk", "DK", "208");
                await _paisService.AgregarPais(listaDePaises, 9767, "Dominica", "Commonwealth de Dominica", "América del Norte", " DM ", "DMA", " do ", "1 767", ".dm", "WD", "212");
                await _paisService.AgregarPais(listaDePaises, 593, "Ecuador", "República del Ecuador", "América del Sur", " EC ", "ECU", " ec ", "593", ".ec", "EC", "218");
                await _paisService.AgregarPais(listaDePaises, 20, "Egipto", "República Árabe de Egipto", "África", " EG ", "EGY", " eg ", "20", ".eg", "ET", "818");
                await _paisService.AgregarPais(listaDePaises, 503, "El Salvador", "República de El Salvador", "América del Norte", " SV ", "SLV", " es ", "503", ".sv", "ES", "222");
                await _paisService.AgregarPais(listaDePaises, 971, "Emiratos Árabes Unidos", "Emiratos Árabes Unidos", "Asia", " AE ", "ARE", " ae ", "971", ".ae", "UAE", "784");
                await _paisService.AgregarPais(listaDePaises, 291, "Eritrea", "Estado de Eritrea", "África", " ER ", "ERI", " er ", "291", ".er", "ER", "232");
                await _paisService.AgregarPais(listaDePaises, 421, "Eslovaquia", "República Eslovaca", "Europa", " SK ", "SVK", " lo ", "421", ".sk", "SK", "703");
                await _paisService.AgregarPais(listaDePaises, 386, "Eslovenia", "República de Eslovenia", "Europa", " SI ", "SVN", " si ", "386", ".si", "SLO", "705");
                await _paisService.AgregarPais(listaDePaises, 34, "España", "Reino de España", "Europa", " ES ", "ESP", " sp ", "34", ".es", "E", "724");
                await _paisService.AgregarPais(listaDePaises, 1, "Estados Unidos", "Estados Unidos de América", "América del Norte", " US ", "USA", " us ", "1", ".us", "USA", "840");
                await _paisService.AgregarPais(listaDePaises, 372, "Estonia", "República de Estonia", "Europa", " EE ", "EST", " en ", "372", ".ee", "EST", "233");
                await _paisService.AgregarPais(listaDePaises, 251, "Etiopía", "República Democrática Federal de Etiopía", "África", " ET ", "ETH", " et ", "251", ".et", "ETH", "231");
                await _paisService.AgregarPais(listaDePaises, 7, "Rusia", "Federacion Rusa", "Europa", " RU ", "RUS", " rs ", "7", ".ru", "RUS", "643");
                await _paisService.AgregarPais(listaDePaises, 63, "Filipinas", "República de Filipinas", "Asia", " PH ", "PHL", " rp ", "63", ".ph", "RP", "608");
                await _paisService.AgregarPais(listaDePaises, 358, "Finlandia", "República de Finlandia", "Europa", " FI ", "FIN", " fi ", "358", ".fi", "FIN", "246");
                await _paisService.AgregarPais(listaDePaises, 679, "Fiyi", "República de Fiyi", "Oceanía", " FJ ", "FJI", " fj ", "679", ".fj", "FJI", "242");
                await _paisService.AgregarPais(listaDePaises, 33, "Francia", "República Francesa", "Europa", " FR ", "FRA", " fr ", "33", ".fr", "F", "250");
                await _paisService.AgregarPais(listaDePaises, 241, "Gabón", "República Gabonesa", "África", " GA ", "GAB", " gb ", "241", ".ga", "G", "266");
                await _paisService.AgregarPais(listaDePaises, 220, "Gambia", "República de Gambia", "África", " GM ", "GMB", " ga ", "220", ".gm", "WAG", "270");
                await _paisService.AgregarPais(listaDePaises, 995, "Georgia", "Georgia", "Asia", " GE ", "GEO", " gg ", "995", ".ge", "GE", "268");
                await _paisService.AgregarPais(listaDePaises, 233, "Ghana", "República de Ghana", "África", " GH ", "GHA", " gh ", "233", ".gh", "GH", "288");
                await _paisService.AgregarPais(listaDePaises, 350, "Gibraltar", "Gibraltar", "Europa", " GI ", "GIB", " gi ", "350", ".gi", "GBZ", "292");
                await _paisService.AgregarPais(listaDePaises, 9473, "Granada", "Granada", "América del Norte", " GD ", "GRD", " gj ", "1 473", ".gd", "WG", "308");
                await _paisService.AgregarPais(listaDePaises, 30, "Grecia", "República Helénica", "Europa", " GR ", "GRC", " gr ", "30", ".gr", "GR", "300");
                await _paisService.AgregarPais(listaDePaises, 299, "Groenlandia", "Groenlandia", "América del Norte", " GL ", "GRL", " gl ", "299", ".gl", "KN", "304");
                await _paisService.AgregarPais(listaDePaises, 590, "Guadalupe", "Guadalupe", "América del Norte", " GP ", "GLP", " fr ", "590", ".gp", " ", "312");
                await _paisService.AgregarPais(listaDePaises, 9671, "Guam", "Guam", "Oceanía", " GU ", "GUM", " gq ", "1 671", ".gu", "GM", "316");
                await _paisService.AgregarPais(listaDePaises, 502, "Guatemala", "República de Guatemala", "América del Norte", " GT ", "GTM", " gt ", "502", ".gt", "GCA", "320");
                await _paisService.AgregarPais(listaDePaises, 594, "Guayana Francesa", "Guayana Francesa", "América del Sur", " GF ", "GUF", " fr ", "594", ".gf", " ", "254");
                await _paisService.AgregarPais(listaDePaises, 44, "Guernsey", "Guernsey", "Europa", " GG ", "GGY", " gk ", "44", ".gg", "GBG", "831");
                await _paisService.AgregarPais(listaDePaises, 224, "Guinea", "República de Guinea", "África", " GN ", "GIN", " gv ", "224", ".gn", "RG", "324");
                await _paisService.AgregarPais(listaDePaises, 240, "Guinea Ecuatorial", "República de Guinea Ecuatorial", "África", " GQ ", "GNQ", " ek ", "240", ".gq", "GQ", "226");
                await _paisService.AgregarPais(listaDePaises, 245, "Guinea-Bisáu", "República de Guinea-Bisáu", "África", " GW ", "GNB", " pu ", "245", ".gw", "RGB/ GW", "624");
                await _paisService.AgregarPais(listaDePaises, 592, "Guyana", "República Cooperativa de Guyana", "América del Sur", " GY ", "GUY", " gy ", "592", ".gy", "GUY", "328");
                await _paisService.AgregarPais(listaDePaises, 509, "Haití", "República de Haití", "América del Norte", " HT ", "HTI", " ha ", "509", ".ht", "RH", "332");
                await _paisService.AgregarPais(listaDePaises, 504, "Honduras", "República de Honduras", "América del Norte", " HN ", "HND", " ho ", "504", ".hn", "HN", "340");
                await _paisService.AgregarPais(listaDePaises, 852, "Hong Kong", "Hong Kong", "Asia", " HK ", "HKG", " hk ", "852", ".hk", "HK", "344");
                await _paisService.AgregarPais(listaDePaises, 36, "Hungría", "República de Hungría", "Europa", " HU ", "HUN", " hu ", "36", ".hu", "H", "348");
                await _paisService.AgregarPais(listaDePaises, 91, "India", "República de la India", "Asia", " IN ", "IND", " in ", "91", ".in", "IND", "356");
                await _paisService.AgregarPais(listaDePaises, 62, "Indonesia", "República de Indonesia", "Asia", " ID ", "IDN", " id ", "62", ".id", "RI", "360");
                await _paisService.AgregarPais(listaDePaises, 964, "Irak", "República de Irak", "Asia", " IQ ", "IRQ", " iz ", "964", ".iq", "IRQ", "368");
                await _paisService.AgregarPais(listaDePaises, 98, "Irán", "República Islámica de Irán", "Asia", " IR ", "IRN", " ir ", "98", ".ir", "IR", "364");
                await _paisService.AgregarPais(listaDePaises, 353, "Irlanda", "Irlanda", "Europa", " IE ", "IRL", " ei ", "353", ".ie", "IRL", "372");
                await _paisService.AgregarPais(listaDePaises, 47, "Isla Bouvet", "Isla Bouvet", "Antártida", " BV ", "BVT", " bv ", "47", ".bv", " ", "074");
                await _paisService.AgregarPais(listaDePaises, 9945, "Isla de Man", "Isla de Man", "Europa", " IM ", "IMN", " im ", "44", ".im", "GBM", "833");
                await _paisService.AgregarPais(listaDePaises, 61, "Isla de Navidad", "Isla de Navidad", "Asia", " CX ", "CXR", " kt ", "61", ".cx", " ", "162");
                await _paisService.AgregarPais(listaDePaises, 6723, "Isla Norfolk", "Isla Norfolk", "Oceanía", " NF ", "NFK", " nf ", "6723", ".nf", " ", "574");
                await _paisService.AgregarPais(listaDePaises, 354, "Islandia", "República de Islandia", "Europa", " IS ", "ISL", " ic ", "354", ".is", "IS", "352");
                await _paisService.AgregarPais(listaDePaises, 9018, "Islas Åland", "Islas Åland", "Europa", " AX ", "ALA", " fi ", "358 18", ".ax", "AX", "018");
                await _paisService.AgregarPais(listaDePaises, 9345, "Islas Caimán", "Islas Caimán", "América del Norte", " KY ", "CYM", " cj ", "1 345", ".ky", " ", "136");
                await _paisService.AgregarPais(listaDePaises, 9961, "Islas Cocos (Keeling)", "Islas Cocos (Keeling)", "Asia", " CC ", "CCK", " ck ", "61", ".cc", " ", "166");
                await _paisService.AgregarPais(listaDePaises, 682, "Islas Cook", "Islas Cook", "Oceanía", " CK ", "COK", " cw ", "682", ".ck", " ", "184");
                // await _paisService.AgregarPais(listaDePaises, 500, "Islas Falkland (Malvinas)", "Islas Falkland (Malvinas)", "América del Sur", " FK ", "FLK", " fk ", "500", ".fk", " ", "234");
                await _paisService.AgregarPais(listaDePaises, 298, "Islas Feroe", "Islas Feroe", "Europa", " FO ", "FRO", " fo ", "298", ".fo", "FO", "234");
                await _paisService.AgregarPais(listaDePaises, 9500, "Islas Georgias del Sur y Sandwich del Sur", "Islas Georgias del Sur y Sandwich del Sur", "Antártida", " GS ", "SGS", " sx ", "500", ".gs", " ", "239");
                await _paisService.AgregarPais(listaDePaises, 9672, "Islas Heard y Mcdonald", "Islas Heard y Mcdonald", "Antártida", " HM ", "HMD", " hm ", "1 672", ".hm", " ", "334");
                await _paisService.AgregarPais(listaDePaises, 9670, "Islas Marianas del Norte", "Islas Marianas del Norte", "Oceanía", " MP ", "MNP", " cq ", "1 670", ".mp", " ", "580");
                await _paisService.AgregarPais(listaDePaises, 692, "Islas Marshall", "República de las Islas Marshall", "Oceanía", " MH ", "MHL", " rm ", "692", ".mh", "MH", "584");
                await _paisService.AgregarPais(listaDePaises, 677, "Islas Salomón", "Islas Salomón", "Oceanía", " SB ", "SLB", " bp ", "677", ".sb", "SOL", "090");
                await _paisService.AgregarPais(listaDePaises, 9649, "Islas Turcas y Caicos", "Islas Turcas y Caicos", "América del Norte", " TC ", "TCA", " tk ", "1 649", ".tc", " ", "796");
                await _paisService.AgregarPais(listaDePaises, 9808, "Islas Ultramarinas Menores de Estados Unidos", "Islas Ultramarinas Menores de Estados Unidos", "Oceanía", " UM ", "UMI", " um ", "1 808", ".um", " ", "581");
                await _paisService.AgregarPais(listaDePaises, 9284, "Islas Virgenes Británicas", "Islas Virgenes Británicas", "América del Norte", " VG ", "VGB", " vi ", "1 284", ".vg", "BVI", "092");
                await _paisService.AgregarPais(listaDePaises, 9340, "Islas Virgenes de Los Estados Unidos", "Islas Virgenes de Los Estados Unidos", "América del Norte", " VI ", "VIR", " vq ", "1 340", ".vi", " ", "850");
                await _paisService.AgregarPais(listaDePaises, 972, "Israel", "Estado de Israel", "Asia", " IL ", "ISR", " is ", "972", ".il", "IL", "376");
                await _paisService.AgregarPais(listaDePaises, 39, "Italia", "República Italiana", "Europa", " IT ", "ITA", " it ", "39", ".it", "I", "380");
                await _paisService.AgregarPais(listaDePaises, 9876, "Jamaica", "Jamaica", "América del Norte", " JM ", "JAM", " jm ", "1 876", ".jm", "JA", "388");
                await _paisService.AgregarPais(listaDePaises, 81, "Japón", "Japón", "Asia", " JP ", "JPN", " ja ", "81", ".jp", "J", "392");
                await _paisService.AgregarPais(listaDePaises, 9944, "Jersey", "Jersey", "Europa", " JE ", "JEY", " je ", "44", ".je", "GBJ", "832");
                await _paisService.AgregarPais(listaDePaises, 962, "Jordania", "Reino Hachemí de Jordania", "Asia", " JO ", "JOR", " jo ", "962", ".jo", "HKJ", "400");
                await _paisService.AgregarPais(listaDePaises, 9007, "Kazajistán", "República de Kazajistán", "Asia", " KZ ", "KAZ", " kz ", "7", ".kz", "KZ", "398");
                await _paisService.AgregarPais(listaDePaises, 254, "Kenia", "República de Kenia", "África", " KE ", "KEN", " ke ", "254", ".ke", "EAK", "404");
                await _paisService.AgregarPais(listaDePaises, 996, "Kirguistán", "República Kirguisa", "Asia", " KG ", "KGZ", " kg ", "996", ".kg", "KS", "417");
                await _paisService.AgregarPais(listaDePaises, 686, "Kiribati", "República de Kiribati", "Oceanía", " KI ", "KIR", " kr ", "686", ".ki", "KIR", "296");
                await _paisService.AgregarPais(listaDePaises, 965, "Kuwait", "Estado de Kuwait", "Asia", " KW ", "KWT", " ku ", "965", ".kw", "KWT", "414");
                await _paisService.AgregarPais(listaDePaises, 266, "Lesoto", "Reino de Lesoto", "África", " LS ", "LSO", " lt ", "266", ".ls", "LS", "426");
                await _paisService.AgregarPais(listaDePaises, 371, "Letonia", "República de Letonia", "Europa", " LV ", "LVA", " lg ", "371", ".lv", "LV", "428");
                await _paisService.AgregarPais(listaDePaises, 961, "Líbano", "República Libanesa", "Asia", " LB ", "LBN", " le ", "961", ".lb", "RL", "422");
                await _paisService.AgregarPais(listaDePaises, 231, "Liberia", "República de Liberia", "África", " LR ", "LBR", " li ", "231", ".lr", "LB", "430");
                await _paisService.AgregarPais(listaDePaises, 218, "Libia", "Libia", "África", " LY ", "LBY", " ly ", "218", ".ly", "LAR", "434");
                await _paisService.AgregarPais(listaDePaises, 423, "Liechtenstein", "Principado de Liechtenstein", "Europa", " LI ", "LIE", " ls ", "423", ".li", "FL", "438");
                await _paisService.AgregarPais(listaDePaises, 370, "Lituania", "República de Lituania", "Europa", " LT ", "LTU", " lh ", "370", ".lt", "LT", "440");
                await _paisService.AgregarPais(listaDePaises, 352, "Luxemburgo", "Gran Ducado de Luxemburgo", "Europa", " LU ", "LUX", " lu ", "352", ".lu", "L", "442");
                await _paisService.AgregarPais(listaDePaises, 853, "Macao", "Macao", "Asia", " MO ", "MAC", " mc ", "853", ".mo", "MO", "446");
                await _paisService.AgregarPais(listaDePaises, 389, "Macedonia", "Antigua República Yugoslava de Macedonia", "Europa", " MK ", "MKD", " mk ", "389", ".mk", "MK", "807");
                await _paisService.AgregarPais(listaDePaises, 261, "Madagascar", "República de Madagascar", "África", " MG ", "MDG", " ma ", "261", ".mg", "RM", "450");
                await _paisService.AgregarPais(listaDePaises, 60, "Malasia", "Malasia", "Asia", " MY ", "MYS", " my ", "60", ".my", "MAL", "458");
                await _paisService.AgregarPais(listaDePaises, 265, "Malaui", "República de Malaui", "África", " MW ", "MWI", " mi ", "265", ".mw", "MW", "454");
                await _paisService.AgregarPais(listaDePaises, 960, "Maldivas", "República de Maldivas", "Asia", " MV ", "MDV", " mv ", "960", ".mv", "MV", "462");
                await _paisService.AgregarPais(listaDePaises, 223, "Malí", "República de Malí", "África", " ML ", "MLI", " ml ", "223", ".ml", "RMM", "466");
                await _paisService.AgregarPais(listaDePaises, 356, "Malta", "República de Malta", "Europa", " MT ", "MLT", " mt ", "356", ".mt", "M", "470");
                await _paisService.AgregarPais(listaDePaises, 212, "Marruecos", "Reino de Marruecos", "África", " MA ", "MAR", " mo ", "212", ".ma", "MA", "504");
                await _paisService.AgregarPais(listaDePaises, 596, "Martinica", "Martinica", "América del Norte", " MQ ", "MTQ", " fr ", "596", ".mq", " ", "474");
                await _paisService.AgregarPais(listaDePaises, 230, "Mauricio", "República de Mauricio", "África", " MU ", "MUS", " mp ", "230", ".mu", "MS", "480");
                await _paisService.AgregarPais(listaDePaises, 222, "Mauritania", "República Islámica de Mauritania", "África", " MR ", "MRT", " mr ", "222", ".mr", "RIM", "478");
                await _paisService.AgregarPais(listaDePaises, 262, "Mayotte", "Mayotte", "África", " YT ", "MYT", " fr ", "262", ".yt", " ", "175");
                await _paisService.AgregarPais(listaDePaises, 52, "México", "Estados Unidos Mexicanos", "América del Norte", " MX ", "MEX", " mx ", "52", ".mx", "MEX", "484");
                await _paisService.AgregarPais(listaDePaises, 691, "Micronesia", "Estados Federados de Micronesia", "Oceanía", " FM ", "FSM", " fm ", "691", ".fm", "FSM", "583");
                await _paisService.AgregarPais(listaDePaises, 373, "Moldavia", "República de Moldavia", "Europa", " MD ", "MDA", " md ", "373", ".md", "MD", "498");
                await _paisService.AgregarPais(listaDePaises, 377, "Mónaco", "Principado de Mónaco", "Europa", " MC ", "MCO", " mn ", "377", ".mc", "MC", "492");
                await _paisService.AgregarPais(listaDePaises, 976, "Mongolia", "Mongolia", "Asia", " MN ", "MNG", " mg ", "976", ".mn", "MGL", "496");
                await _paisService.AgregarPais(listaDePaises, 382, "Montenegro", "Montenegro", "Europa", " ME ", "MNE", " mj ", "382", ".me", "MNE", "499");
                await _paisService.AgregarPais(listaDePaises, 9664, "Montserrat", "Montserrat", "América del Norte", " MS ", "MSR", " mh ", "1 664", ".ms", " ", "500");
                await _paisService.AgregarPais(listaDePaises, 258, "Mozambique", "República de Mozambique", "África", " MZ ", "MOZ", " mz ", "258", ".mz", "MOC", "508");
                await _paisService.AgregarPais(listaDePaises, 95, "Myanmar", "Unión de Myanmar", "Asia", " MM ", "MMR", " bm ", "95", ".mm", "MYA", "104");
                await _paisService.AgregarPais(listaDePaises, 264, "Nabimia", "República de Namibia", "África", " NA ", "NAM", " wa ", "264", ".na", "NAM", "516");
                await _paisService.AgregarPais(listaDePaises, 674, "Nauru", "República de Nauru", "Oceanía", " NR ", "NRU", " nr ", "674", ".nr", "NAU", "520");
                await _paisService.AgregarPais(listaDePaises, 977, "Nepal", "República Democrática Federal de Nepal", "Asia", " NP ", "NPL", " np ", "977", ".np", "NEP", "524");
                await _paisService.AgregarPais(listaDePaises, 505, "Nicaragua", "República de Nicaragua", "América del Norte", " NI ", "NIC", " nu ", "505", ".ni", "NIC", "558");
                await _paisService.AgregarPais(listaDePaises, 227, "Níger", "República de Niger", "África", " NE ", "NER", " ng ", "227", ".ne", "RN", "562");
                await _paisService.AgregarPais(listaDePaises, 234, "Nigeria", "República Federal de Nigeria", "África", " NG ", "NGA", " ni ", "234", ".ng", "WAN", "566");
                await _paisService.AgregarPais(listaDePaises, 683, "Niue", "Niue", "Oceanía", " NU ", "NIU", " ne ", "683", ".nu", " ", "570");
                await _paisService.AgregarPais(listaDePaises, 9948, "Noruega", "Reino de Noruega", "Europa", " NO ", "NOR", " no ", "47", ".no", "N", "578");
                await _paisService.AgregarPais(listaDePaises, 687, "Nueva Caledonia", "Nueva Caledonia", "Oceanía", " NC ", "NCL", " nc ", "687", ".nc", "NC", "540");
                await _paisService.AgregarPais(listaDePaises, 64, "Nueva Zelanda", "Nueva Zelanda", "Oceanía", " NZ ", "NZL", " nz ", "64", ".nz", "NZ", "554");
                await _paisService.AgregarPais(listaDePaises, 968, "Omán", "Sultanato de Omán", "Asia", " OM ", "OMN", " mu ", "968", ".om", "OM", "512");
                await _paisService.AgregarPais(listaDePaises, 31, "Países Bajos", "Reino de los Países Bajos", "Europa", " NL ", "NLD", " nl ", "31", ".nl", "NL", "528");
                await _paisService.AgregarPais(listaDePaises, 92, "Pakistán", "República Islámica de Pakistán", "Asia", " PK ", "PAK", " pk ", "92", ".pk", "PK", "586");
                await _paisService.AgregarPais(listaDePaises, 680, "Palaos", "República de Palaos", "Oceanía", " PW ", "PLW", " ps ", "680", ".pw", "PAL", "585");
                await _paisService.AgregarPais(listaDePaises, 970, "Palestina", "Estado de Palestina", "Asia", " PS ", "PSE", " gz  we ", "970", ".ps", "PS", "275");
                await _paisService.AgregarPais(listaDePaises, 507, "Panamá", "República de Panamá", "América del Norte", " PA ", "PAN", " pm ", "507", ".pa", "PA", "591");
                await _paisService.AgregarPais(listaDePaises, 675, "Papúa Nueva Guinea", "Estado Independiente de Papúa Nueva Guinea", "Oceanía", " PG ", "PNG", " pp ", "675", ".pg", "PNG", "598");
                await _paisService.AgregarPais(listaDePaises, 595, "Paraguay", "República del Paraguay", "América del Sur", " PY ", "PRY", " pa ", "595", ".py", "PY", "600");
                await _paisService.AgregarPais(listaDePaises, 51, "Perú", "República del Perú", "América del Sur", " PE ", "PER", " pe ", "51", ".pe", "PE", "604");
                await _paisService.AgregarPais(listaDePaises, 9964, "Pitcairn", "Pitcairn", "Oceanía", " PN ", "PCN", " pc ", "64", ".pn", " ", "612");
                await _paisService.AgregarPais(listaDePaises, 689, "Polinesia Francesa", "Polinesia Francesa", "Oceanía", " PF ", "PYF", " fp ", "689", ".pf", " ", "258");
                await _paisService.AgregarPais(listaDePaises, 48, "Polonia", "República de Polonia", "Europa", " PL ", "POL", " pl ", "48", ".pl", "PL", "616");
                await _paisService.AgregarPais(listaDePaises, 351, "Portugal", "República Portuguesa", "Europa", " PT ", "PRT", " po ", "351", ".pt", "P", "620");
                await _paisService.AgregarPais(listaDePaises, 9057, "Puerto Rico", "Puerto Rico", "América del Norte", " PR ", "PRI", " rq ", "1 57/68", ".pr", "PR", "630");
                await _paisService.AgregarPais(listaDePaises, 974, "Qatar", "Estado de Qatar", "Asia", " QA ", "QAT", " qa ", "974", ".qa", "Q", "634");
                await _paisService.AgregarPais(listaDePaises, 9946, "Reino Unido", "Reino Unido de Gran Bretaña e Irlanda del Norte", "Europa", " GB ", "GBR", " uk ", "44", ".uk", "GB", "826");
                await _paisService.AgregarPais(listaDePaises, 236, "República Centroafricana", "República Centroafricana", "África", " CF ", "CAF", " ct ", "236", ".cf", "RCA", "140");
                await _paisService.AgregarPais(listaDePaises, 420, "República Checa", "República Checa", "Europa", " CZ ", "CZE", " ez ", "420", ".cz", "CZ", "203");
                await _paisService.AgregarPais(listaDePaises, 856, "República Democrática Popular Lao", "República Democrática Popular Lao", "Asia", " LA ", "LAO", " la ", "856", ".la", "LAO", "418");
                await _paisService.AgregarPais(listaDePaises, 9809, "República Dominicana", "República Dominicana", "América del Norte", " DO ", "DOM", " dr ", "1 809/829/ 849", ".do", "DOM", "214");
                await _paisService.AgregarPais(listaDePaises, 9262, "Reunión", "Reunión", "África", " RE ", "REU", " fr ", "262", ".re", " ", "638");
                await _paisService.AgregarPais(listaDePaises, 250, "Ruanda", "República de Ruanda", "África", " RW ", "RWA", " rw ", "250", ".rw", "RWA", "646");
                await _paisService.AgregarPais(listaDePaises, 40, "Rumania", "Rumania", "Europa", " RO ", "ROU", " ro ", "40", ".ro", "RO", "642");
                await _paisService.AgregarPais(listaDePaises, 9212, "Sahara Occidental", "Sahara Occidental", "África", " EH ", "ESH", " wi ", "212 28", ".eh", "WSA", "732");
                await _paisService.AgregarPais(listaDePaises, 685, "Samoa", "Estado Independiente de Samoa", "Oceanía", " WS ", "WSM", " ws ", "685", ".ws", "WS", "882");
                await _paisService.AgregarPais(listaDePaises, 9684, "Samoa Americana", "Samoa Americana", "Oceanía", " AS ", "ASM", " aq ", "1 684", ".as", " ", "016");
                await _paisService.AgregarPais(listaDePaises, 9590, "San Bartolomé", "San Bartolomé", "América del Norte", " BL ", "BLM", " tb ", "590", ".bl", " ", "991");
                await _paisService.AgregarPais(listaDePaises, 9869, "San Cristóbal y Nieves", "Federación de San Cristóbal y Nieves", "América del Norte", " KN ", "KNA", " sc ", "1 869", ".kn", "KAN", "659");
                await _paisService.AgregarPais(listaDePaises, 378, "San Marino", "República de San Marino", "Europa", " SM ", "SMR", " sm ", "378", ".sm", "RSM", "674");
                await _paisService.AgregarPais(listaDePaises, 9591, "San Martín (Parte Francesa)", "San Martín (Parte Francesa)", "América del Norte", " MF ", "MAF", " rn ", "590", ".mf", " ", "992");
                await _paisService.AgregarPais(listaDePaises, 508, "San Pedro y Miquelón", "San Pedro y Miquelón", "América del Norte", " PM ", "SPM", " sb ", "508", ".pm", " ", "666");
                await _paisService.AgregarPais(listaDePaises, 9784, "San Vicente y Las Granadinas", "San Vicente y Las Granadinas", "América del Norte", " VC ", "VCT", " vc ", "1 784", ".vc", "WV", "670");
                await _paisService.AgregarPais(listaDePaises, 290, "Santa Helena, Ascensión y Tristán de Acuña", "Santa Helena, Ascensión y Tristán de Acuña", "África", " SH ", "SHN", " sh ", "290", ".sh", " ", "654");
                await _paisService.AgregarPais(listaDePaises, 9758, "Santa Lucía", "Santa Lucía", "América del Norte", " LC ", "LCA", " st ", "1 758", ".lc", "WL", "662");
                await _paisService.AgregarPais(listaDePaises, 379, "Vaticano", "Estado de la Ciudad del Vaticano", "Europa", " VA ", "VAT", " vt ", "379", ".va", "V", "336");
                await _paisService.AgregarPais(listaDePaises, 239, "Santo Tomé y Principe", "República Democrática de Santo Tomé y Príncipe", "África", " ST ", "STP", " tp ", "239", ".st", "STP", "678");
                await _paisService.AgregarPais(listaDePaises, 221, "Senegal", "República de Senegal", "África", " SN ", "SEN", " sg ", "221", ".sn", "SN", "686");
                await _paisService.AgregarPais(listaDePaises, 381, "Serbia", "República de Serbia", "Europa", " RS ", "SRB", " ri ", "381", ".rs", "SRB", "688");
                await _paisService.AgregarPais(listaDePaises, 248, "Seychelles", "República de Seychelles", "África", " SC ", "SYC", " se ", "248", ".sc", "SY", "690");
                await _paisService.AgregarPais(listaDePaises, 232, "Sierra Leona", "República de Sierra Leona", "África", " SL ", "SLE", " sl ", "232", ".sl", "WAL", "694");
                await _paisService.AgregarPais(listaDePaises, 65, "Singapur", "República de Singapur", "Asia", " SG ", "SGP", " sn ", "65", ".sg", "SGP", "702");
                await _paisService.AgregarPais(listaDePaises, 9721, "Sint Maarten (Parte Neerlandesa)", "Sint Maarten (Parte Neerlandesa)", "América del Norte", " SX ", "SXM", " sk ", "1 721", ".sx", " ", "993");
                await _paisService.AgregarPais(listaDePaises, 963, "Siria", "República Árabe Siria", "Asia", " SY ", "SYR", " sy ", "963", ".sy", "SYR", "760");
                await _paisService.AgregarPais(listaDePaises, 252, "Somalia", "República Federal de Somalia", "África", " SO ", "SOM", " so ", "252", ".so", "SO", "706");
                await _paisService.AgregarPais(listaDePaises, 94, "Sri Lanka", "República Socialista Democrática de Sri Lanka", "Asia", " LK ", "LKA", " ce ", "94", ".lk", "CL", "144");
                await _paisService.AgregarPais(listaDePaises, 268, "Suazilandia", "Reino de Suazilandia", "África", " SZ ", "SWZ", " wz ", "268", ".sz", "SD", "748");
                await _paisService.AgregarPais(listaDePaises, 27, "Sudáfrica", "República de Sudáfrica", "África", " ZA ", "ZAF", " sf ", "27", ".za", "ZA", "710");
                await _paisService.AgregarPais(listaDePaises, 249, "Sudán", "República de Sudán", "África", " SD ", "SDN", " su ", "249", ".sd", "SUD", "736");
                await _paisService.AgregarPais(listaDePaises, 211, "Sudán del Sur", "República de Sudán del Sur", "África", " SS ", "SSD", " od ", "211", ".ss", " ", "728");
                await _paisService.AgregarPais(listaDePaises, 46, "Suecia", "Reino de Suecia", "Europa", " SE ", "SWE", " sw ", "46", ".se", "S", "752");
                await _paisService.AgregarPais(listaDePaises, 41, "Suiza", "Confederación Suiza", "Europa", " CH ", "CHE", " sz ", "41", ".ch", "CH", "756");
                await _paisService.AgregarPais(listaDePaises, 597, "Surinam", "República de Surinam", "América del Sur", " SR ", "SUR", " ns ", "597", ".sr", "SME", "740");
                await _paisService.AgregarPais(listaDePaises, 9947, "Svalbard y Jan Mayen", "Svalbard y Jan Mayen", "Europa", " SJ ", "SJM", " sv  jn ", "47", ".sj", " ", "744");
                await _paisService.AgregarPais(listaDePaises, 66, "Tailandia", "Reino de Tailandia", "Asia", " TH ", "THA", " th ", "66", ".th", "T", "764");
                await _paisService.AgregarPais(listaDePaises, 886, "Taiwán", "Provincia de China de Taiwán", "Asia", " TW ", "TWN", " tw ", "886", ".tw", "RC", "158");
                await _paisService.AgregarPais(listaDePaises, 255, "Tanzania", "República Unida de Tanzania", "África", " TZ ", "TZA", " tz ", "255", ".tz", "EAT", "834");
                await _paisService.AgregarPais(listaDePaises, 992, "Tayikistán", "República de Tayikistán", "Asia", " TJ ", "TJK", " ti ", "992", ".tj", "TJ", "762");
                await _paisService.AgregarPais(listaDePaises, 246, "Territorio Británico del Océano Índico", "Territorio Británico del Océano Índico", "Asia", " IO ", "IOT", " io ", "246", ".io", " ", "086");
                await _paisService.AgregarPais(listaDePaises, 9000, "Territorios Australes Franceses", "Territorios Australes Franceses", "Antártida", " TF ", "ATF", " fs ", "-", ".tf", " ", "260");
                await _paisService.AgregarPais(listaDePaises, 670, "Timor-Leste", "República Democrática de Timor Oriental", "Asia", " TL ", "TLS", " tt ", "670", ".tl", "TL", "626");
                await _paisService.AgregarPais(listaDePaises, 228, "Togo", "República Togolesa", "África", " TG ", "TGO", " to ", "228", ".tg", "TG", "768");
                await _paisService.AgregarPais(listaDePaises, 690, "Tokelau", "Tokelau", "Oceanía", " TK ", "TKL", " tl ", "690", ".tk", " ", "772");
                await _paisService.AgregarPais(listaDePaises, 676, "Tonga", "Reino de Tonga", "Oceanía", " TO ", "TON", " tn ", "676", ".to", "TO", "776");
                await _paisService.AgregarPais(listaDePaises, 9868, "Trinidad y Tobago", "República de Trinidad y Tobago", "América del Norte", " TT ", "TTO", " td ", "1 868", ".tt", "TT", "780");
                await _paisService.AgregarPais(listaDePaises, 216, "Túnez", "República de Túnez", "África", " TN ", "TUN", " ts ", "216", ".tn", "TN", "788");
                await _paisService.AgregarPais(listaDePaises, 993, "Turkmenistán", "Turkmenistán", "Asia", " TM ", "TKM", " tx ", "993", ".tm", "TM", "795");
                await _paisService.AgregarPais(listaDePaises, 90, "Turquía", "República de Turquía", "Europa", " TR ", "TUR", " tu ", "90", ".tr", "TR", "792");
                await _paisService.AgregarPais(listaDePaises, 688, "Tuvalu", "Tuvalu", "Oceanía", " TV ", "TUV", " tv ", "688", ".tv", "TUV", "798");
                await _paisService.AgregarPais(listaDePaises, 380, "Ucrania", "Ucrania", "Europa", " UA ", "UKR", " up ", "380", ".ua", "UA", "804");
                await _paisService.AgregarPais(listaDePaises, 256, "Uganda", "República de Uganda", "África", " UG ", "UGA", " ug ", "256", ".ug", "EAU", "800");
                await _paisService.AgregarPais(listaDePaises, 598, "Uruguay", "República Oriental del Uruguay", "América del Sur", " UY ", "URY", " uy ", "598", ".uy", "UY", "858");
                await _paisService.AgregarPais(listaDePaises, 998, "Uzbekistán", "República de Uzbekistán", "Asia", " UZ ", "UZB", " uz ", "998", ".uz", "UZ", "860");
                await _paisService.AgregarPais(listaDePaises, 678, "Vanuatu", "República de Vanuatu", "Oceanía", " VU ", "VUT", " nh ", "678", ".vu", "VU", "548");
                await _paisService.AgregarPais(listaDePaises, 58, "Venezuela", "República Bolivariana de Venezuela", "América del Sur", " VE ", "VEN", " ve ", "58", ".ve", "YV", "862");
                await _paisService.AgregarPais(listaDePaises, 84, "Viet Nam", "República Socialista de Vietnam", "Asia", " VN ", "VNM", " vm ", "84", ".vn", "VN", "704");
                await _paisService.AgregarPais(listaDePaises, 681, "Wallis y Futuna", "Wallis y Futuna", "Oceanía", " WF ", "WLF", " wf ", "681", ".wf", " ", "876");
                await _paisService.AgregarPais(listaDePaises, 967, "Yemen", "República de Yemen", "Asia", " YE ", "YEM", " ym ", "967", ".ye", "YAR", "887");
                await _paisService.AgregarPais(listaDePaises, 253, "Yibuti", "Yibuti", "África", " DJ ", "DJI", " dj ", "253", ".dj", "DJI", "262");
                await _paisService.AgregarPais(listaDePaises, 260, "Zambia", "República de Zambia", "África", " ZM ", "ZMB", " za ", "260", ".zm", "Z", "894");
                await _paisService.AgregarPais(listaDePaises, 263, "Zimbabue", "República de Zimbabue", "África", " ZW ", "ZWE", " zi ", "263", ".zw", "ZW", "716");

                await _paisService.SalvarLista(listaDePaises);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //------------------------------------------------------------------
        // Crear los Estados, Ciudades y Municipios de Venezuela
        //------------------------------------------------------------------


        public async Task CreaEstadosMunipiosCiudadesDeVzla()
        {
            try
            {
                //EstadoMg estadoMg = new EstadoMg(_context);
                //_municipioService. _municipioService. = new _municipioService.(_context);
                //CiudadMg ciudadMg = new CiudadMg(_context);

                var listaDeMunicipios = new List<Municipio>();
                var listaDeCiudades = new List<Ciudad>();

                int pais_id = 1862;

                

                Estado estado = await _estadoService.AgregaEstado(pais_id, "Amazonas", "AMA", true);

                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Ayacucho", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Páez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maroa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Carlos de Rio Negro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Fernando de Atabapo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Fernando de Guainia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Manapiare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Simón de Cocuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa de Amanadona", "", true);

                //private async Task _municipioService.AgregaMunicipio(long estado_id, string nombre, string nomestado)



                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ALTO ORINOCO", "AMAZONAS");
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ATABAPO", "AMAZONAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ATURES", "AMAZONAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "AUTANA", "AMAZONAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MANAPIARE", "AMAZONAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MAROA", "AMAZONAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RÍO NEGRO", "AMAZONAS");



                estado = await _estadoService.AgregaEstado(pais_id, "Anzoátegui", "ANZ", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barcelona", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Anaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aragua de Barcelona", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Atapirire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barbacoa", "", true);
                //await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aragua de Barcelona", "", true);
                //await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Atapirire", "", true);
                //await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barbacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bergantín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Uchire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cachipo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cantaura", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Clarines", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Carito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Hatillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Morro de Barcelona", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pilar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Tigre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanape", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaribe de Cajigal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Margarita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lecherías", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Altos de Santa Fe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Pilones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mapire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Modulo de Boyacá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Modulo de Chuparin", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mundo Nuevo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Naricual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Onoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pariaguán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pertigalete", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Píritu", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pozuelos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto la Cruz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Píritu", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana de Uchire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Diego de Cabrutica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Joaquín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Guanipa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Mateo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pablo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Tomé", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Clara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz del Orinoco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Inés", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Uríca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Uverito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle Guanape", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zuata", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANACO", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARAGUA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "DIEGO BAUTISTA URBANEJA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FERNANDO DE PEÑALVER", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id,
                               "FRANCISCO DE CARMEN CARVAJAL", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FRANCISCO DE MIRANDA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUANTA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "INDEPENDENCIA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ GREGORIO MONAGAS", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUAN ANTONIO SOTILLO", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUAN MANUEL CAJIGAL", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTAD", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MANUEL EZEQUIEL BRUZUAL", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRO MARÍA FREITES", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÍRITU", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN JOSÉ DE GUANIPA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN JUAN DE CAPISTRANO", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTA ANA", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN BOLÍVAR", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN RODRÍGUEZ", "ANZOÁTEGUI");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIR ARTUR MCGREGOR", "ANZOÁTEGUI");

                estado = await _estadoService.AgregaEstado(pais_id, "Apure", "APU", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Fernando de Apure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Achaguas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Apurito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arichuna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Biruaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bruzual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camaguán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camatagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cazorla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cunaviche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Samán de Apure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Yagual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Elorza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guáchara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guasimal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guayabal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Trinidad de Orichuna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mantecal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Municipio Quintero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Nova", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Payara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Atamaica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ACHAGUAS", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BIRUACA", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MUÑOZ", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÁEZ", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRO CAMEJO", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RÓMULO GALLEGOS", "APURE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN FERNANDO", "APURE");

                estado = await _estadoService.AgregaEstado(pais_id, "Aragua", "ARA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maracay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alayón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alberto Solano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alí Primera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Andrés Bello", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Andrés Eloy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Andrés Eloy Blanco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Angélica de Lusinchi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Apolo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aquiles Nazoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aragüita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arias Blanco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arsenal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barbacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barbacoas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barrancón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Base Aragua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bella Vista", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bello Monte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bello Monte I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bermúdez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bosque Lindo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Brisas del Lago", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Buenos Aires", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caballero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cadillal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Calicanto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camatagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camburito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Alegre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Claro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Elías", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caña de Azúcar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cañaote", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cantarrana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cantor Nieve Río", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carlos Andrés Pérez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carlos Maza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carmen de Cura", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carrizalito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Casanova Godoy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Casco de la Ciudad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cementerio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Choroní", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Jardín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Universitaria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Codazzi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Cooperativa los Olivos Nuevos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Cooperativa los Olivos Viejos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Corianza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Corocito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Coromoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curiepe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cuyagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Doctor Pedro García", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Béisbol", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Bosque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Carmen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cementerio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Centro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Consejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Esfuerzo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Estadium", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Hipódromo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Indio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Lago", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Lechosal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Mácaro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Maomo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Milagro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Nido", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Ortiseño", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pinal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Progreso", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Recreo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Recurso", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Remanso", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Tierral", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Topo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Toquito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Toro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Trébol", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Triunfo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Valle de Santa Rita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Viñedo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ezequiel Zamora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Francisco de Miranda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Funda Villa I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Fundación Mendoza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Girardot", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaracarima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaruto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guayabita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guayamura", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güere", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güerito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guillen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güiripa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Independencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jabillar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jaime II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Antonio Páez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Casanova Godoy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Félix Rivas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Gregorio Hernández", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Juan Moreno", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Juana Medina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Julio Bracho", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Arboleda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Atascoza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Avanzada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Barraca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Candelaria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Capillita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Carpiera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Chapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Chatarrera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Concepción", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Coromoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Crispera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cruz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cuarta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Curia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Democracia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Encrucijada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Esmeralda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Esmeraldita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Floresta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Frontera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Fuente", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Fundación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Gallera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Hacienda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Haciendita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Hamaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Herrereña", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Iguana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Independencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Isabelita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Julia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Majada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Maracaya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Mora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Morita I y III", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Olla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Ovallera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Participación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Paz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pedrera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Primavera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Providencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Punta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Represa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Rinconada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Romana Nueva", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Romana Vieja", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Rosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Segundera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Soledad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Acacias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Animas I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Brisas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Carmenes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Casitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Cruces", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Delicias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Flores", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Luisas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Mayas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Mercedes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Peñitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Tunas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Vegas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Vegas I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertador", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Cachos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Caobos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Cerritos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Chaguaramos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Cocos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Colorados", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Galpones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Hornos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Jabillos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Naranjos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Nísperos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Overos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Pinos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Próceres", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Rauceos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Rosales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Samanes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Tanques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Tubos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lourdes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Magdaleno", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Malariología Antonio Aranguren", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maracay II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Marcelo Guzmán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "María Cristina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mario Briceño Iragorry", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mariscal Sucre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mata Redonda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mata Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Medina Angarita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mendoza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Miranda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monserrat", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mora 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morean Soto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morian Soto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morita II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Negro Primero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Niño de Jesús", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Oasis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ocumare de la Costa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ocumarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Orope", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palma Real", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palo Negro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paraparal I, II, III", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Payita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Peñuela Ruiz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piñonal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piñonal Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Polvorín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Portachuelo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Primitivo de Jesús", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Nuevo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Colombia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quebrada de Pipe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rafael Caldera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rafael Urdaneta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Residencias Coromoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Blanco I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rodríguez Palencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rómulo Gallegos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rosario de Paya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ruiz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabaneta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Samán de Güere", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Carlos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Casimiro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Francisco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Francisco de Asís", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Francisco de Cara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Ignacio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Isidro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Jacinto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Joaquín de Turmero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Luis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Mateo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pablo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro Alejandrino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Sebastián", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Eduvígis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Elena", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosalía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santo Domingo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector E", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector el Mijaú", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector Jovalito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector la Ceiba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector la Vaquera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector Punta del Monte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector San José", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sergio Medina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Simón Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Simón Rodríguez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Soco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sorocaima I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sucre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Surupei", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Taguay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tamarindo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tapatapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tejerías", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tierra Amarilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tinapuey I y II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tiuna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Toronjal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Trapiche del Medio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucutunemo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Turagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Turmero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Unión", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Andrés Bello", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Base Aragua", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Bermúdez", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Calicanto", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Caña de Azucar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Castaño", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Limón", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Toro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Fundación Mendoza", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Guey", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización José Felix Rivas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Arboleda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Candelaria", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Floresta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Rinconada", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Romana", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Soledad", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Acacias", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Caobos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Naranjos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Maracay", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Piñonal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Piñonal Sur", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Isidro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Jacinto", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Santa Fé", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Sergio Medina", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Tiuna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle de Morín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle Fresco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle Lindo I, II", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle Morín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle Verde", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Vía Colonia Tovar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Victoria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa de Cura", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Zuica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yarabí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zamora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zuata", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CAMATAGUA", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FRANCISCO LINARES ALCÁNTARA", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GIRARDOT", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ ÁNGEL LAMAS", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ FÉLIX RIBAS", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ RAFAEL REVENGA", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARIO BRICEÑO IRAGORRY", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "OCUMARE DE LA COSTA DE ORO", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN CASIMIRO", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN SEBASTIÁN", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTIAGO MARIÑO", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTOS MICHELENA", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TOVAR", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URDANETA", "ARAGUA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ZAMORA", "ARAGUA");

                estado = await _estadoService.AgregaEstado(pais_id, "Barinas", "BAR", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barinas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altamira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arismendi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barinitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barrancas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bruzual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Calderas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Capitanejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chameta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Bolivia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad de Nutrias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Dolores", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cantón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Real", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Regalo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guadarrama", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cochinilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Luz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maporal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mijagual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Obispos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pedraza la Vieja", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Nutrias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quebrada Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quintero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabaneta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sacopó", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Canaguá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Silvestre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Bárbara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Catalina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Inés", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Lucía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Torunos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Veguitas", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ALBERTO ARVELO TORREALBA", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS ELOY BLANCO", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANTONIO JOSÉ DE SUCRE", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARISMENDI", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BARINAS", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CRUZ PAREDES", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EZEQUIEL ZAMORA", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "OBISPOS", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRAZA", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ROJAS", "BARINAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SOSA", "BARINAS");

                estado = await _estadoService.AgregaEstado(pais_id, "Bolívar", "BOL", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Bolivar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Piar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caicara del Orinoco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cuchiberos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Dorado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Callao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Manteco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Miamo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Palmar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guasipati", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Icabarú", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jabillal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Kanavayén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Canoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Paragua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Urbina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Bonitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Majadas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Trincheras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Los Castillos de Guayana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Morichales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maripa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Matanzas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Moitaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Ordáz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puruey", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Félix", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Francisco de la Paragua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro de las Bocas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz de Orinoco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Elena de Uairén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosalía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Santa Teresa de Canavayen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Soledad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tumeremo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Upata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Vista Hermosa", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARONÍ", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CEDEÑO", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EL CALLAO", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GRAN SABANA", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "HERES", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PADRE PEDRO CHIEN", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PIAR", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RAÚL LEONI", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ROSCIO", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIFONTES", "BOLÍVAR");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "BOLÍVAR");

                estado = await _estadoService.AgregaEstado(pais_id, "Carabobo", "CAR", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Actoto Campesino Mirandita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Blanca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alegría", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alexander Burgos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altos de Guaparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ambrosio Plaza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "América", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Andrés Bello", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Antonio José de Sucre Norte, Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aquiles Nazoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Armando Celli", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Atlas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bárbula", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barrera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Base Naval", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bejuma", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Bella Vista I, II, III Etapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bello Monte 1, 2, 3", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Big Low Center", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Aroa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Tocuyo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bocaina 1 y 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Borburata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bosque Serino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Brisas del Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Brisas del Terminal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cabriales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camoruco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Alegre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Solo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Canaima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Canoabo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cañaveral", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carabobo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carmen Norte, Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Central Tacarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Centro de Valencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cesar Giro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chaguaramal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chirgua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Jardín Mañongo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Colinas de Guataparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Concordia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Coromoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Daimer", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Democracia 1 y 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Don Bosco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Bosque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Calvario", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cambur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Candelero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Combate", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Consejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Morro 1 y 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pajal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Palito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Palotal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Parral", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Prado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Prebo I, II, III", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Prebol", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Recreo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Rincón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Roble", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Romancero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Socorro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Trigalito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El triunfo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Trompillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Viñedo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Escalona", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Escorcha", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Eutimio Rivas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ezequiel Zamora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Federación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Finca Los Taladros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Flor Amarilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Flor Amarillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Flores", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Florida Norte y Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Francisco de Miranda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Freddy Franco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Goaigoaza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guacara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guataparo Country Club", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güigüe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Haras los Aguacates", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Impacto 1 y 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Industrial Carabobo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Industrial Castillito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Industrial la Guacamaya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Industrial la Quizanda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Industrial Municipal Norte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isabelita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Gregorio Hernández", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "José Regino Peña", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Arboleada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Blanquera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La California", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Castellana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Castrera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Entrada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Esmeralda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Florida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "La Guacamaya 1ª, 2ª y 3ª Etapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Isabelica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Línea", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Maestranza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Manguita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Milagrosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Planta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Raya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Romana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Romanita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Sorpresa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Trigaleña", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Unidad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Viña", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Acacias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Agüitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Clavellinas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Lomas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Quintas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Trincheras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertador", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Llano Verde", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lomas de Funval", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lomas del Este", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Alpes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Arales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Bucares 1, 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Caimitos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Caobos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Cerritos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Colorados", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Criollitos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Guayos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Harales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Jardines", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Magallanes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Mangos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Manguitos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Naranjos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Nísperos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Parques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Pozones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Sauces", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Taladros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Viveros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Luis Herrera Campins", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mañonguito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Máximo Romero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Mendoza 1, 2, 3, 4, 5, 6 y 7", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Michelena Norte y Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Miguel Aché", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Miranda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Montalbán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monte Serino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monumental", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Naguanagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Padre Alonzo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palma Real", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paraparal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Parque el Trigal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Parque Valencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paso Real", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Patanemo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piedras Negras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piedras Pintadas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo de Belén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo de Maraira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo de San Diego", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Cabello", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punto Nutria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rancho Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Renny Ottolina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ricardo Urriera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rinconcito Mañongo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ritec", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rosarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ruiz Pineda 1, 2 y 3", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana Larga", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Agustín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Blas 1, 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Blas Viejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Diego", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Joaquín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Tarbes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Sebastián", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cecilia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Eduvigis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Teresa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sesquicentenario", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Simón Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Taborda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Terraza de los Nísperos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tocuyito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tocuyo de la Costa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Trigal Norte, Sur, Centro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucacas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Unión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urabanización Piedras Pintada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urama", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Alegria", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Altos de Guaparo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Camoruco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Campo Alegre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Campo Solo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Carabobo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización chaguaramal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Ciudad Alianza", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Ciudad Jardin Mañongo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Colinas de Guataparo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Colon", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Don Bosco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Bosque", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Morro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Morro 1 y 2", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Palotal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Parral", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Prado", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Prebo I II III", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Prebol", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Recreo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Trigalito", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Viñedo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Flor Amarillo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Fundación Mendoza", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Guatsaparo Country Club", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Guayabal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Kerdel", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Arboleda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Castellana", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Esmeralda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Guacamaya 1 2 3 Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Isabelica", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Trigaleña", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Viña", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Acacias", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Clavellinas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Quintas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Lomas del Este", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Arales", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Bucares 1 y 2", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Jardines", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Magallanes", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Naranjos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Nisperos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Sauces", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Mendoza 1.2.3.4.5.6.y.7", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Michelena Norte y Sur", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Monte Serino", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Nueva Esparta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Paraparal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Parque el Trigal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Parque Valencia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Paso Real", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanizacion Ritec", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Terraza de los Nisperos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Trigal Norte Sur Centro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Valle de Camoruco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Castillito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urdaneta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle de Aguirre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle de Camoruco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Venezuela", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Victoria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Vigirima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Jardín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Vivienda Popular de los Guayos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Vivienda Rural los Arales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yuma 1 y 2", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Zona Industrial la Isabelica", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BEJUMA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARLOS ARVELO", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "DIEGO IBARRA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUACARA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUAN JOSÉ MORA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LOS GUAYOS", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MIRANDA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MONTALBÁN", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "NAGUANAGUA", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PUERTO CABELLO", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN DIEGO", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN JOAQUÍN", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TOCUYITO", "CARABOBO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VALENCIA", "CARABOBO");

                estado = await _estadoService.AgregaEstado(pais_id, "Cojedes", "COJ", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Linda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Apartaderos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arismendi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cojedes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cojeditos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Amparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Baúl", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Torito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guadarrama", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Aguadita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Sierra", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Vegas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad de Cojedes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macapo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Manrique", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Carlos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tinaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tinaquillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Vallecito", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANZOÁTEGUI", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EL PAO DE SAN JUAN BAUTISTA", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FALCÓN", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GIRARDOT", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIMA BLANCO", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RICAURTE", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RÓMULO GALLEGOS", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN CARLOS DE AUSTRIA", "COJEDES");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TINACO", "COJEDES");

                estado = await _estadoService.AgregaEstado(pais_id, "Delta Amacuro", "DA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Coporito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curiapo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Orquesta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macareíto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pedernales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sacupana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Mazareito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Catalina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tabasca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucupita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Uracoa", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANTONIO DÍAZ", "DELTA AMACURO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CASACOIMA", "DELTA AMACURO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDERNALES", "DELTA AMACURO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TUCUPITA", "DELTA AMACURO");

                estado = await _estadoService.AgregaEstado(pais_id, "Dependencias Federales", "DF", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Archipiélago Las Aves", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Archipiélago Los Monjes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Archipiélago Los Roques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla de Aves Norte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla de Patos Este", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla La Blanquilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla La Orchila", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla la Sola", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Isla la Tortuga y Cayos adyacentes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Islas los Frailes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Islas Los Hermanos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Islas Los Testigos", "", true);

                estado = await _estadoService.AgregaEstado(pais_id, "Distrito Capital", "DC", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caracas", "", true);
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "DISTRITO CAPITAL");

                estado = await _estadoService.AgregaEstado(pais_id, "Falcón", "FA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Acurigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Adaure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Clara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Larga", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Linda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Salada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agüide", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Amuay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aracua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Baraived", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bariro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Mangle", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Tocuyo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Borojó", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cabure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caja de Agua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Capadare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Capatárida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Casigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chichiriviche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Churuguara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Coro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Corralito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curamichate", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curarí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curimagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Dabajuro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Charal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Duvisí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Menen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Vínculo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaibacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jácura", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jadacaquiva", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Chapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cruz de Taratara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Negrita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pastora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Tabla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Taza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Vela de Coro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lizardo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mancillar de la Costa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mapararí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mataruca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mene Mauroa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mirimire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mitare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pecaya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pedregal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piedra Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Píritu", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Cumarebo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Pueblo Nuevo de la Sierra", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Pueblo Nuevo de Paraguaná", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Cumarebo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punta Cardón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punto Fijo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pureche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Bruzual", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Seque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de los Cayos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Lorenzo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Luis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel de Macoruca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz de Bucaral", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tocópero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tocumo de la Rosita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tupure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urumaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zazárida", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ACOSTA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BUCHIVACOA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CACIQUE MANAURE", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARIRUBANA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "COLINA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "DABAJURO", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "DEMOCRACIA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FALCÓN", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FEDERACIÓN", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JACURA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LOS TAQUES", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MAUROA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MIRANDA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MONSEÑOR ITURRIZA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PALMASOLA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PETIT", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÍRITU", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN FRANCISCO", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SILVA", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TOCÓPERO", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "UNIÓN", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URUMACO", "FALCÓN");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ZAMORA", "FALCÓN");

                estado = await _estadoService.AgregaEstado(pais_id, "Guárico", "GUA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altagracia de Orituco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Calabozo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cambural de Cataure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cazorla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chaguaramas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Corozopando", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Dos Caminos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Calvario", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Caro de la Negra", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Chaparro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Corozo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Palito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Punzón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Rastro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Socorro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Sombrero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Espino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Francisco de Tiznado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guardatinaja", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaripa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ipare de Orituco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Arboleda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Esperanza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Unión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Mercedes del Llano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Minas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lezama", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad de Orituco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Pozotes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mamonal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ortíz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Parapara de Ortíz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paso Real de Macaira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pirital", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Roblecito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Sabana Grande de Orituco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Francisco de Macaira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Anare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Guaribe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Tiznados", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Unare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de los Morros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Laya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Orituco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa María de Ipire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rita de Manapire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucupido", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle la Pascua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zaraza", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CAMAGUÁN", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CHAGUARAMAS", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EL SOCORRO", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FRANCISCO DE MIRANDA", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ FÉLIX RIBAS", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ TADEO MONAGAS", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUAN GERMÁN ROSCIO", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JULIÁN MELLADO", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LAS MERCEDES", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LEONARDO INFANTE", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ORTIZ", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRO ZARAZA", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN GERÓNIMO DE GUAYABAL", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN JOSÉ DE GUARIBE", "GUÁRICO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTA MARÍA DE IPIRE", "GUÁRICO");

                estado = await _estadoService.AgregaEstado(pais_id, "Lara", "LARA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Salada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aguada Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aregue", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arenales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Atarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Baragua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barbacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barquisimeto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Basarida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bobare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bocare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Buena Vista", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Burere", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cabudare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cariragua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Casa de Agua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cubiro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Duaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Empedrado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Porvenir", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guadalupe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guárico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Humocaro Alto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Humocaro Bajo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Miel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pastora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Vega", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Casitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Guabinas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Rastrojos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Yabos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Matatere", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Moran", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Moroturo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Moyetones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palmarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pie de Cuesta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puricaure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quebrada Arriba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quíbor", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Claro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Tocuyo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Francisco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pablo de Lara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sanare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sarare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Siquisique", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urucure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Nueva", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS ELOY BLANCO", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CRESPO", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "IRIBARREN", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JIMÉNEZ", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MORÁN", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PALAVECINO", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN PLANAS", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TORRES", "LARA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URDANETA", "LARA");

                estado = await _estadoService.AgregaEstado(pais_id, "Mérida", "MERIDA", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Acarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Acequias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Apartaderos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arapuey", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bailadores", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Batatal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Canaguá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caño Zancudo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Capazón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chachopo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chiguará", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chocantá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ejido", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Guayabo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Morro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Peñón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Vigía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Encontrados", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Estanques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaraque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guayabones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Humboldt", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jají", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Azulita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Blanca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La González", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Hechicera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Mesa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Mesa de Ejido", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Palmita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Parroquia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pedregosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Playa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Playita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Punta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Trampa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Unión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Vega", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lagunilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Piedras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Virtudes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los González", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Sauzales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Medio Cuarto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mérida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mesa Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mesa Quintero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Moralito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mucuchachí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mucuchíes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mucujepe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mucurubá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mucutuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Piñango", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Llano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Nuevo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Cristobal de Torondoy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Jacinto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Lagunilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Mucuchíes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Santa Apolonia de Merida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz de Mora", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Elena de Arenales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa María de Caparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santo Domingo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tabay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Timotes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tovar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucani", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tucantocani", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zea", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ALBERTO ADRIANI", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS BELLO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANTONIO PINTO SALINAS", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARICAGUA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARZOBISPO CHACÓN", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CAMPO ELÍAS", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARACCIOLO PARRA OLMEDO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARDENAL QUINTERO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUARAQUE", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JULIO CÉSAR SALAS", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUSTO BRICEÑO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MIRANDA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "OBISPO RAMOS DE LORA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PADRE NOGUERA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PUEBLO LLANO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RANGEL", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RIVAS DÁVILA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTOS MARQUINA", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TOVAR", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TULIO FEBRES CORDERO", "MÉRIDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ZEA", "MÉRIDA");

                estado = await _estadoService.AgregaEstado(pais_id, "Miranda", "MIR", true);
                //-- Crea las Ciudades del Estado
                //ciudad =llenaCiudad(estado.estado_id, "Aeropuerto la Carlota", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Araira", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Carmen Minas de Baruta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Carmen Petare", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Manguito Petare", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Rodeo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Cruz Chacao", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Cruz Petare", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Niño Jesús", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Blas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Miguel Petare", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Unión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Capaya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carenero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carrizal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caucagüa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Centro Comercial Plaza las Americas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Charallave", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chirimena", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chuspa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chuspita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cúa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cúpira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Curiepe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Café", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Guapo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Hatillo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "El Marqués", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarenas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guatire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Higuerote", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Tahona", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las González", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lomas de la Lagunita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Chorros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Samanes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Teques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Machurucuto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mamporal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ocumare del Tuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paracotos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Petare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Plaza las Américas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Prados del Este", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Nuevo Mamporal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Chico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Antonio de los Altos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Blas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Diego de los Altos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Fernando del Guapo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Francisco de Yare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Barlovento", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de los Altos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Río Chico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro de los Altos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Lucía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Paula", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa de Lima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Teresa del Tuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sebucán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector la Estancia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sector los Naranjos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Simón Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tacarigua de la Laguna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tacarigua Mamporal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tácata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Terrazas de Club Hípico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "U.S.B.", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Altamira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Alto Hatillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Alto Prado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Avila", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Bello Campo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Boleita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Boleita Alta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización California Norte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización California Sur", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Campo Alegre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Canteras de Miranda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Caracas Country Club", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Caurimare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Chacao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Chuao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de Baruta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de Bello Monte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de la California", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de la Mariposa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de la Trinidad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de los Ruices", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de Turumo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas de Valle Arriba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Colinas del Tamanaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Cumbres de Curumo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Cútira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Don Bosco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Cafetal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Dorado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Llanito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Marqués", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización el Pedregal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Peñón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Placer", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización el Placer de María", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Prado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Retiro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización el Rosal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización la Boyera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización la Carlota", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Castellana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Ciudadela", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización la Cumbre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Esmeralda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Esperanza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Estancia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Floresta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Lagunita Country Club", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Mariposa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización la Trinidad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización la Urbina", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización las Bonitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización las Mercedes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización las Minas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización las Vegas de Petare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Lomas de las Mercedes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Lomas del Club Hípico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización los Chorros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización los Cortijos de Lourdes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización los Dos Caminos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización los Naranjos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización los Ruices", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Macaracuay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urbanización Mampote", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Mirador del Este", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ACEVEDO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS BELLO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BARUTA", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BRIÓN", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BUROZ", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARRIZAL", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CHACAO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CRISTÓBAL ROJAS", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EL HATILLO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUAICAIPURO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "INDEPENDENCIA", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LANDER", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LOS SALIAS", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÁEZ", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PAZ CASTILLO", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRO GUAL", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PLAZA", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN BOLÍVAR", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "MIRANDA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URDANETA", "MIRANDA");

                estado = await _estadoService.AgregaEstado(pais_id, "Monagas", "MON", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aguasay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alto Guri", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altos de los Godos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Andrés Eloy Blanco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aragua de Maturín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Areo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Azagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bajo Guarapiche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barrancas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Brisas de Aribi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cachipo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caicara de Maturín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Alegre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caño Colorado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carabobo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caripe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caripito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chaguaramal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Corozo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cortijo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Furrial", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Junín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Merey", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Paraíso", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pelón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Respiro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Tejero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Zamuro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Zorro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanaguana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarapiche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jusepín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Candelaria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cruz de la Paloma", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Guanota", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Morrocoya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Plantación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Poderosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Toscana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Alhuacas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Brisas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Cocuizas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Palmeras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Piñas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertador", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Guaritos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Pinos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Manreza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maturín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Miraflores", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morichal Largo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Amador", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punta Gorda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quiriquire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Antonio de Maturín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Antonio de Tabasca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Felix de Monagas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Francisco de Maturín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Luis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Bárbara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Elena", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sarabria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Temblador", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Teresén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tirado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Viento Colao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Viento Fresco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Vuelta Larga", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Zona Industrial", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ZAMORA", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ACOSTA", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "AGUASAY", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARIPE", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CEDEÑO", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "EZEQUIEL ZAMORA", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MATURIN", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PIAR", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PUNCERES", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTA BARBARA", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SOTILLO", "MONAGAS");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URACOA", "MONAGAS");

                estado = await _estadoService.AgregaEstado(pais_id, "Nueva Esparta", "NE", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua de Vaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altagracia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Antolin del Campo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca del Pozo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca del Río", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boquerón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chacachacare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Amparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Bicha", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Espinal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "El Guamache (Isla de Coche)", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "El Guamache (Punta de Piedras)", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Maco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pilar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "El Valle de Pedro González", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "El Valle del Espíritu Santo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güinima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Juan Griego", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Asunción", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Guardia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Isleta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Plaza de Paraguachí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Vecindad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Cabreras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Hernández", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Maritas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Piedras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Bagres", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Cerritos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Giles", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Gómez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Marvales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Millanes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macanao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Manzanillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mariño", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Orinoco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pampatar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pedregales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pedro González", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Porlamar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Fermín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punta de Piedras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Robledal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Antonio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan Bautista", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro de Coche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tacarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Luisa Cáceres de Arismendi", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Playa el Angel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Urbanización Valle Verde", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Rosa", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANTOLÍN DEL CAMPO", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARISMENDI", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "DÍAZ", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GARCÍA", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GÓMEZ", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MANEIRO", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARCANO", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARIÑO", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PENÍNSULA DE MACANAO", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TUBORES", "NUEVA ESPARTA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VILLALBA", "NUEVA ESPARTA");

                estado = await _estadoService.AgregaEstado(pais_id, "Portuguesa", "POR", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Acarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Blanca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aparición", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Araure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Biscucuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boconoíto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chabasquén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Colonia Tunén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Córdoba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Poblado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Concepción", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Estación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Misión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Trinidad", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Colorados", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Morrones", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mesa de Caruaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ospino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Papelón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paraíso de Chabasquén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Payara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pimpinela", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Píritu", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Onoto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosalía de Turen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Turen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Unellez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Bruzual", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "AGUA BLANCA", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARAURE", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ESTELLER", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUANARE", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUANARITO", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id,
                               "MONSEÑOR JOSÉ VICENTE DE UNDA", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "OSPINO", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÁEZ", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PAPELÓN", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN GENARO DE BOCONOITO", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN RAFAEL DE ONOTO", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTA ROSALÍA", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "PORTUGUESA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TURÉN", "PORTUGUESA");

                estado = await _estadoService.AgregaEstado(pais_id, "Sucre", "SUCRE", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Acarigua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Fría", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altos de Sucre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Araya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arenas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bohordal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caigüire", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campearito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Claro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cariaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carúpano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Casanay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Catuaro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chacopata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cristóbal Colón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cumaná", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cumanacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Morro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Paujil", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Peñón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pilar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Rincón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guanoco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarapiche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarauna", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guaraúnos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guariquén", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guayana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Güiria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Irapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Piedras de Cocollar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Vegas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Altos de Santa fe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Arroyos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macarapana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macuro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maraval", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Marigüitar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Muelle de Cariaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Nueva Colombia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Playa Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Santo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Punta Brava (Tunapuycito)", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quebrada Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Caribe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Casanay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Salado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Seco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Antonio del Golfo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Aerocuar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Juan de las Galdonas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Unare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Lorenzo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Vicente", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Fe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa María de Cariaco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Saucedo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Soro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tunapuicito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tunapuy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valle de San Bonifacio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yaguaraparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yoco", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS ELOY BLANCO", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS MATA", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARISMENDI", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BENÍTEZ", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BERMÚDEZ", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CAJIGAL", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CRUZ SALMERÓN ACOSTA", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARIÑO", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MEJÍA", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MONTES", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RIBERO", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "SUCRE");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VALDEZ", "SUCRE");

                estado = await _estadoService.AgregaEstado(pais_id, "Táchira", "TACH", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Abejales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aguas Calientes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boca de Grita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Borotá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caño Macho", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Colón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Coloncito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cordero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Delicias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Amparo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cantón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Carmen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cobre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Corozo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Hato de la Virgen", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Jordán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Nula", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Pino", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Piñal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Potosí", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Teteo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guasdualito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Helechales", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Hernandez", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Independencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Concordia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Florida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Fría", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Fundación", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Grita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Pedrera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Revancha", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Rinconada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Tendida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Victoria", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Dantas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Libertad del Táchira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Llano Largo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lobatera", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Caneyes", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Kioscos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Naranjos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Michelena", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Morotuto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Nueva Arcadia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Orope", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palmarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palmira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Patiecito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Peribeca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pregonero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Encima", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Hondo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo las Hernández", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Nuevo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quebrada Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Queniquea", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ramos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Río Chiquito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Rubio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Antonio del Táchira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Cristóbal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Félix", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Félix de Urraca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Joaquín de Navay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Bolívar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Josecito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan Bautista", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Colón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pedro de Lirio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael del Piñal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Simón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Seboruco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Táriba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Umuquena", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ureña", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Villa Páez", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS BELLO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANTONIO RÓMULO COSTA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "AYACUCHO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CÁRDENAS", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CÓRDOBA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FERNÁNDEZ FEO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FRANCISCO DE MIRANDA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GARCÍA DE HEVIA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "GUASIMOS", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "INDEPENDENCIA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JÁUREGUI", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSE MARÍA VARGAS", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JUNÍN", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTAD", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LIBERTADOR", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LOBATERA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MICHELENA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PANAMERICANO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEDRO MARÍA UREÑA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RAFAEL URDANETA", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAMUEL DARÍO MALDONADO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN CRISTÓBAL", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN JUDAS TADEO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SEBORUCO", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN RODRÍGUEZ", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TORBES", "TÁCHIRA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URIBANTE", "TÁCHIRA");

                estado = await _estadoService.AgregaEstado(pais_id, "Trujillo", "TRU", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Santa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Viva", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Altos de Estanque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Betijoque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boconó", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bolivia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Buena Vista", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Burbusay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caja Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Alegre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Elías", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carache", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carvajal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chejendé", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cuicas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Dividive", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Alto Escuque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Batatal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cenizo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Socorro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Escuque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isnotú", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Jajó", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Ceiba", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cejita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "La Concepción de Carache", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "La Concepción de Pampanito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cuchilla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Mesa de Esnujaque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Mulata", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Plazuela", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Plazuelita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Puerta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Quebrada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Unión", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Mesitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mendoza Fría", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mitón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monay", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monte Carmelo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Motatán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Niquitao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Nueva Bolivia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palmarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pampán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pampanito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punto Palmarito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana de Mendoza", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana Libre", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "San Cristóbal de Torondoy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José de Palmira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Juan de Betijoque", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Lázaro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Miguel de Bocono", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Boconó", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Carvajal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Ana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Santa Apolonia de Mérida", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Santa Apolonia de Trujillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Isabel", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rosa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santiago", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Torococo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Torondoy", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tostós", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Trujillo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Valera", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ANDRÉS BELLO", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOCONÓ", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CANDELARIA", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CARACHE", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ESCUQUE", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id,
                               "JOSÉ FELIPE MÁRQUEZ CAÑIZALES", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSÉ VICENTE CAMPO ELÍAS", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LA CEIBA", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MIRANDA", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MONTE CARMELO", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MOTATÁN", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PAMPÁN", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PAMPANITO", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "RAFAEL RANGEL", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN RAFAEL DE CARVAJAL", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "TRUJILLO", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URDANETA", "TRUJILLO");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VALERA", "TRUJILLO");

                estado = await _estadoService.AgregaEstado(pais_id, "Vargas", "VARGAS", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Anare", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Camurí Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caraballeda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carayaca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Catia la Mar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Guaira", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Sabana", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Salinas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Caracas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macuto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maiquetía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Marapa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Naiguatá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Oricao", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Carayaca", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VARGAS", "VARGAS");

                estado = await _estadoService.AgregaEstado(pais_id, "Yaracuy", "YAR", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Agua Negra", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Albarico", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aroa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boraure", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Elías", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chivacoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Corocote", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Caserío de Carabobo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cedrito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Guayabo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Farriar", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guama", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Hato Viejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Independencia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Hoya", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Rositas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Marín", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Nirgua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sabana de Parra", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Salom", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Felipe", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Pablo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Taría", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Temerla", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Urachiche", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yaritagua", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Yumare", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ARÍSTIDES BASTIDAS", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BOLÍVAR", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BRUZUAL", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "COCOROTE", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "INDEPENDENCIA", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JOSE ANTONIO PÁEZ", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LA TRINIDAD", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MANUEL MONGE", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "NIRGUA", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PEÑA", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN FELIPE", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "URACHICHE", "YARACUY");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VEROES", "YARACUY");

                estado = await _estadoService.AgregaEstado(pais_id, "Zulia", "ZUL", true);
                //-- Crea las Ciudades del Estado
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Maracaibo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Aeropuerto la Chinita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Alturitas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Arapuey", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Avenida los Haticos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bachaquero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barranca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Barranquitas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 14 de Noviembre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 18 de Diciembre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 19 de Abril", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 1º de Agosto", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 1º de Mayo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 21 de Octubre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 23 de Enero", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 24 de Julio", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 24 de Noviembre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 24 de Octubre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 28 de Diciembre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio 5 de Julio", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Alberto Carnevali", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Altamira", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Ana María Campos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Andrades Labarca", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Ayacucho", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Betulio González", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Blanco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Bolivia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Brisas del Sur", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Buena Vista", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Cabeza de Toro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Calendario", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Canchancha", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Cañada Honda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Capitán Chico", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Carabobo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Carmelo Urdaneta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Cerro de Marín", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Corazón de Jesús", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Corea", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Coromoto", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Cruz de Mayo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Cuatricentenario", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio de Estanques", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Don Bosco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Amparo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Bajo Grande", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Callao 1ª 2ª y 3ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Calvario", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Cardonal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Corito", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Cují", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Guaicaipuro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Indio", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Jazmín", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Manzanillo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Oso", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Pajal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Pedregal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Perú", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Potente", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Progreso", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Puente", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Silencio", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Socorro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Valle", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio el Vivero", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Francisco de Miranda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Fundación Mendoza", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Gallo Verde", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Jagüey Cují", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio José Antonio Páez", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio José Gregorio Hernández", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio José Hernández", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Bandera", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Chinita", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Ensenada", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Limpia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Lucha", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Manzana de Oro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Polar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Pomona", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Rinconada", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Salina", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Unidad", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio la Victoria", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio las Cabrias", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio las Marías", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio las Tarabas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio las Tres Marías", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Leonardo Ruiz Pineda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Libertad", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Libertador", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Andes", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Claveles", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Cortijos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Cujicitos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Estanques", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Manglares", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Olivos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Pinos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Planazos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Robles", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio los Sufridos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Marite", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Misión", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Monte Claro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Nueva Independencia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Nueva Vía", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Nuevo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Nuevo Mundo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Obrero", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Panamericano", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Paraíso", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Pueblo Aparte", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Pueblo Nuevo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Puerto Cabello", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Puerto Rico", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Puntica de Piedra", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Ranchería", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Raúl Leoni", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Ricardo Aguirre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Robinson Ferreira", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Rómulo Betancourt", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Sabaneta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Agustín", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Francisco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Javier", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San José", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Luis", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Miguel", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Pedro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio San Rafael", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Santa Rosa de Agua", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Santa Rosa de Tierra", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Santo Domingo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Sierra Maestra", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Simón Bolívar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Sur América", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Tamanaco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Teotiste de Gallegos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Terepaima", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Tierra Negra", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Udón Pérez", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Unión", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Valle Frío", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Venezuela", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Barrio Zulia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Bobures", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Boscán", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cabimas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Caja Seca", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Calle Larga", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campo Mara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Campos Petroleros", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carrasquero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Carretal", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cerro de los Cachos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ceuta", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Chiquinquirá", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Ciudad Ojeda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cojoro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Cojúa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Concepción", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Conjunto Residencial Gallo Verde", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Batey", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Carmelo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Cinco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Consejo de Siruma", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Guanábano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Laberinto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El LLano", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Mene", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Moralito", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Portón", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Siete", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Tablazo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "El Venado", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Guarero", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "I.N.O.S.", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla de San Carlos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Isla de Toas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Cañada", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Paz", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "La Rosita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Laberinto", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Lagunillas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Cruces", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Delicias", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Morochas", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Las Piedras", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Haticos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades,
                    estado.estado_id, "Los Puertos de Altagracia", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Los Teques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "M.A.C.", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Machango", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Machiques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Macoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Mene Grande", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Monte Claro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Palmarejo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Paraguaipoa", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Parcelamiento los Altos", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Parcelamiento Ricaurte", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pica Pica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Plaza de Toro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo de San Francisco", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Pueblo Nuevo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Puerto Escondido", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Punta Gorda", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Quisiro", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Residencia San Luis", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Ignacio", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San José", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Jose de Perija", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Lorenzo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Machiques", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Rafael de Mara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "San Timoteo", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Cruz de Mara", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Lucía", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Santa Rita", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Sinamaica", "", true);
                await _ciudadService.AgregaCiudad(listaDeCiudades, estado.estado_id, "Tía Juana", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Universidad del Zulia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización 3ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Adán Sthormes", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Alberto Carnavalli", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Alhambra", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Altos de la Vega", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Altos del Pilar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Amalias", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Bella Vista", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Bello Monte", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Bloques de San Francisco", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Buena Vista", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Canta Claro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Chevron", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Club Hípico", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Corazón de Jesús", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Coromoto 1ª y 2ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Creoles", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Cuatricentenario 1ª y 2ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Cumbres de Maracaibo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Callao", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Estanque", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Guayabal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Parque", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Pilar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Pilarcito", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Portal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Prado", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Rosal Sur", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Trébol", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización el Varillal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Enerbal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización FAC", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Fundación Mendoza", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Irama", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Islas Doradas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Juana de Avila", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la California", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Curva", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Estrella", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Floresta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Lago", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Pastora", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Paz 1ª y 2ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Rosaleda", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Trinidad", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización la Victoria 1ª y 2ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Lagomar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Lajas Blancas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Aceitunas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Carmelias", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Lomas", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización las Mercedes", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Lomas de Sabaneta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Altos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización los Olivos", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Maracaibo", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Miramar", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Monte Bello", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Monte Claro", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Naranjal", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Obrero", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Perijá", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Portuaria", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Raúl Leoni", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Ricaurte", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Ritchamond", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Rómulo Gallego", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Rotaria 1ª 2ª 3ª 4ª y 5ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Sabatorio", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Felipe 1ª y 2ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Francisco de Miranda 3ª Etapa", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Jacinto", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Miguel", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización San Rafael", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Santa Ana", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Santa Eduvigis", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Santa María", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Sucre", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Urdaneta", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Villa Nueva", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Virginia", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Vista del Lago", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Urbanización Zapara", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Villa del Rosario", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Zona Central de la Ciudad", "", true);
                //ciudad =llenaCiudad(estado.estado_id, "Zona Industrial", "", true);
                //-- Crea los Municipios del Estado
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ALMIRANTE PADILLA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "BARALT", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CABIMAS", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "CATATUMBO", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "COLÓN", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "FRANCISCO JAVIER PULGAR", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JESÚS ENRIQUE LOSADA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "JESÚS MARÍA SEMPRÚN", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LA CAÑADA DE URDANETA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "LAGUNILLAS", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MACHIQUES DE PERIJÁ", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MARACAIBO", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "MIRANDA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "PÁEZ", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "ROSARIO DE PERIJÁ", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SAN FRANCISCO", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SANTA RITA", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SIMÓN BOLÍVAR", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "SUCRE", "ZULIA");
                await _municipioService.AgregaMunicipio(listaDeMunicipios, estado.estado_id, "VALMORE RODRÍGUEZ", "ZULIA");

                await _ciudadService.SalvarLista(listaDeCiudades);
                await _municipioService.SalvarLista(listaDeMunicipios);

                //if (listaDeCiudades.Count() > 0) await _context.Ciudades.AddRangeAsync(listaDeCiudades);
                //if (listaDeMunicipios.Count() > 0) await _context.Municipios.AddRangeAsync(listaDeMunicipios);
                //if (listaDeCiudades.Count() > 0 || listaDeMunicipios.Count() > 0) await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //public async Task CreaMonedas()
        //{
        //    try
        //    {
        //        MonedaMg monedaMg = new MonedaMg(_context);
        //        var listaDeMonedas = new List<Moneda>();

        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Afganistán", "afgani", "?", "AFN", "pul", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Albania", "lek", "L", "ALL", "qindarkë", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Alemania", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Andorra", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Angola", "kuanza de Angola", "Kz", "AOA", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Arabia Saudí", "rial saudí", "?.?", "SAR", "halala", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Argelia", "dinar", "?.?", "DZD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Argentina", "peso argentino", "$", "ARS", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Aruba", "florín arubano", "ƒ", "AWG", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Australia", "dólar australiano", "$", "AUD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Austria", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bahamas", "dólar de las Bahamas", "$", "BSD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bangladés, Bangladesh", "taka de Bangladés", "?", "BDT", "paisa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Barbados", "dólar de las Barbados", "$", "BBD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Baréin, Bahrein", "dinar de Baréin", ".?.?", "BHD", "fils", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bélgica", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Belice", "dólar beliceño", "$", "BZD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bielorrusia, Belarús", "rublo bielorruso", "Br", "BYR", "kopek", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Birmania, Myanmar", "kiat de Birmania", "K", "MMK", "pya", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bolivia", "boliviano", "Bs.", "BOB", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bosnia y Herzegovina", "marco convertible de Bosnia y Herzegovina", "KM", "BAM", "fening", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Botsuana, Botswana", "pula de Botsuana", "P", "BWP", "tebe", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Brasil", "real brasileño", "R$", "BRL", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Brunéi", "dólar de Brunei", "$", "BND", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bulgaria", "leva búlgaro", "??", "BGN", "stotinka", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Burkina Faso", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Burundi", "franco burundés", "Fr", "BIF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Bután", "gultrum butanés", "Nu.", "BTN", "chetrum", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Cabo Verde", "escudo de Cabo Verde", "Esc, $", "CVE", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Camboya", "riel camboyano", "?", "KHR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Canadá", "dólar canadiense", "$", "CAD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Catar, Qatar", "rial catarí", "?.?", "QAR", "dírham", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Chad", "franco CFA", "Fr", "XAF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Chile", "peso chileno", "$", "CLP", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "China", "yuan, renminbi", "¥, ?", "CNY", "yan, fen", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Chipre", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Ciudad del Vaticano", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Colombia", "peso colombiano", "$", "COP", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Comores", "franco comorano", "Fr", "KMF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Corea del Norte", "won norcoreano", "?", "KPW", "chon", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Corea del Sur", "won surcoreano", "?", "KRW", "yeon", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Costa de Marfil, Côte d"Ivoire", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Costa Rica", "colón costarricense", "¢", "CRC", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Croacia", "kuna croata", "kn", "HRK", "lipa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Cuba", "peso cubano", "$", "CUP", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Curação", "florín de las Antillas Neerlandesas", "ƒ", "ANG", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Dinamarca", "corona danesa", "kr", "DKK", "øre", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Ecuador", "dólar estadounidense", "$", "USD", "Centavos de dólar de Ecuador", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Egipto", "libra egipcia", "£, ?.?", "EGP", "piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "El Salvador", "colón salvadoreño", "¢", "SVC", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Emiratos Árabes Unidos", "dírham", "?.?", "AED", "fils", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Eritrea", "nakfa de Eritrea", "Nfk", "ERN", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Eslovaquia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Eslovenia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "España", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Estados Federados de Micronesia", "dólar micronesio", "$", "nen", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Estados Unidos", "dólar estadounidense", "$", "USD", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Estonia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Etiopía", "bir", "Br", "ETB", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Filipinas", "peso filipino", "?", "PHP", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Finlandia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Francia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Gabón", "franco CFA", "Fr", "XAF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Gambia", "dalasi gambiano", "D", "GMD", "butut", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Gana", "cedi de Gana", "?", "GHS", "pesewa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Georgia", "lari georgiano", "?", "GEL", "Tetri", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Gibraltar", "libra de Gibraltar", "£", "GIP", "penique", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Grecia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Guatemala", "quetzal", "Q", "GTQ", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Guinea", "franco guineano", "Fr", "GNF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Guinea Ecuatorial", "franco CFA", "Fr", "XAF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Guinea-Bisáu, Guinea Bissau", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Haití", "gurde", "G", "HTG", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Honduras", "lempira", "L", "HNL", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Hungria", "forinto", "Ft", "HUF", "filer", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "India", "rupia india", "?", "INR", "paisa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Indonesia", "rupia indonesia", "Rp", "IDR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Irak", "dinar irakí", "?.?", "IQD", "fils", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Irán", "rial iraní", "?", "IRR", "dinar", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Irlanda", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Islandia", "corona islandesa", "kr", "ISK", "eyrir", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Islas Caimán", "dólar de las Islas Caimán", "$", "KYD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Islas Salomón", "dólar salomonense", "$", "SBD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Israel", "nuevo séquel", "?", "ILS", "agora", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Italia", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Jamaica", "dólar jamaicano", "$", "JMD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Japón", "yen", "¥", "JPY", "sen", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Jordania", "dinar jordano", "?.?", "JOD", "piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Kazajistán, Kazajstán", "tengue kazajo", "?", "KZT", "tiyin", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Kenia, Kenya", "chelín keniano", "Sh", "KES", "cñentimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Kirguzistán", "som kirguís", "??", "KGS", "tyiyn", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Kuwait", "dinar kuwaití", "?.?", "KWD", "fils", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Laos", "kip", "?", "LAK", "att", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Lesoto, Lesotho", "loti de Lesoto", "L", "LSL", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Letonia", "lats", "Ls", "LVL", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Líbano", "libra libanesa", "?.?", "LBP", "piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Liberia", "dólar liberiano", "$", "LRD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Libia", "dinar libio", "?.?", "LYD", "dírham", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Lituania", "litas", "Lt", "LTL", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Luxemburgo", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Macao", "pataca de Macao", "P", "MOP", "avo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Macedonia", "denar", "???", "MKD", "deni", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Madagascar", "ariari", "Ar", "MGA", "iraimbilanja", "5");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Malasia", "ringit", "RM", "MYR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Malaui, Malawi", "kuacha de Malaui", "MK", "MWK", "tambala", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Maldivas", "rufiya", ".?", "MVR", "laari", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mali", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Malta", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Marruecos", "dírham", "?.?.", "MAD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mauricio", "rupia de Mauricio", "?", "MUR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mauritania", "uguiya", "UM", "MRO", "jum", "5");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "México", "peso mexicano", "$", "MXN", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Moldavia", "leu moldavo", "L", "MDL", "ban", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mónaco", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mongolia", "tugrik mongol", "?", "MNT", "möngö", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Montenegro", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Mozambique", "metical", "MT", "MZN", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Namibia", "dólar de Namibia", "$", "NAD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nauru", "dólar nauruano", "$", "Nen", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nepal", "rupia nepalí", "?", "NPR", "paisa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nicaragua", "córdoba nicaragüense", "C$", "NIO", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Níger", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nigeria", "naira nigeriano", "?", "NGN", "kobo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Noruega", "corona noruega", "kr", "NOK", "øre", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nueva Caledonia", "franco CFP", "Fr", "XPF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Nueva Zelanda", "dólar de Nueva Zelanda", "$", "NZD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Omán", "rial de Omán", "?.?.", "OMR", "baisa", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Países Bajos", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Panamá", "balboa panameño", "B/.", "PAB", "centésimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Papua-Nueva Guiné", "kina", "K", "PGK", "toea", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Paquistán", "rupia pakistaní", "?", "PKR", "paisa", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Paraguay", "guaraní paraguayo", "?", "PYG", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Perú", "nuevo sol peruano", "S/.", "PEN", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Polinesia Francesa", "franco CFP", "Fr", "XPF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Polonia", "zlóti", "zl", "PLN", "grosz", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Portugal", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Reino Unido", "libra esterlina", "£", "GBP", "penique", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "República Centroafricana", "franco CFA", "Fr", "XAF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "República Checa", "corona checa", "Kc", "CZK", "halér", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "República del Congo", "franco CFA", "Fr", "XAF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "República Democrática del Congo", "franco congoleño", "Fr", "CDF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "República Dominicana", "peso dominicano", "$", "DOP", "centavo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Ruanda, Rwanda", "franco ruandés", "Fr", "RWF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Rumanía", "leu rumano", "L", "RON", "ban", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Rusia", "rublo", "?", "RUB", "kopek", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Samoa", "tala", "T", "WST", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "San Cristóbal y Nieves, Saint Kitts y Nevis", "dólar del Caribe Oriental", "$", "XCD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "San Marino", "euro", "€", "EUR", "cent", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "San Viccente y las Granadinas", "dólar del Caribe Oriental", "$", "XCD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Santa Lucía", "dólar del Caribe Oriental", "$", "XCD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Santo Tomé y Príncipe", "dobra", "Db", "STD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Seichelles", "rupia seychellense", "?", "SCR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Senegal", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Serbia", "dinar serbio", "din", "RSD", "para", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Sierra Leona", "leona", "Le", "SLL", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Singapur", "dólar singapurense", "$", "SGD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Siria", "libra siria", "£ o ?.?", "SYP", "Piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Somalia", "chelín somalí", "Sh", "SOS", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Sri Lanka", "rupia ceilandesa", "Rs", "LKR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Suazilandia, Swazilandia", "lilangeni", "L", "SZL", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Sudáfrica", "rand", "R", "ZAR", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Sudán", "libra sudanesa", "£", "SDG", "piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Sudán del Sur", "libra sursudanesa", "£", "SSP", "piastra", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Suecia", "corona sueca", "kr", "SEK", "öre", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Suiza", "franco suizo", "Fr", "CHF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Surinám", "dólar surinamés", "$", "SRD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Tailandia", "bat", "?", "THB", "satang", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Taiwán", "nuevo dólar de Taiwán", "$", "TWD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Tanzania", "chelín tanzaniano", "Sh", "TZS", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Tayikistán", "somoni", "??", "TJS", "dirame", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Togo", "franco CFA", "Fr", "XOF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Tonga", "paanga", "T$", "TOP", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Trindade e Tobago", "dólar trinitense", "$", "TTD", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Túnez", "dinar tunecino", "?.?", "TND", "milésimo", "1000");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Turkmenistán", "manat turcomano", "m", "TMT", "tennesi", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Ucrania", "grivna", "?", "UAH", "kopiyka", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Uganda", "chelín ugandés", "Sh", "UGX", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Uruguay", "peso uruguayo", "$", "UYU", "centésimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Uzbequistán", "sum", "??", "UZS", "tiyin", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Vanuatu", "vatu do Vanuatu", "Vt", "VUV", "Nen", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Venezuela", "bolívar fuerte", "Bs F", "VEF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Vietnam", "dong", "?", "VND", "hào", "10");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Yemen", "rial yemení", "?", "YER", "fils", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Yibuti, Djibouti", "franco yibutiano", "Fr", "DJF", "céntimo", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Zambia", "kuacha zambiano", "ZK", "ZMK", "Ngwee", "100");
        //        await monedaMg.AgregaMoneda(listaDeMonedas, "Zimbabue, Zimbabwe", "dólar zimbabuense", "$", "ZWL", "céntimo", "100");

        //        await _context.Monedas.AddRangeAsync(listaDeMonedas);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public void CreaTmpPais()
        {


            //name: "pais",
            //    columns: table => new
            //    {
            //        paisid = table.Column<int>(nullable: false),
            //        nombre = table.Column<string>(maxLength: 150, nullable: false),
            //        nombre_completo = table.Column<string>(maxLength: 150, nullable: false),
            //        continente = table.Column<string>(maxLength: 20, nullable: false),
            //        iso2 = table.Column<string>(maxLength: 4, nullable: false),
            //        iso3 = table.Column<string>(maxLength: 4, nullable: false),
            //        iso3166 = table.Column<string>(maxLength: 4, nullable: true),
            //        cia = table.Column<string>(maxLength: 10, nullable: false),
            //        telefono = table.Column<string>(maxLength: 20, nullable: false),
            //        internet = table.Column<string>(maxLength: 4, nullable: false),
            //        vehiculo = table.Column<string>(maxLength: 10, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_pais", x => x.paisid);
            //    });
          

        }
       
    }


}
