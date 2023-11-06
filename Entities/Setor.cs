using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Models
{
    public class Setor
    {
        public int IdSetor { get; set; }
        public string? ApelidoSetor { get; set; }

        public Setor(int idSetor, string? apelidoSetor)
        {
            IdSetor = idSetor;
            ApelidoSetor = apelidoSetor;
        }

        public Setor(string? apelidoSetor)
        {
            ApelidoSetor = apelidoSetor;
        }
    }
}
