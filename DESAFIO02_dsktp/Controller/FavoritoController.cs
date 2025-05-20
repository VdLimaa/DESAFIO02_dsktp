using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.Json;
using System.Net.Http;
using DESAFIO02_dsktp.Model;

namespace DESAFIO02_dsktp.Controller
{
    internal class FavoritoController
    {
        private static string connectionString = "Server=localhost\\SQLEXPRESS;Database=db_produtos;" + "Integrated Security=True;";

        public static void AdicionarFavorito(Produto produto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tb_produto (id, title, price, category) VALUES (@id, @title, @price, @category)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", produto.id);
                    cmd.Parameters.AddWithValue("@title", produto.title);
                    cmd.Parameters.AddWithValue("@price", produto.price);
                    cmd.Parameters.AddWithValue("@category", produto.category);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception($"Erro ao Adicionar o Produto: {e.Message}");
                }
        }
        public static List<Produto> ListarFavoritos()
        {
            List<Produto> lista = new List<Produto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM tb_produto";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Produto
                        {
                            id = (int)reader["id"],
                            title = reader["title"].ToString(),
                            price = (decimal)reader["price"],
                            category = reader["category"].ToString()
                        });
                    }
                }
            }

            return lista;
        }
    }
}
