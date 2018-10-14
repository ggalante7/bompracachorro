using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bomPraCachorro.Models
{
    public class Pontos
    {
        [Key]
        public int PontoId { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        [ForeignKey("TipoPontos")]
        public TipoPontos TipoPonto { get; set; }
        [ForeignKey("Usuarios")]
        public Usuarios UserId { get; set; }
    }
    public class TipoPontos
    {
        [Key]
        public int TipoId { get; set; }
        public string ImagemTipo { get; set; }
        public string Descricao { get; set; }
    }
}
