using ProjetoGuardaChuva.Models;
using ProjetoGuardaChuva.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGuardaChuva.Repository
{
    internal class SetorRepository : ISetorRepository
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["Banco"].ConnectionString;

        private DbProviderFactory Factory;

        public SetorRepository(string connectionString, string providerName)
        {
            ConnectionString = connectionString;
            Factory = DbProviderFactories.GetFactory(providerName);
        }

        public void Add(string apelidoSetor)
        {
            using (DbConnection connection = Factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                using (DbCommand command = Factory.CreateCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "INSERT INTO setor (ApelidoSetor) VALUES (@ApelidoSetor)";

                    DbParameter ApelidoSetorParam = command.CreateParameter();
                    ApelidoSetorParam.ParameterName = "@ApelidoSetor";
                    ApelidoSetorParam.Value = apelidoSetor;
                    command.Parameters.Add(ApelidoSetorParam);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Select(Setor setor)
        {
            using (DbConnection connection = Factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                using (DbCommand command = Factory.CreateCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM endereco WHERE Id = @IdSetor";

                    DbParameter IdSetorParam = command.CreateParameter();
                    IdSetorParam.ParameterName = "@IdSetor";
                    IdSetorParam.Value = setor.IdSetor;
                    command.Parameters.Add(IdSetorParam);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
