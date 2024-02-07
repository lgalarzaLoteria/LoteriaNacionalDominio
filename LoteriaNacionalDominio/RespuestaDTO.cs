using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaNacionalDominio
{
    public class RespuestaDTO
    {
        private Int32 codigoError;
        private string mensajeError;
        private string body;
        public Int32 CodigoError { get => codigoError; set => codigoError = value; }
        public string? MensajeError { get => mensajeError; set => mensajeError = value; }
        public string Body { get => body; set => body = value; }

        public RespuestaDTO(Int32 codigoError, string mensajeError, string body)
        {
            this.codigoError = codigoError;
            this.mensajeError = mensajeError;
            this.body = body;
        }


    }
}
