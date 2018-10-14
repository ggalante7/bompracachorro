using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bomPraCachorro.Models
{
    public class Animais
    {
        [Key]
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        [ForeignKey("Especies")]
        public Especies Especie { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        [ForeignKey("Usuarios")]
        public int UserId { get; set; }
    }
    public class Especies
    {
        [Key]
        public int EspecieId { get; set; }
        public string Descricao { get; set; }
    }
}
