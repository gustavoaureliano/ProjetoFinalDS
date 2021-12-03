using ProjetoFinalDS.dao;
using ProjetoFinalDS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDS
{
    public partial class FrmAltColecao : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;
        Thread t2;

        private Usuario usuario;
        public FrmAltColecao(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmAltColecao_Load(object sender, EventArgs e)
        {

            lvColecoes.View = View.SmallIcon;
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
            imgList.ImageSize = new Size(64, 64);

            ColecaoDAO colecaoDaO = new ColecaoDAO();

            int cont = 0;

            List<Colecao> colecoes = null;
            if (chave != null && chave.Length > 0)
            {
                colecoes = colecaoDaO.buscarTodos(usuario, chave);
            }
            else
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
            lvColecoes.SmallImageList = imgList;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
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

        private void FrmAltColecao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listarImgs(txtSearch.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Colecao colecao = (Colecao)lvColecoes.SelectedItems[0].Tag;
                t1 = new Thread(() => abrirEditarColecao(usuario, colecao));
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                this.Close();
            } 
            catch
            {

            }
            
        }

        private void abrirEditarColecao(Usuario usuario, Colecao colecao)
        {
            Application.Run(new FrmEditColecao(usuario, colecao));
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            String mensagem = "Tem certeza que deseja excluir a coleção?";

            try
            {
                if (MessageBox.Show(mensagem, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    Colecao colecao = (Colecao)lvColecoes.SelectedItems[0].Tag;
                    ColecaoDAO colecaoDAO = new ColecaoDAO();
                    colecaoDAO.excluir(colecao);
                    listarImgs(null);
                }
            }
            catch
            {

            }
        }

    }
}
