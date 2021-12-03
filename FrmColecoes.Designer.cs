
namespace ProjetoFinalDS
{
    partial class FrmColecoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColecoes));
            this.lvColecoes = new System.Windows.Forms.ListView();
            this.txtNomeUsuario = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.btnAdicionarColecao = new System.Windows.Forms.Button();
            this.btnAlterarColecao = new System.Windows.Forms.Button();
            this.btnAcervoGeek = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvColecoes
            // 
            this.lvColecoes.HideSelection = false;
            this.lvColecoes.Location = new System.Drawing.Point(251, 174);
            this.lvColecoes.Name = "lvColecoes";
            this.lvColecoes.Size = new System.Drawing.Size(521, 389);
            this.lvColecoes.TabIndex = 0;
            this.lvColecoes.UseCompatibleStateImageBehavior = false;
            this.lvColecoes.Click += new System.EventHandler(this.lvColecoes_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNomeUsuario.Location = new System.Drawing.Point(64, 94);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(125, 97);
            this.txtNomeUsuario.TabIndex = 1;
            this.txtNomeUsuario.Text = "Nome";
            this.txtNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNomeUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(12, 34);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(54, 54);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 2;
            this.pbUsuario.TabStop = false;
            this.pbUsuario.Click += new System.EventHandler(this.pbUsuario_Click);
            // 
            // btnAdicionarColecao
            // 
            this.btnAdicionarColecao.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdicionarColecao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarColecao.FlatAppearance.BorderSize = 0;
            this.btnAdicionarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarColecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarColecao.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarColecao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarColecao.Image")));
            this.btnAdicionarColecao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarColecao.Location = new System.Drawing.Point(12, 144);
            this.btnAdicionarColecao.Name = "btnAdicionarColecao";
            this.btnAdicionarColecao.Size = new System.Drawing.Size(136, 34);
            this.btnAdicionarColecao.TabIndex = 3;
            this.btnAdicionarColecao.Text = "Adicionar";
            this.btnAdicionarColecao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarColecao.UseVisualStyleBackColor = false;
            this.btnAdicionarColecao.Click += new System.EventHandler(this.btnAdicionarColecao_Click);
            // 
            // btnAlterarColecao
            // 
            this.btnAlterarColecao.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlterarColecao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterarColecao.FlatAppearance.BorderSize = 0;
            this.btnAlterarColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarColecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarColecao.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarColecao.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarColecao.Image")));
            this.btnAlterarColecao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarColecao.Location = new System.Drawing.Point(12, 193);
            this.btnAlterarColecao.Name = "btnAlterarColecao";
            this.btnAlterarColecao.Size = new System.Drawing.Size(114, 34);
            this.btnAlterarColecao.TabIndex = 4;
            this.btnAlterarColecao.Text = "Alterar";
            this.btnAlterarColecao.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAlterarColecao.UseVisualStyleBackColor = false;
            this.btnAlterarColecao.Click += new System.EventHandler(this.btnAlterarColecao_Click);
            // 
            // btnAcervoGeek
            // 
            this.btnAcervoGeek.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAcervoGeek.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAcervoGeek.FlatAppearance.BorderSize = 0;
            this.btnAcervoGeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcervoGeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcervoGeek.ForeColor = System.Drawing.Color.Black;
            this.btnAcervoGeek.Image = ((System.Drawing.Image)(resources.GetObject("btnAcervoGeek.Image")));
            this.btnAcervoGeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcervoGeek.Location = new System.Drawing.Point(12, 233);
            this.btnAcervoGeek.Name = "btnAcervoGeek";
            this.btnAcervoGeek.Size = new System.Drawing.Size(168, 55);
            this.btnAcervoGeek.TabIndex = 12;
            this.btnAcervoGeek.Text = "Acervo Geek";
            this.btnAcervoGeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcervoGeek.UseVisualStyleBackColor = false;
            this.btnAcervoGeek.Click += new System.EventHandler(this.btnAcervoGeek_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnFechar);
            this.panelTop.Controls.Add(this.logo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(832, 85);
            this.panelTop.TabIndex = 42;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecoes_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(385, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Colecionáveis";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(767, 30);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Black;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(798, 30);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFechar.TabIndex = 14;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(79, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(154, 91);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(580, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 29);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(388, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 29);
            this.txtSearch.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.pbUsuario);
            this.panel1.Controls.Add(this.btnAdicionarColecao);
            this.panel1.Controls.Add(this.btnAlterarColecao);
            this.panel1.Controls.Add(this.btnAcervoGeek);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 549);
            this.panel1.TabIndex = 46;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecoes_MouseMove);
            // 
            // FrmColecoes
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 585);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lvColecoes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmColecoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmColecoes_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecoes_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvColecoes;
        private System.Windows.Forms.Label txtNomeUsuario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btnAdicionarColecao;
        private System.Windows.Forms.Button btnAlterarColecao;
        private System.Windows.Forms.Button btnAcervoGeek;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
    }
}