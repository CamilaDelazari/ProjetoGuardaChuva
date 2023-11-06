using ProjetoGuardaChuva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Repository.Interface
{
    public interface ISetorRepository
    {
        void Add(string setor);
        void Select(Setor setor);
    }
}
