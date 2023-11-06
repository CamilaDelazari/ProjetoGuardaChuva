using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int IdSetor { get; set; }

        public Endereco(int id, int cep, string rua, string bairro, int numero, int idSetor)
        {
            Id = id;
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            IdSetor = idSetor;
        }

        public Endereco(int cep, string rua, string bairro, int numero)
        {
            Cep = cep;
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
        }
    }
}
