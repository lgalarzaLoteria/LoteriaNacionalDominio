namespace LoteriaNacionalDominio
{
    public class SeguridadDTO
    {
        public class LoginDTO
        {
            /// <summary>
            /// Usuario del comercio para acceder al sistema
            /// </summary>
            public string? UserName { get; set; }
            /// <summary>
            /// Clave del comercio para acceder al sistema (No debe ser encriptada)
            /// </summary>
            public string? Password { get; set; }
        }

        public class LoginRespuestaDTO
        {
            /// <summary>
            /// Usuario del comercio para acceder al sistema
            /// </summary>
            public string NombreUsuario { get; set; }
            
        }

        public class PermisosXPagina
        {
            public Int16 codigoPerfil { get; set; }
            public Int16 codigoPagina { get; set; }
            public string codigoUsuario { get; set; }
        }

        public class MenuDTO
        {
            public short codigoRol { get; set; }
            public string nombreRol { get; set; }
            public short codigoFuncion { get; set; }
            public string nombreFuncion { get; set; }
            public short codigoTransaccion { get; set; }
            public string nombreTransaccion { get; set; }
            public string urlPagina { get; set; }
            public bool codigoEstado { get; set; }
            public string descripcionEstado { get; set; }
            public string usuarioTransaccion { get; set; }
            public string equipoTransaccion { get; set; }
            public string opcion { get; set; }

        }

        public class FuncionDTO
        {
            public short codigoFuncion { get; set; }
            public string nombreFuncion { get; set; }
        }
    }
}
