using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteAppMinimal.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;
    }

}
