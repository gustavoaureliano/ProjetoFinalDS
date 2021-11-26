using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDS.model
{
    class Categoria
    {

        int idCategoria;
        int idColecao;
        String nome;

        public int getIdCategoria()
        {
            return idCategoria;
        }

        public void setIdCategoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }

        public int getIdColecao()
        {
            return idCategoria;
        }

        public void setIdColecao(int idColecao)
        {
            this.idColecao = idColecao;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

    }
}
