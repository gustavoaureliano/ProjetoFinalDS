using MySql.Data.MySqlClient;
using ProjetoFinalDS.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDS.dao
{
    class CategoriaDAO
    {

        private MySqlConnection conn = ConexaoBD.obterConxao();

        public void incluir(Categoria categoria)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlInsert = "insert into categoria (idColecao, nome) values (@idColecao, @nome)";

                MySqlCommand command = new MySqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@idColecao", categoria.getIdColecao());
                command.Parameters.AddWithValue("@nome", categoria.getNome());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Categoria cadastrada com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
        }



        public void excluir(Categoria categoria)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlDelete = "delete from categoria where idCategoria = @idCategoria";

                MySqlCommand command = new MySqlCommand(sqlDelete, conn);
                command.Parameters.AddWithValue("@id", categoria.getIdCategoria());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Categoria excluída com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
        }

        public List<Categoria> buscarTodos()
        {
            List<Categoria> categorias = new List<Categoria>();
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelectAll = "select * from categoria";

                MySqlCommand command = new MySqlCommand(sqlSelectAll, conn);

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria();
                        categoria.setIdCategoria(int.Parse(reader["idCategoria"].ToString()));
                        categoria.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        categoria.setNome(reader["nome"].ToString());

                        categorias.Add(categoria);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
            return categorias;
        }

        public Categoria buscar(Categoria categoria)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelect = "select * from categoia where idCategoria = @idCategoria";

                MySqlCommand command = new MySqlCommand(sqlSelect, conn);
                command.Parameters.AddWithValue("@id", categoria.getIdCategoria());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        categoria.setIdCategoria(int.Parse(reader["idCategoria"].ToString()));
                        categoria.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        categoria.setNome(reader["nome"].ToString());
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
            return categoria;
        }

        public void atualizar(Categoria categoria)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlUpdate = "update categoria set idColecao = @idColecao, nome = @nome where idCategoria = @idCategoria";

                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                command.Parameters.AddWithValue("@idColecao", categoria.getIdColecao());
                command.Parameters.AddWithValue("@nome", categoria.getNome());
                command.Parameters.AddWithValue("@idCategoria", categoria.getIdCategoria());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Categoria atualizada com sucesso!");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
        }

    }
}
