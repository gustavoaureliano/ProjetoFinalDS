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
    class ItemDAO
    {

        private MySqlConnection conn = ConexaoBD.obterConxao();

        public void incluir(Item item)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlInsert = "insert into item (idColecao, idCategoria, nome, descricao, imagem) values (@idColecao, @idCategoria, @nome, @descricao, @imagem)";

                MySqlCommand command = new MySqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@idColecao", item.getIdColecao());
                command.Parameters.AddWithValue("@idCategoria", item.getIdCategoria());
                command.Parameters.AddWithValue("@nome", item.getNome());
                command.Parameters.AddWithValue("@descricao", item.getDescricao());

                Image imagem = item.getImagem();

                MemoryStream mstream = new MemoryStream();
                imagem.Save(mstream, imagem.RawFormat);
                mstream.Position = 0;

                BinaryReader br = new BinaryReader(mstream);
                byte[] imgByte = null;

                imgByte = br.ReadBytes((int)mstream.Length);

                command.Parameters.AddWithValue("@imagem", imgByte);

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Item cadastrado com sucesso!");
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



        public void excluir(Item item)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlDelete = "delete from item where idItem = @idItem";

                MySqlCommand command = new MySqlCommand(sqlDelete, conn);
                command.Parameters.AddWithValue("@idItem", item.getIdItem());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Coleção excluída com sucesso!");
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

        public List<Item> buscarTodos()
        {
            List<Item> itens = new List<Item>();
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelectAll = "select * from item";

                MySqlCommand command = new MySqlCommand(sqlSelectAll, conn);

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Item item = new Item();
                        item.setIdItem(int.Parse(reader["idItem"].ToString()));
                        item.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        item.setIdCategoria(int.Parse(reader["idCategoria"].ToString()));
                        item.setNome(reader["nome"].ToString());
                        item.setDescricao(reader["descricao"].ToString());

                        byte[] img = (byte[])(reader["imagem"]);

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            item.setImagem(imagem);
                        }

                        itens.Add(item);
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
            return itens;
        }

        public Item buscar(Item item)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelect = "select * from item where idItem = @idItem";

                MySqlCommand command = new MySqlCommand(sqlSelect, conn);
                command.Parameters.AddWithValue("@idItem", item.getIdItem());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        item.setIdItem(int.Parse(reader["idItem"].ToString()));
                        item.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        item.setIdCategoria(int.Parse(reader["idCategoria"].ToString()));
                        item.setNome(reader["nome"].ToString());
                        item.setDescricao(reader["descricao"].ToString());

                        byte[] img = (byte[])(reader["imagem"]);

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            item.setImagem(imagem);
                        }
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
            return item;
        }

        public void atualizar(Item item)
        {
            if (conn.State == ConnectionState.Open)
            {
                //String sqlUpdate = "update item set idCategoria = @idCategoria, nome = @nome, descricao = @descricao, imagem = @imagem where idColecao = @idColecao";
                String sqlUpdate = "usp_atualizarItem";

                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idCategoria", item.getIdCategoria());
                command.Parameters.AddWithValue("@nome", item.getNome());
                command.Parameters.AddWithValue("@descricao", item.getDescricao());

                Image imagem = item.getImagem();

                MemoryStream mstream = new MemoryStream();
                imagem.Save(mstream, imagem.RawFormat);
                mstream.Position = 0;

                BinaryReader br = new BinaryReader(mstream);
                byte[] imgByte = null;

                imgByte = br.ReadBytes((int)mstream.Length);

                command.Parameters.AddWithValue("@imagem", imgByte);
                command.Parameters.AddWithValue("@idItem", item.getIdColecao());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Colecao atualizada com sucesso!");
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
