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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDS
{
    public partial class FrmEditItem : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;

        private Usuario usuario;
        private Colecao colecao;
        private Item item;

        public FrmEditItem(Usuario usuario, Colecao colecao, Item item)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colecao = colecao;
            this.item = item;
        }

        private void FrmEditItem_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Editar - " + item.getNome();
            txtNome.Text = item.getNome();
            txtDescricao.Text = item.getDescricao();
            pbImagem.Image = item.getImagem();
            pbImagem.AllowDrop = true; 
            atualizarCategorias();
            List<Categoria> categorias = (List<Categoria>)cbCategoria.Tag;
            cbCategoria.SelectedItem = categorias.Find(categoria => categoria.getIdCategoria() == item.getIdCategoria());
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAlterarItem(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmEditItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pbImagem_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                String[] fileNames = (String[])data;
                pbImagem.ImageLocation = fileNames[0];
                Image img = Image.FromFile(fileNames[0]);
                item.setImagem(img);
            }
        }

        private void pbImagem_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            item.setNome(txtNome.Text);
            item.setDescricao(txtDescricao.Text);
            int idxCategoria = cbCategoria.SelectedIndex;
            Categoria categoria = ((List<Categoria>)cbCategoria.Tag)[idxCategoria];
            item.setIdCategoria(categoria.getIdCategoria());
            ItemDAO itemDAO = new ItemDAO();
            itemDAO.atualizar(item);
            this.Close();
            t1 = new Thread(() => abrirAlterarItem(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAlterarItem(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmAltItem(usuario, colecao));
        }

        private void btnInserirImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String file = dialog.FileName.ToString();
                pbImagem.ImageLocation = file;
                Image img = Image.FromFile(file);
                item.setImagem(img);
            }
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            FrmAddCategoria addCategoria = new FrmAddCategoria(colecao, cbCategoria);
            addCategoria.ShowDialog();
        }

        private void btnInserirImagem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String URLFoto = dialog.FileName.ToString();
                Image img = Image.FromFile(URLFoto);

                pbImagem.ImageLocation = URLFoto;
                item.setImagem(img);
            }
        }
    }
}
