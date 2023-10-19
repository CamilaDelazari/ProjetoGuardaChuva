using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Models
{
    public class Medidas
    {
        public int IdEndereco { get; set; }
        public double Altura { get; set; }
        public double Base { get; set; }
        public double AnguloInclinacao { get; set; }

        public Medidas(int idEndereco, double altura, double @base, double anguloInclinacao)
        {
            IdEndereco = idEndereco;
            Altura = altura;
            Base = @base;
            AnguloInclinacao = anguloInclinacao;
        }

        public Medidas(double altura, double @base, double anguloInclinacao)
        {
            Altura = altura;
            Base = @base;
            AnguloInclinacao = anguloInclinacao;
        }
    }
}
