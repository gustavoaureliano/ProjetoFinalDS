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

        public FrmPerfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

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
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();

            usuario.setNome(txtNome.Text.ToString());
            usuario.setUsuario(txtUsuario.Text.ToString());
            usuario.setSenha(txtSenha.Text.ToString());
            usuario.setImagem(imagemPerfil.Image);

            usuarioDao.atualizar(usuario);
        }
    }
}
