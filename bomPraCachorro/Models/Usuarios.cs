using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bomPraCachorro.Models
{
    public class Usuarios
    {
        [Key]
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Cel { get; set; }
        public int DDD { get; set; }
    }
}
