using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoteriaNacionalDominio
{
    public class TombolaDTO
    {
        public class TbPremioWebTombolaDTO
        {
            public int COD_tbPremioWebTombola { get; set; }
            public string? TipoPremio { get; set; }
            public string? DescripcionPremio { get; set; }
            public decimal? ValorPremio { get; set; }
        }

        public class TbJuegoWebTombolaDTO
        {
            public int COD_tbJuegoWebTombola { get; set; }
            public string? DescripcionTombola { get; set; }
            public string? EstadoTombola { get; set; }
        }

        public class TbDisenoWebTombolaDTO
        {
            public int COD_tbDisenoWebTombola { get; set; }
            public int JuegoWebTombolaId { get; set; }
            public string? UrlSonido { get; set; }
            public int? VelocidadGiro { get; set; }
            public string? ImgCentralTombola { get; set; }
            public string? ColorFondoWebTombola { get; set; }
            public string? ColorRGBFondoWebTombola { get; set; }
        }

        public class TbDisenoPremioWebTombolaDTO
        {
            public int COD_tbDisenoPremioWebTombola { get; set; }
            public int JuegoWebTombolaId { get; set; }
            public int PremioWebTombolaId { get; set; }
            public int OrdenPremio { get; set; }
            public string? ColorPremio { get; set; }
            public string? ColorRGBPremio { get; set; }
            public string? EstadoPremio { get; set; }
        }
    }
}
