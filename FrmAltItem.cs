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
    public partial class FrmAltItem : Form
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

        public FrmAltItem(Usuario usuario, Colecao colecao)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colecao = colecao;
        }

        private void FrmAltItem_Load(object sender, EventArgs e)
        {
            lvItens.View = View.SmallIcon;
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
            imgList.ImageSize = new Size(64, 64);

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
            foreach (Item item in itens)
            {
                imgList.Images.Add(item.getImagem());
                ListViewItem lvItem = new ListViewItem(item.getNome(), cont);
                lvItem.Tag = item;
                lvItens.Items.Add(lvItem);
                cont++;
            }
            lvItens.SmallImageList = imgList;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirColecao(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirColecao(Usuario usuario)
        {
            Application.Run(new FrmColecao(usuario, colecao));
        }

        private void FrmAltItem_MouseMove(object sender, MouseEventArgs e)
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
            this.Close();
            Item item = (Item)lvItens.SelectedItems[0].Tag;
            t1 = new Thread(() => abrirEditarItem(usuario, colecao, item));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirEditarItem(Usuario usuario, Colecao colecao, Item item)
        {
            Application.Run(new FrmEditItem(usuario, colecao, item));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            String mensagem = "Tem certeza que deseja excluir o item?";

            try
            {
                if (MessageBox.Show(mensagem, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    Item item = (Item)lvItens.SelectedItems[0].Tag;
                    ItemDAO itemDAO = new ItemDAO();
                    itemDAO.excluir(item);
                    listarImgs(null);
                }
            }
            catch
            {

            }
        }
    }
}
