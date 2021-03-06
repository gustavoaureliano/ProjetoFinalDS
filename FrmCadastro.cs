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
using System.Collections;
using System.Resources;

namespace ProjetoFinalDS
{
    public partial class FrmCadastro : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;
        Thread t2;

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            List<Image> imagens = new List<Image>();

            ResourceManager resources = Properties.Resources.ResourceManager;
            imagens.Add((Image)resources.GetObject("imagem_cadastro_1"));
            imagens.Add((Image)resources.GetObject("imagem_cadastro_2"));
            imagens.Add((Image)resources.GetObject("imagem_cadastro_3"));
            imagens.Add((Image)resources.GetObject("imagem_cadastro_4"));

            Random rand = new Random();
            int num = rand.Next(4);
            imagemLateral.Image = imagens[num];
            txtNome.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();
            Usuario usuario = new Usuario();

            String usu = txtUsuario.Text.Trim();
            String nome = txtNome.Text.Trim();
            String senha = txtSenha.Text.Trim();

            if (usu == "" || nome == "" || senha == "")
            {
                MessageBox.Show("Algo de errado não está certo \nAlgum espaço não foi preenchido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                usuario.setUsuario(txtUsuario.Text);
                usuario.setNome(txtNome.Text);
                usuario.setSenha(txtSenha.Text);

                int idUsuario = usuarioDao.cadastrarUsuario(usuario);
                usuario.setIdUsuario(idUsuario);

                usuarioDao = new UsuarioDAO();
                usuario = usuarioDao.buscar(usuario);
                this.Close();
                t1 = new Thread(() => abrirColecao(usuario));
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }

        }
        private void abrirColecao(Usuario usuario)
        {
            Application.Run(new FrmColecoes(usuario));
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCadastro_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(voltarHome);
            t1.Start();
        }

        private void voltarHome()
        {
            Application.Run(new FrmHome());
        }

        private void lblLinkLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirLog);
            t2.Start();
        }

        private void abrirLog()
        {
            Application.Run(new FrmLogin());
        }
    }
}
