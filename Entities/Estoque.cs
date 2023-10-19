using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Models
{
    public class Estoque
    {
        public int IdItem { get; set; }
        public double Litragem { get; set; }

        public Estoque(int idItem, double litragem)
        {
            IdItem = idItem;
            Litragem = litragem;
        }
    }
}
