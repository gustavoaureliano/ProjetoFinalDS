using ProjetoFinalDS.dao;
using ProjetoFinalDS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDS
{
    public partial class FrmAddCategoria : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Colecao colecao;
        private ComboBox cbCategoria;
        private Categoria categoria = new Categoria();

        public FrmAddCategoria(Colecao colecao, ComboBox cbCategoria)
        {
            InitializeComponent();
            this.colecao = colecao;
            this.cbCategoria = cbCategoria;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            atualizarCategorias();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbEditar.Checked)
            {
                btnExcluir.Enabled = true;
                categoria.setNome(txtNome.Text.ToString());
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                categoriaDAO.atualizar(categoria);
            }
            else
            {
                categoria.setIdColecao(colecao.getIdColecao());
                categoria.setNome(txtNome.Text.ToString());
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                categoriaDAO.incluir(categoria);
            }
            radioButton();
        }

        public void atualizarTxtNomes()
        {
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            List<Categoria> categorias = new List<Categoria>();
            Categoria catNull = new Categoria();
            catNull.setNome("Nenhuma");
            categorias.Add(catNull);
            categorias.AddRange(categoriaDAO.buscarTodos(colecao));

            txtNome.Items.Clear();
            txtNome.Tag = categorias;

            foreach (Categoria categoria in categorias)
            {
                txtNome.Items.Add(categoria);
            }
            txtNome.SelectedIndex = 1;
        }

        public void atualizarCategorias()
        {
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            List<Categoria> categorias = new List<Categoria>();
            Categoria catNull = new Categoria();
            catNull.setNome("Nenhuma");
            categorias.Add(catNull);
            categorias.AddRange(categoriaDAO.buscarTodos(colecao));

            cbCategoria.Items.Clear();
            cbCategoria.Tag = categorias;

            foreach (Categoria categoria in categorias)
            {
                cbCategoria.Items.Add(categoria);
            }
            cbCategoria.SelectedItem = catNull;
        }

        private void FrmAddCategoria_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void rbEditar_CheckedChanged(object sender, EventArgs e)
        {
            radioButton();
        }

        public void radioButton()
        {
            if (rbEditar.Checked)
            {
                btnExcluir.Enabled = true;
                atualizarTxtNomes();
            }
            else
            {
                btnExcluir.Enabled = false;
                txtNome.Items.Clear();
                txtNome.Text = "";
                txtNome.Focus();
            }
        }

        private void txtNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNome.SelectedIndex > -1)
            {
                categoria = (Categoria)txtNome.SelectedItem;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            categoriaDAO.excluir(categoria);
            atualizarTxtNomes();
        }
    }
}
