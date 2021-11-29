﻿using System;
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

namespace ProjetoFinalDS
{
    public partial class FrmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Thread t1;

        public FrmLogin()
        {
            InitializeComponent();

            ArrayList imagens = new ArrayList();
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\imagem login 7.jpg");
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\imagem login 5.jpg");
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\imagem login 1.jpg");
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\imagem login 2.png");
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\imagem login 3.jpg");
            imagens.Add(@"H:\Imagens\Projeto Final DS\com tamanho certo\login gon.jpg");


            Random rand = new Random();
            int num = rand.Next(6);
            imagemLateral.Load("" + imagens[num]);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblLinkCadas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirCadastro);
            t1.Start();
        }

        private void abrirCadastro ()
        {
            Application.Run(new FrmCadastro());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(voltarHome);
            t1.Start();
        }

        private void voltarHome()
        {
            Application.Run(new FrmHome());
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDao = new UsuarioDAO();
            Usuario usuario = new Usuario();

            usuario.setUsuario(txtUsuario.Text.ToString().Trim());
            usuario.setSenha(txtSenha.Text.ToString().Trim());


            Boolean status = usuarioDao.verificarLogin(usuario);

            if (status)
            {
                this.Close();
                usuario = usuarioDao.buscarLogin(usuario);
                t1 = new Thread(() => abrirColecao(usuario));
                t1.Start();
            }
            else
            {
                MessageBox.Show("Algo de errado não está certo \nReveja seu usuário e senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void abrirColecao(Usuario usuario)
        {
            Application.Run(new FrmColecoes(usuario));
        }

    }
}
