using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDS.model
{
    class Usuario
    {

        int idUsuario;
        String usuario;
        String nome;
        String senha;
        Image imagem;

        public int getIdUsuario()
        {
            return idUsuario;
        }

        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getSenha()
        {
            return senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public Image getImagem()
        {
            return imagem;
        }

        public void setImagem(Image imagem)
        {
            this.imagem = imagem;
        }

    }
}
