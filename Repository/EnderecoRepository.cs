using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoGuardaChuva.Repository.Interface;
using ProjetoGuardaChuva.Models;

namespace ProjetoGuardaChuva.Repository
{
    internal class EnderecoRepository : IEnderecoRepository
    {
        private string ConnectionString;

        public EnderecoRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Add(Endereco endereco)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO endereco (Cep, Rua, Bairro, Numero) VALUES (@Cep, @Rua, @Bairro, @Numero)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Cep", endereco.Cep);
                    command.Parameters.AddWithValue("@Rua", endereco.Rua);
                    command.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@Numero", endereco.Numero);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Endereco endereco)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Usuarios SET Cep = @Cep, Rua = @Rua, Bairro = @Bairro, Numero = @Numero WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", endereco.Cep);
                    command.Parameters.AddWithValue("@Cep", endereco.Cep);
                    command.Parameters.AddWithValue("@Rua", endereco.Rua);
                    command.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@Numero", endereco.Numero);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Select(Endereco endereco)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Usuarios SET Cep = @Cep, Rua = @Rua, Bairro = @Bairro, Numero = @Numero WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", endereco.Cep);
                    command.Parameters.AddWithValue("@Cep", endereco.Cep);
                    command.Parameters.AddWithValue("@Rua", endereco.Rua);
                    command.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@Numero", endereco.Numero);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
