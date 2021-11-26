﻿using MySql.Data.MySqlClient;
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
    class UsuarioDAO
    {

        private MySqlConnection conn = ConexaoBD.obterConxao();

        public void cadastrarUsuario(Usuario usuario)
        {
            if (conn.State == ConnectionState.Open)
            {
                //String sqlInsert = "insert into usuario (usuario, nome, senha, foto) values (@usuario, @nome, @senha, @foto)";
                String sqlInsert = "usp_cadastrarUsuario";

                MySqlCommand command = new MySqlCommand(sqlInsert, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@usuario", usuario.getIdUsuario());
                command.Parameters.AddWithValue("@nome", usuario.getNome());
                command.Parameters.AddWithValue("@senha", usuario.getSenha());

                Image imagem = usuario.getImagem();

                MemoryStream mstream = new MemoryStream();
                imagem.Save(mstream, imagem.RawFormat);
                mstream.Position = 0;

                BinaryReader br = new BinaryReader(mstream);
                byte[] imgByte = null;

                imgByte = br.ReadBytes((int)mstream.Length);

                command.Parameters.AddWithValue("@foto", imgByte);

                try
                {
                    int i = command.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Usuario cadastrado com sucesso!");
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

        public Usuario buscar(Usuario usuario)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlSelect = "select * from usuario where idUsuario = @idUsuario";

                MySqlCommand command = new MySqlCommand(sqlSelect, conn);
                command.Parameters.AddWithValue("@idUsuario", usuario.getIdUsuario());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        usuario.setIdUsuario(int.Parse(reader["idUsuario"].ToString()));
                        usuario.setUsuario(reader["usuario"].ToString());
                        usuario.setNome(reader["nome"].ToString());
                        usuario.setSenha(reader["senha"].ToString());

                        byte[] img = (byte[])(reader["foto"]);

                        if (img != null)
                        {
                            MemoryStream mstream = new MemoryStream(img);
                            Image imagem = Image.FromStream(mstream);
                            usuario.setImagem(imagem);
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
            return usuario;
        }

        public void atualizar(Usuario usuario)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sqlUpdate = "update usuario set usuario = @usuario, nome = @nome, senha = @senha, foto = @foto where idUsuario = @idUsuario";

                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@usuario", usuario.getUsuario());
                command.Parameters.AddWithValue("@nome", usuario.getNome());
                command.Parameters.AddWithValue("@senha", usuario.getSenha());

                Image imagem = usuario.getImagem();

                MemoryStream mstream = new MemoryStream();
                imagem.Save(mstream, imagem.RawFormat);
                mstream.Position = 0;

                BinaryReader br = new BinaryReader(mstream);
                byte[] imgByte = null;

                imgByte = br.ReadBytes((int)mstream.Length);

                command.Parameters.AddWithValue("@foto", imgByte);
                command.Parameters.AddWithValue("@idUsuario", usuario.getIdUsuario());

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

        public bool verificarLogin(Usuario usuario)
        {
            bool status = false;
            if (conn.State == ConnectionState.Open)
            {
                String sqlLogin = "usp_login";

                MySqlCommand command = new MySqlCommand(sqlLogin, conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@usuario", usuario.getUsuario());
                command.Parameters.AddWithValue("@senha", usuario.getSenha());

                MySqlDataReader reader;

                try
                {
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        status = Convert.ToBoolean(int.Parse(reader[1].ToString()));
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
            return status;
        }

    }
}
