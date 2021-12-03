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
    class ColecaoDAO
    {

        private MySqlConnection conn = ConexaoBD.obterConxao();

        public void incluir(Colecao colecao)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlInsert = "insert into colecao (idUsuario, nome, descricao, imagem) values (@idUsuario, @nome, @descricao, @imagem)";

                MySqlCommand command = new MySqlCommand(sqlInsert, conn);
                command.Parameters.AddWithValue("@idUsuario", colecao.getIdUsuario());
                command.Parameters.AddWithValue("@nome", colecao.getNome());
                command.Parameters.AddWithValue("@descricao", colecao.getDescricao());

                Image imagem = colecao.getImagem();

                byte[] imgByte = null;
                if (imagem != null)
                {
                    MemoryStream mstream = new MemoryStream();
                    imagem.Save(mstream, imagem.RawFormat);
                    mstream.Position = 0;

                    BinaryReader br = new BinaryReader(mstream);

                    imgByte = br.ReadBytes((int)mstream.Length);
                }

                command.Parameters.AddWithValue("@imagem", imgByte);

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Coleção cadastrada com sucesso!");
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



        public void excluir(Colecao colecao)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlDelete = "usp_excluirColecao";

                MySqlCommand command = new MySqlCommand(sqlDelete, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@idColecao", colecao.getIdColecao());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i >= 0)
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

        public List<Colecao> buscarTodos(Usuario usuario)
        {
            List<Colecao> colecoes = new List<Colecao>();
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelectAll = "select * from colecao where idUsuario = @idUsuario";

                MySqlCommand command = new MySqlCommand(sqlSelectAll, conn);
                command.Parameters.AddWithValue("@idUsuario", usuario.getIdUsuario());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Colecao colecao = new Colecao();
                        colecao.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        colecao.setIdUsuario(int.Parse(reader["idUsuario"].ToString()));
                        colecao.setNome(reader["nome"].ToString());
                        colecao.setDescricao(reader["descricao"].ToString());

                        byte[] img = null;

                        try
                        {
                            img = (byte[])(reader["imagem"]);
                        }
                        catch 
                        { 
                        
                        }

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            colecao.setImagem(imagem);
                        }

                        DateTime parsedDataAlteracao = DateTime.Parse(reader["data_alteracao"].ToString());
                        colecao.setDataAlteracao(parsedDataAlteracao);

                        DateTime parsedDataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                        colecao.setDataCricao(parsedDataCriacao);

                        colecoes.Add(colecao);
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show($"Erro: " + e.ToString());
                }
                finally
                {
                    ConexaoBD.fecharConexao();
                }

            }
            return colecoes;
        }

        public List<Colecao> buscarTodos(Usuario usuario, String chave)
        {
            List<Colecao> colecoes = new List<Colecao>();
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelectAll = "select * from colecao where idUsuario = @idUsuario and upper(nome) like @chave";

                MySqlCommand command = new MySqlCommand(sqlSelectAll, conn);
                command.Parameters.AddWithValue("@idUsuario", usuario.getIdUsuario());
                command.Parameters.AddWithValue("@chave", "%" + chave.ToUpper() + "%");

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Colecao colecao = new Colecao();
                        colecao.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        colecao.setIdUsuario(int.Parse(reader["idUsuario"].ToString()));
                        colecao.setNome(reader["nome"].ToString());
                        colecao.setDescricao(reader["descricao"].ToString());

                        byte[] img = null;

                        try
                        {
                            img = (byte[])(reader["imagem"]);
                        }
                        catch
                        {

                        }

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            colecao.setImagem(imagem);
                        }

                        DateTime parsedDataAlteracao = DateTime.Parse(reader["data_alteracao"].ToString());
                        colecao.setDataAlteracao(parsedDataAlteracao);

                        DateTime parsedDataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                        colecao.setDataAlteracao(parsedDataCriacao);

                        colecoes.Add(colecao);
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
            return colecoes;
        }

        public Colecao buscar(Colecao colecao)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelect = "select * from colecao where idColecao = @idColecao";

                MySqlCommand command = new MySqlCommand(sqlSelect, conn);
                command.Parameters.AddWithValue("@idColecao", colecao.getIdColecao());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        colecao.setIdColecao(int.Parse(reader["idColecao"].ToString()));
                        colecao.setIdUsuario(int.Parse(reader["idUsuario"].ToString()));
                        colecao.setNome(reader["nome"].ToString());
                        colecao.setDescricao(reader["descricao"].ToString());

                        byte[] img = null;

                        try
                        {
                            img = (byte[])(reader["imagem"]);
                        }
                        catch
                        {

                        }

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            colecao.setImagem(imagem);
                        }

                        DateTime parsedDataAlteracao = DateTime.Parse(reader["data_alteracao"].ToString());
                        colecao.setDataAlteracao(parsedDataAlteracao);

                        DateTime parsedDataCriacao = DateTime.Parse(reader["data_criacao"].ToString());
                        colecao.setDataAlteracao(parsedDataCriacao);
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
            return colecao;
        }

        public void atualizar(Colecao colecao)
        {
            if (conn.State == ConnectionState.Open)
            {
                //String sqlUpdate = "update colecao set nome = @nome, descricao = @descricao, imagem = @imagem where idColecao = @idColecao";
                String sqlUpdate = "usp_atualizarColecao";

                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nome", colecao.getNome());
                command.Parameters.AddWithValue("@descricao", colecao.getDescricao());

                Image imagem = colecao.getImagem();

                byte[] imgByte = null;
                if (imagem != null)
                {
                    MemoryStream mstream = new MemoryStream();
                    imagem.Save(mstream, imagem.RawFormat);
                    mstream.Position = 0;

                    BinaryReader br = new BinaryReader(mstream);

                    imgByte = br.ReadBytes((int)mstream.Length);
                }

                command.Parameters.AddWithValue("@imagem", imgByte);
                command.Parameters.AddWithValue("@idColecao", colecao.getIdColecao());

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Coleção atualizada com sucesso!");
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
