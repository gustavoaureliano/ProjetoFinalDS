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
using System.Threading;
using ProjetoFinalDS.model;
using ProjetoFinalDS.dao;
using System.Resources;

namespace ProjetoFinalDS
{
    public partial class FrmColecao : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;

        private Colecao colecao;
        private Usuario usuario;

        public FrmColecao(Usuario usuario, Colecao colecao)
        {
            InitializeComponent();
            this.colecao = colecao;
            this.usuario = usuario;
        }

        private void FrmColecao_Load(object sender, EventArgs e)
        {
            ResourceManager resources = Properties.Resources.ResourceManager;

            txtNome.Text = usuario.getNome();
            Image img = usuario.getImagem();
            if (img != null)
            {
                pbUsuario.Image = img;
            }
            else
            {
                pbUsuario.Image = (Image)resources.GetObject("usuario");
            }

            pbUsuario.Image = usuario.getImagem();
            lblNomeColecao.Text = "Coleção - " + colecao.getNome();
            String dataFormat = "d";
            txtDataAlteracao.Text = colecao.getDataAlteracao().ToString(dataFormat);
            txtDataCriacao.Text = colecao.getDataCricao().ToString(dataFormat);

            lvItens.View = View.LargeIcon;
            lvItens.FullRowSelect = true;
            lvItens.AllowDrop = true;
            lvItens.Sorting = SortOrder.Ascending;

            lvItens.Columns.Add("Itens", 100);
            lvItens.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            listarImgs(null);
        }

        public void listarImgs(String chave)
        {

            lvItens.Items.Clear();

            ImageList imgList = new ImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageSize = new Size(200, 200);

            ItemDAO itemDAO = new ItemDAO();

            int cont = 0;

            List<Item> itens = null;
            if (chave != null && chave.Length > 0)
            {
                itens = itemDAO.buscarTodos(colecao, chave);
            }
            else
            {
                itens = itemDAO.buscarTodos(colecao);
            }

            ResourceManager resources = Properties.Resources.ResourceManager;

            foreach (Item item in itens)
            {
                Image img = item.getImagem();
                if (img != null)
                    imgList.Images.Add(item.getImagem());
                else
                {
                    imgList.Images.Add((Image)resources.GetObject("sem_foto"));
                }
                ListViewItem lVItem = new ListViewItem(item.getNome(), cont);
                lVItem.Tag = item;
                lvItens.Items.Add(lVItem);
                cont++;
            }
            lvItens.LargeImageList = imgList;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listarImgs(txtSearch.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirColecoes(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmColecao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAcervoGeek_Click(object sender, EventArgs e)
        {
            t1 = new Thread(abriAcervo);
            t1.Start();
        }

        private void abriAcervo(Object obj)
        {
            Application.Run(new FrmAcervoGeek());
        }

        private void lvItens_Click(object sender, EventArgs e)
        {
            Item item = (Item)lvItens.SelectedItems[0].Tag;
            MessageBox.Show(item.getDescricao(), item.getNome());
        }

        private void btnDescColecao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colecao.getDescricao(), "Sobre " + colecao.getNome());
        }

        private void lblAbrirColecoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirColecoes(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirColecoes(Usuario usuario)
        {
            Application.Run(new FrmColecoes(usuario));
        }

        private void btnAlterarItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAlterarItem(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAlterarItem(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmAltItem(usuario, colecao));
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAddItem(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAddItem(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmAddItem(usuario, colecao));
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirPerfil(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirPerfil(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmPerfil(usuario, colecao));
        }
    }
}
