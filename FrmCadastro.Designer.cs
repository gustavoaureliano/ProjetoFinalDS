
namespace ProjetoFinalDS
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lblLinkLog = new System.Windows.Forms.LinkLabel();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.lblTit2 = new System.Windows.Forms.Label();
            this.imagemLateral = new System.Windows.Forms.PictureBox();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLinkLog
            // 
            this.lblLinkLog.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblLinkLog.AutoSize = true;
            this.lblLinkLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinkLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkLog.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.lblLinkLog.Location = new System.Drawing.Point(538, 345);
            this.lblLinkLog.Name = "lblLinkLog";
            this.lblLinkLog.Size = new System.Drawing.Size(37, 16);
            this.lblLinkLog.TabIndex = 21;
            this.lblLinkLog.TabStop = true;
            this.lblLinkLog.Text = "login";
            this.lblLinkLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkLog_LinkClicked);
            // 
            // lblFrase2
            // 
            this.lblFrase2.AutoSize = true;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.Location = new System.Drawing.Point(401, 345);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(131, 16);
            this.lblFrase2.TabIndex = 20;
            this.lblFrase2.Text = "Já está cadastrado?";
            this.lblFrase2.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTit2
            // 
            this.lblTit2.AutoSize = true;
            this.lblTit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit2.Location = new System.Drawing.Point(442, 64);
            this.lblTit2.Name = "lblTit2";
            this.lblTit2.Size = new System.Drawing.Size(294, 37);
            this.lblTit2.TabIndex = 19;
            this.lblTit2.Text = "Faça Seu Cadastro";
            this.lblTit2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imagemLateral
            // 
            this.imagemLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagemLateral.Image = ((System.Drawing.Image)(resources.GetObject("imagemLateral.Image")));
            this.imagemLateral.Location = new System.Drawing.Point(0, 0);
            this.imagemLateral.Name = "imagemLateral";
            this.imagemLateral.Size = new System.Drawing.Size(368, 527);
            this.imagemLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagemLateral.TabIndex = 18;
            this.imagemLateral.TabStop = false;
            // 
            // linkVoltar
            // 
            this.linkVoltar.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkVoltar.AutoSize = true;
            this.linkVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVoltar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.linkVoltar.Location = new System.Drawing.Point(572, 473);
            this.linkVoltar.Name = "linkVoltar";
            this.linkVoltar.Size = new System.Drawing.Size(51, 20);
            this.linkVoltar.TabIndex = 23;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "Voltar";
            this.linkVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltar_LinkClicked);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(18)))), ((int)(((byte)(6)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(516, 418);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 42);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(732, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 25;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(763, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 24;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(404, 302);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(353, 29);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(404, 279);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 28;
            this.lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(404, 230);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(353, 29);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(404, 207);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = "Usuário";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(404, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 29);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(404, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome";
            // 
            // FrmCadastro
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.linkVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblLinkLog);
            this.Controls.Add(this.lblFrase2);
            this.Controls.Add(this.lblTit2);
            this.Controls.Add(this.imagemLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCadastro_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imagemLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lblLinkLog;
        private System.Windows.Forms.Label lblFrase2;
        private System.Windows.Forms.Label lblTit2;
        private System.Windows.Forms.PictureBox imagemLateral;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}