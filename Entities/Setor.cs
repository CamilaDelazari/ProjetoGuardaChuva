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
        public int IdEndereco { get; set; }
        public string ApelidoSetor { get; set; }

        public Setor(int idSetor, int idEndereco, string apelidoSetor)
        {
            IdSetor = idSetor;
            IdEndereco = idEndereco;
            ApelidoSetor = apelidoSetor;
        }
    }
}
