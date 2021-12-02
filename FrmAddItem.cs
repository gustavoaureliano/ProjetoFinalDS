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
    public partial class FrmAddItem : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;

        private Usuario usuario;
        private Item item;
        private Colecao colecao;

        public FrmAddItem(Usuario usuario, Colecao colecao)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colecao = colecao;
            item = new Item();
            item.setIdColecao(colecao.getIdColecao());
        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {
            pbImagemItem.AllowDrop = true;
            atualizarCategorias();
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

        private void FrmAddItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirColecao(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void abrirColecao(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmColecao(usuario, colecao));
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ItemDAO itemdao = new ItemDAO();

            item.setNome(txtNome.Text.ToString());
            item.setDescricao(txtDesc.Text.ToString());
            int idxCategoria = cbCategoria.SelectedIndex;
            Categoria categoria = ((List<Categoria>)cbCategoria.Tag)[idxCategoria];
            item.setIdCategoria(categoria.getIdCategoria());
            item.setImagem(pbImagemItem.Image);

            itemdao.incluir(item);
            this.Close();
            t1 = new Thread(() => abrirColecao(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnInserirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String URLFoto = dialog.FileName.ToString();
                Image img = Image.FromFile(URLFoto);

                pbImagemItem.ImageLocation = URLFoto;
                item.setImagem(img);
            }
        }

        private void pbImagemItem_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                String[] fileNames = (String[])data;
                Image img = Image.FromFile(fileNames[0]);

                pbImagemItem.Image = img;
                item.setImagem(img);
            }
        }

        private void pbImagemItem_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            FrmAddCategoria addCategoria = new FrmAddCategoria(colecao, cbCategoria);
            addCategoria.ShowDialog();
        }
    }
}
