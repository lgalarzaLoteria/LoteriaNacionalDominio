﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaNacionalDominio
{
    public  class ComprobanteExternoAdmDTO
    {
        public class ComprobantesLeidosDTO
        {
            public string? FechaComprobanteEnviado { get; set; }
            public int? IdPuntoOperacion { get; set; }
            public string? UsuarioExt { get; set; }
            public string? ClaveExt { get; set; }
            public string? FacturasJson { get; set; }
        }

        public class ObtenerTokenDTO
        {
            public string? TokenObtenido { get; set; }
            
        }

        public class UsuarioExternoDTO
        {
            public string? username { get; set; }
            public string? password { get; set; }

        }

        public class ComprobanteExternoDTO
        {

            public string? username { get; set; }

            public string? password { get; set; }

            public string? facturasTramaJson { get; set; }


        }


    }
}
