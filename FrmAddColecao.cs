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
    public partial class FrmAddColecao : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private Colecao colecao;

        public FrmAddColecao(Colecao colecao)
        {
            InitializeComponent();
            this.colecao = colecao;
        }

        private void FrmAddColecao_MouseMove(object sender, MouseEventArgs e)
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Colecao colecao = new Colecao();
            ColecaoDAO colecaodao = new ColecaoDAO();

            colecao.setNome(txtColec.Text.ToString());
            colecao.setDescricao(txtDesc.Text.ToString());
            colecao.setImagem(pbImagemColec.Image);

            colecaodao.atualizar(colecao);
        }

        private void btnInserirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(.jpg)|.jpg|PNG Files(.png)|.png|AllFiles(.)|.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String URLFoto = dialog.FileName.ToString();
                Image img = Image.FromFile(URLFoto);

                pbImagemColec.ImageLocation = URLFoto;
                colecao.setImagem(img);
            }
        }

        private void FrmAddColecao_Load(object sender, EventArgs e)
        {
            pbImagemColec.AllowDrop = true;
        }

        private void pbImagemColec_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                String[] fileNames = (String[])data;
                Image img = Image.FromFile(fileNames[0]);

                pbImagemColec.Image = img;
                colecao.setImagem(img);
            }
        }

        private void pbImagemColec_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
