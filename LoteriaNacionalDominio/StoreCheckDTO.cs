using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoteriaNacionalDominio
{
    public class StoreCheckDTO
    {
        public class RegistroFormularioDTO
        {
            public long? codigoRegistro { get; set; }
            public long? codigoFormulario { get; set; }
            public string? codigoComisionista { get; set; }
            public int? codigoPDS { get; set; }
            public short? codigoSeccion { get; set; }
            public string? nombreSeccion { get; set; }
            public short? codigoPregunta { get; set; }
            public string? descripcionPregunta { get; set; }
            public bool? respuesta { get; set; }
            public string? fechaRegistro { get; set; }
            public string? codigoSupervisor { get; set; }
            public bool? respuestaSupervisor { get; set; }
            public short? codigoNovedad { get; set; }
            public string? descripcionNovedad { get; set; }
            public string? fechaRevisionSupervisor { get; set; }
            public string? codigoJefeVentas { get; set; }
            public bool? respuestaJefeVentas { get; set; }
            public string? fechaRevisionJefeVentas { get; set; }
            public string? usuarioCreacion { get; set; }
            public DateTime? fechaCreacion { get; set; }
            public string? equipoCreacion { get; set; }
            public string? usuarioModificacion { get; set; }
            public DateTime? fechaModificacion { get; set; }
            public string? equipoModificacion { get; set; }

        }

        public class RegistroDTO
        {
            public List<RegistroFormularioDTO> registro { get; set; }
            public string? evidenciaRevision { get; set; }
            public decimal? latitudEvidencia { get; set; }
            public decimal? longitudEvidencia { get; set; }
            public string direccionEvidencia { get; set; }
        }

        public class ZonasPorSupervisorDTO
        {
            public int? codigoZona { get; set; }
            public string? nombreZona { get; set; }
            public int? codigoJefeComercial { get; set; }
            public string? nombreJefeComercial { get; set; }
            public int? codigoSupervisor { get; set; }
            public string? nombreSupervisor { get; set; }
            public int? codigoPDS { get; set; }
            public string? nombrePDS { get; set; }
            public int? CuestionariosPendientes { get; set; }
            
        }

        public class FormulariosporPOSDTO
        {
            public long? codigoFormulario { get; set; }
            public string? fechaRegistro { get; set; }

        }

        public class ResumenGerencialZonasDTO
        {
            public int codigoZona { get; set; }
            public string nombreZona { get; set; }
            public int codigoSupervisor { get; set; }
            public string nombreSupervisor { get; set; }
            public int codigoPDS { get; set; }
            public string nombrePDS { get; set; }
            public int CuestionariosNovedades { get; set; }
        }

        public class CalificacionCuestionariosPDSDTO
        {
            public int codigoPDS { get; set; }
            public string nombrePDS { get; set; }
            public int codigoFormulario { get; set; }
            public decimal porcentajeCumplimiento { get; set; }
        }

        public class RankingCumplimientoPDSDTO
        {
            public int grupo { get; set; }
            public string cantidadPDS { get; set; }
            public string codigoUsuario { get; set; }
            public string tipoConsulta { get; set; }
            public string? leyendaRango { get; set; }
        }

        public class TiempoRevisionDTO
        {
            public int codigoUsuario { get; set; }
            public string nombreUsuario { get; set; }
            public int revisadosATiempo { get; set; }
            public int revisadosConAtraso { get; set; }
        }

        public class GeolocalizacionDTO
        {

            public long? secuencial { get; set; }
            public int? codigoPDS { get; set; }
            public decimal? latitudPDS { get; set; }
            public decimal? longitudPDS { get; set; }
            public string direccionPDS { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

    }
}
