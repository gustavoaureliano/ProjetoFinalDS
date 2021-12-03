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
using System.Threading;
using ProjetoFinalDS.dao;
using System.Resources;

namespace ProjetoFinalDS
{
    public partial class FrmColecoes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;

        private Usuario usuario;
        public FrmColecoes(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void FrmColecoes_Load(object sender, EventArgs e)
        {
            ResourceManager resources = Properties.Resources.ResourceManager;
            
            txtNomeUsuario.Text = usuario.getNome();
            Image img = usuario.getImagem();
            if (img != null)
            {
                pbUsuario.Image = img;
            }
            else
            {
                pbUsuario.Image = (Image)resources.GetObject("usuario");
            }

            lvColecoes.View = View.LargeIcon;
            lvColecoes.FullRowSelect = true;
            lvColecoes.AllowDrop = true;
            lvColecoes.Sorting = SortOrder.Ascending;

            lvColecoes.Columns.Add("Coleções", 100);
            lvColecoes.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            listarImgs(null);
        }
        public void listarImgs(String chave)
        {

            lvColecoes.Items.Clear();

            ImageList imgList = new ImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            imgList.ImageSize = new Size(200, 200);

            ColecaoDAO colecaoDaO = new ColecaoDAO();

            int cont = 0;

            List<Colecao> colecoes = null;
            if (chave != null && chave.Length > 0)
            {
                colecoes = colecaoDaO.buscarTodos(usuario, chave);
            } else
            {
                colecoes = colecaoDaO.buscarTodos(usuario);
            }

            ResourceManager resources = Properties.Resources.ResourceManager;

            foreach (Colecao colecao in colecoes)
            {
                Image img = colecao.getImagem();
                if (img != null)
                    imgList.Images.Add(colecao.getImagem());
                else
                {
                    imgList.Images.Add((Image)resources.GetObject("sem_foto"));
                }
                ListViewItem item = new ListViewItem(colecao.getNome(), cont);
                item.Tag = colecao;
                lvColecoes.Items.Add(item);
                cont++;
            }
            lvColecoes.LargeImageList = imgList;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmColecoes_MouseMove(object sender, MouseEventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listarImgs(txtSearch.Text);
        }

        private void lvColecoes_Click(object sender, EventArgs e)
        {
            try
            {
                Colecao colecao = (Colecao) lvColecoes.SelectedItems[0].Tag;
                this.Close();
                t1 = new Thread(() => abriColecao(usuario, colecao));
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            } catch
            {

            }
        }

        private void abriColecao(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmColecao(usuario, colecao));
        }

        private void btnAlterarColecao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAlterarColecao(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAlterarColecao(Usuario usuario)
        {
            Application.Run(new FrmAltColecao(usuario));
        }

        private void btnAdicionarColecao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAddColecao(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAddColecao(Usuario usuario)
        {
            Application.Run(new FrmAddColecao(usuario));
        }

        private void pbUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirPerfil(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirPerfil(Usuario usuario)
        {
            Application.Run(new FrmPerfil(usuario, null));
        }
    }
}
