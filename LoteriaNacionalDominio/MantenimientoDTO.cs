using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaNacionalDominio
{
    public class MantenimientoDTO
    {
        public class SeccionesDTO
        {
            public short? codigoSeccion { get; set; }
            public string? nombreSeccion { get; set; }
            public short? porcentajeCalificacion { get; set; }
            public bool? estadoSeccion { get; set; }
            public string? descripcionEstadoSeccion { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class PreguntasDTO
        {
            public short? codigoPregunta { get; set; }
            public short codigoSeccion { get; set; }
            public string? descripcionPregunta { get; set; }
            public string? conceptoPregunta { get; set; }
            public DateTime? vigenciaDesde { get; set; }
            public DateTime? vigenciaHasta { get; set; }
            public bool? estadoPregunta { get; set; }
            public string? descripcionEstadoPregunta { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
            public bool? repuestaPregunta { get; set; }
            public int? respuestaMarcada { get; set; }

        }

        public class NovedadesDTO
        {
            public short? codigoNovedad { get; set; }
            public string? descripcionNovedad { get; set; }
            public bool? estadoNovedad { get; set; }
            public string? descripcionEstadoNovedad { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class AplicacionDTO
        {
            public short? codigoAplicacion { get; set; }
            public string? nombreAplicacion { get; set; }
            public bool? estadoAplicacion { get; set; }
            public string? descripcionEstadoAplicacion { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class BaseDTO
        {
            public short? codigoBase { get; set; }
            public string? nombreBase { get; set; }
            public bool? estadoBase { get; set; }
            public string? descripcionEstadoBase { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class ProcesoDTO
        {
            public short? codigoProceso { get; set; }
            public short? codigoAplicacion { get; set; }
            public string? descripcionProceso { get; set; }
            public string? nombreJob { get; set; }
            public short? codigoBase { get; set; }
            public short? frecuenciaEjecucion { get; set; }
            public string? diasEspecificosEjecucion { get; set; }
            public string? horaEjecucion { get; set; }
            public string? tiempoPromedioEjecucion { get; set; }
            public string? responsable1 { get; set; }
            public string? responsable2 { get; set; }
            public string? informacionRevisar { get; set; }
            public bool? estadoProceso { get; set; }
            public string? descripcionEstadoBase { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class JefeZonalDTO
        {
            public short? codigoJefeComercial { get; set; }
            public string? nombreJefeComercial { get; set; }
            public int? codigoZona { get; set; }
            public bool? estadoJefeComercial { get; set; }
            public string? descripcionEstadoJefeComercial { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class ElementosTIDTO
        {
            public short? codigoElementoIT { get; set; }
            public string? nombreElementoIT { get; set; }
            public bool? estadoElementoIT { get; set; }
            public string? descripcionEstadoElementoTI { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

    }
}
