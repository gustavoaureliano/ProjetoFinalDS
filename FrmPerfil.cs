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
using ProjetoFinalDS.model;
using System.Resources;

namespace ProjetoFinalDS
{
    public partial class FrmPerfil : Form
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

        public FrmPerfil(Usuario usuario, Colecao colecao)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.colecao = colecao;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ResourceManager resources = Properties.Resources.ResourceManager;

            txtNome.Text = usuario.getNome();
            txtUsuario.Text = usuario.getUsuario();
            Image img = usuario.getImagem();
            if (img != null)
            {
                pbImagemPerfil.Image = img;
            }
            else
            {
                pbImagemPerfil.Image = (Image)resources.GetObject("usuario");
            }

            pbImagemPerfil.AllowDrop = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => AbirAnterior(usuario, colecao));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => AbrirHome(usuario));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirHome(Usuario usuario)
        {
            Application.Run(new FrmHome());
        }

        private void AbirAnterior(Usuario usuario, Colecao colecao)
        {
            if (colecao != null)
            {
                Application.Run(new FrmColecao(usuario, colecao));
            } else
            {
                Application.Run(new FrmColecoes(usuario));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();

            usuario.setNome(txtNome.Text.ToString());
            usuario.setUsuario(txtUsuario.Text.ToString());
            String senha = txtSenha.Text.ToString();
            if (senha != null && senha.Length > 0)
                usuario.setSenha(senha);
            usuario.setImagem(pbImagemPerfil.Image);

            usuarioDao.atualizar(usuario);
            this.Close();
            t1 = new Thread(() => AbirAnterior(usuario, colecao));
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

                pbImagemPerfil.ImageLocation = URLFoto;
                usuario.setImagem(img);
            }
        }

        private void pbImagemPerfil_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                String[] fileNames = (String[])data;
                Image img = Image.FromFile(fileNames[0]);
  
                pbImagemPerfil.Image = img;
                usuario.setImagem(img);
            }
        }

        private void pbImagemPerfil_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
