using Npgsql;
using System;
using static Tela_de_Login.Conexao;

namespace Tela_de_Login
{
    public class Entrar
    {
        public (bool sucesso, Funcionario funcionario, string mensagem) Autenticar(string email, string senha)
        {
            try
            {
                using (var conexao = new NpgsqlConnection(ConexaoString))
                {
                    conexao.Open();

                    string query = @"
                        SELECT f.id_funcionario, f.nome, f.email, f.senha, d.nome AS departamento
                        FROM funcionario f
                        INNER JOIN departamento d ON f.id_departamento = d.id_departamento
                        WHERE f.email = @usuario AND f.senha = @senha";

                    using (var comando = new NpgsqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@usuario", email);
                        comando.Parameters.AddWithValue("@senha", senha);

                        using (var reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var funcionario = new Funcionario
                                {
                                    IdFuncionario = reader.GetInt32(reader.GetOrdinal("id_funcionario")),
                                    Nome = reader.GetString(reader.GetOrdinal("nome")),
                                    Email = reader.GetString(reader.GetOrdinal("email")),
                                    Senha = senha,
                                    Departamento = reader.GetString(reader.GetOrdinal("departamento"))
                                };

                                return (true, funcionario, "Login realizado com sucesso");
                            }
                            else
                            {
                                return (false, null, "Senha ou Email incorretos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, null, "Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
