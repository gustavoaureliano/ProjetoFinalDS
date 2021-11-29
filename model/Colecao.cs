using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDS.model
{
    public class Colecao
    {

        int idColecao;
        int idUsuario;
        String nome;
        String descricao;
        Image imagem;
        DateTime dataCriacao;
        DateTime dataAlteracao;

        public int getIdColecao()
        {
            return idColecao;
        }

        public void setIdColecao(int idColecao)
        {
            this.idColecao = idColecao;
        }

        public int getIdUsuario()
        {
            return idUsuario;
        }

        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getDescricao()
        {
            return descricao;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        public Image getImagem()
        {
            return imagem;
        }

        public void setImagem(Image imagem)
        {
            this.imagem = imagem;
        }

        public DateTime getDataCricao()
        {
            return dataCriacao;
        }

        public void setDataCricao(DateTime dataCricao)
        {
            this.dataCriacao = dataCricao;
        }

        public DateTime getDataAlteracao()
        {
            return dataAlteracao;
        }

        public void setDataAlteracao(DateTime dataAlteracao)
        {
            this.dataAlteracao = dataAlteracao;
        }

    }
}
