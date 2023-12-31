﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using ProjetoGuardaChuva.Repository.Interface;
using ProjetoGuardaChuva.Models;
using System.Configuration.Provider;

namespace ProjetoGuardaChuva.Repository
{
    internal class EnderecoRepository : IEnderecoRepository
    {
        private string ConnectionString;
        private DbProviderFactory Factory;

        public EnderecoRepository(string connectionString, string providerName)
        {
            ConnectionString = connectionString;
            Factory = DbProviderFactories.GetFactory(providerName);
        }

        public void Add(Endereco endereco)
        {
            using (DbConnection connection = Factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                using (DbCommand command = Factory.CreateCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "INSERT INTO endereco (Cep, Rua, Bairro, Numero) VALUES (@Cep, @Rua, @Bairro, @Numero)";

                    DbParameter cepParam = command.CreateParameter();
                    cepParam.ParameterName = "@Cep";
                    cepParam.Value = endereco.Cep;
                    command.Parameters.Add(cepParam);

                    DbParameter ruaParam = command.CreateParameter();
                    ruaParam.ParameterName = "@Rua";
                    ruaParam.Value = endereco.Rua;
                    command.Parameters.Add(ruaParam);

                    DbParameter bairroParam = command.CreateParameter();
                    bairroParam.ParameterName = "@Bairro";
                    bairroParam.Value = endereco.Bairro;
                    command.Parameters.Add(bairroParam);

                    DbParameter numeroParam = command.CreateParameter();
                    numeroParam.ParameterName = "@Numero";
                    numeroParam.Value = endereco.Numero;
                    command.Parameters.Add(numeroParam);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Endereco endereco)
        {
            using (DbConnection connection = Factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                using (DbCommand command = Factory.CreateCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "UPDATE endereco SET Cep = @Cep, Rua = @Rua, Bairro = @Bairro, Numero = @Numero WHERE Id = @Id";

                    DbParameter idParam = command.CreateParameter();
                    idParam.ParameterName = "@Id";
                    idParam.Value = endereco.Id;
                    command.Parameters.Add(idParam);

                    DbParameter cepParam = command.CreateParameter();
                    cepParam.ParameterName = "@Cep";
                    cepParam.Value = endereco.Cep;
                    command.Parameters.Add(cepParam);

                    DbParameter ruaParam = command.CreateParameter();
                    ruaParam.ParameterName = "@Rua";
                    ruaParam.Value = endereco.Rua;
                    command.Parameters.Add(ruaParam);

                    DbParameter bairroParam = command.CreateParameter();
                    bairroParam.ParameterName = "@Bairro";
                    bairroParam.Value = endereco.Bairro;
                    command.Parameters.Add(bairroParam);

                    DbParameter numeroParam = command.CreateParameter();
                    numeroParam.ParameterName = "@Numero";
                    numeroParam.Value = endereco.Numero;
                    command.Parameters.Add(numeroParam);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Select(Endereco endereco)
        {
            using (DbConnection connection = Factory.CreateConnection())
            {
                connection.ConnectionString = ConnectionString;
                connection.Open();

                using (DbCommand command = Factory.CreateCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "SELECT * FROM endereco";

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
