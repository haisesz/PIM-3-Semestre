using Npgsql;
using System;
using static Tela_de_Login.Conexao;

namespace Tela_de_Login
{
    public class Chamado
    {
        public int EnviarChamado(int idFuncionario, string categoria, string titulo, string descricao)
        {
            string status = "Aberto";
            DateTime dataAbertura = DateTime.Now;

            using (var conexao = new NpgsqlConnection(ConexaoString))
            {
                conexao.Open();

                string query = @"
                    INSERT INTO chamado (data_abertura, status, id_funcionario, categoria, titulo, descricao)
                    VALUES (@data_abertura, @status, @id_funcionario, @categoria, @titulo, @descricao)
                    RETURNING id_chamado;
                ";

                using (var comando = new NpgsqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@data_abertura", dataAbertura);
                    comando.Parameters.AddWithValue("@status", status);
                    comando.Parameters.AddWithValue("@id_funcionario", idFuncionario);
                    comando.Parameters.AddWithValue("@categoria", categoria);
                    comando.Parameters.AddWithValue("@titulo", titulo);
                    comando.Parameters.AddWithValue("@descricao", descricao);

                    return (int)comando.ExecuteScalar();
                }
            }
        }
    }
}
