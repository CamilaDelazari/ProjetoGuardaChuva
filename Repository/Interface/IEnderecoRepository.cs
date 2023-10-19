using ProjetoGuardaChuva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Repository.Interface
{
    public interface IEnderecoRepository
    {
        void Add(Endereco endereco);
        void Update(Endereco endereco);
        void Select(Endereco endereco);
    }
}
