using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDS.model
{
    public class Item
    {

        private int idItem;
        private int idColecao;
        private int idCategoria;
        private String nome;
        private string descricao;
        private Image imagem;

        public int getIdItem()
        {
            return idItem;
        }

        public void setIdItem(int idItem)
        {
            this.idItem = idItem;
        }

        public int getIdColecao()
        {
            return idColecao;
        }

        public void setIdColecao(int idColecao)
        {
            this.idColecao = idColecao;
        }

        public int getIdCategoria()
        {
            return idCategoria;
        }

        public void setIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
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
        
    }
}
