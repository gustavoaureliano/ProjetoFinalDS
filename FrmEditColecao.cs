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
    public partial class FrmEditColecao : Form
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
        public FrmEditColecao(Usuario usuario, Colecao colecao)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colecao = colecao;
        }
        private void FrmEditColecao_Load(object sender, EventArgs e)
        {
            lblNome.Text = "Editar - " + colecao.getNome();
            txtNome.Text = colecao.getNome();
            txtDescricao.Text = colecao.getDescricao();
            pbImagem.Image = colecao.getImagem();
            pbImagem.AllowDrop = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => abrirAlterarColecoes(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmEditColecao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
                colecao.setImagem(img);
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
                colecao.setImagem(img);
            }
        }

        private void pbImagem_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            colecao.setNome(txtNome.Text);
            colecao.setDescricao(txtDescricao.Text);
            ColecaoDAO colecaoDAO = new ColecaoDAO();
            colecaoDAO.atualizar(colecao);
            this.Close();
            t1 = new Thread(() => abrirAlterarColecoes(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirAlterarColecoes(Usuario usuario)
        {
            Application.Run(new FrmAltColecao(usuario));
        }
    }
}
