
namespace ProjetoFinalDS
{
    partial class FrmColecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColecao));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnDescColecao = new System.Windows.Forms.Button();
            this.lblNomeColecao = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvItens = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAbrirColecoes = new System.Windows.Forms.LinkLabel();
            this.txtDataAlteracao = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnAlterarItem = new System.Windows.Forms.Button();
            this.btnAcervoGeek = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Selecionar Categoria"});
            this.comboBox1.Location = new System.Drawing.Point(597, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 28);
            this.comboBox1.TabIndex = 54;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(294, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 29);
            this.txtSearch.TabIndex = 53;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(486, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(47, 29);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelTop.Controls.Add(this.btnDescColecao);
            this.panelTop.Controls.Add(this.lblNomeColecao);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnFechar);
            this.panelTop.Controls.Add(this.logo);
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(832, 85);
            this.panelTop.TabIndex = 51;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecao_MouseMove);
            // 
            // btnDescColecao
            // 
            this.btnDescColecao.BackColor = System.Drawing.Color.Transparent;
            this.btnDescColecao.FlatAppearance.BorderSize = 0;
            this.btnDescColecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescColecao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDescColecao.Image = ((System.Drawing.Image)(resources.GetObject("btnDescColecao.Image")));
            this.btnDescColecao.Location = new System.Drawing.Point(699, 30);
            this.btnDescColecao.Name = "btnDescColecao";
            this.btnDescColecao.Size = new System.Drawing.Size(25, 25);
            this.btnDescColecao.TabIndex = 61;
            this.btnDescColecao.UseVisualStyleBackColor = false;
            this.btnDescColecao.Click += new System.EventHandler(this.btnDescColecao_Click);
            // 
            // lblNomeColecao
            // 
            this.lblNomeColecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeColecao.ForeColor = System.Drawing.Color.White;
            this.lblNomeColecao.Location = new System.Drawing.Point(251, 0);
            this.lblNomeColecao.Name = "lblNomeColecao";
            this.lblNomeColecao.Size = new System.Drawing.Size(425, 85);
            this.lblNomeColecao.TabIndex = 16;
            this.lblNomeColecao.Text = "Coleção - Nome";
            this.lblNomeColecao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNomeColecao.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecao_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Black;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(764, 30);
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
            this.btnFechar.Location = new System.Drawing.Point(795, 30);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 549);
            this.panel1.TabIndex = 60;
            // 
            // lvItens
            // 
            this.lvItens.HideSelection = false;
            this.lvItens.Location = new System.Drawing.Point(251, 175);
            this.lvItens.Name = "lvItens";
            this.lvItens.Size = new System.Drawing.Size(521, 389);
            this.lvItens.TabIndex = 47;
            this.lvItens.UseCompatibleStateImageBehavior = false;
            this.lvItens.Click += new System.EventHandler(this.lvItens_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.lblAbrirColecoes);
            this.panel2.Controls.Add(this.txtDataAlteracao);
            this.panel2.Controls.Add(this.txtDataCriacao);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAdicionarItem);
            this.panel2.Controls.Add(this.btnAlterarItem);
            this.panel2.Controls.Add(this.btnAcervoGeek);
            this.panel2.Controls.Add(this.pbUsuario);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 575);
            this.panel2.TabIndex = 60;
            // 
            // lblAbrirColecoes
            // 
            this.lblAbrirColecoes.AutoSize = true;
            this.lblAbrirColecoes.LinkColor = System.Drawing.Color.White;
            this.lblAbrirColecoes.Location = new System.Drawing.Point(40, 467);
            this.lblAbrirColecoes.Name = "lblAbrirColecoes";
            this.lblAbrirColecoes.Size = new System.Drawing.Size(104, 13);
            this.lblAbrirColecoes.TabIndex = 70;
            this.lblAbrirColecoes.TabStop = true;
            this.lblAbrirColecoes.Text = "Voltar para coleções";
            this.lblAbrirColecoes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAbrirColecoes_LinkClicked);
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.AutoSize = true;
            this.txtDataAlteracao.Location = new System.Drawing.Point(54, 368);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(73, 13);
            this.txtDataAlteracao.TabIndex = 69;
            this.txtDataAlteracao.Text = "XX/XX/XXXX";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.AutoSize = true;
            this.txtDataCriacao.Location = new System.Drawing.Point(53, 432);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(73, 13);
            this.txtDataCriacao.TabIndex = 68;
            this.txtDataCriacao.Text = "XX/XX/XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Data de Criação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Última Alteração:";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdicionarItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdicionarItem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItem.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarItem.Image")));
            this.btnAdicionarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarItem.Location = new System.Drawing.Point(12, 144);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(177, 34);
            this.btnAdicionarItem.TabIndex = 63;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // btnAlterarItem
            // 
            this.btnAlterarItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAlterarItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlterarItem.FlatAppearance.BorderSize = 0;
            this.btnAlterarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarItem.ForeColor = System.Drawing.Color.Black;
            this.btnAlterarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarItem.Image")));
            this.btnAlterarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarItem.Location = new System.Drawing.Point(12, 193);
            this.btnAlterarItem.Name = "btnAlterarItem";
            this.btnAlterarItem.Size = new System.Drawing.Size(152, 34);
            this.btnAlterarItem.TabIndex = 64;
            this.btnAlterarItem.Text = "Alterar Item";
            this.btnAlterarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarItem.UseVisualStyleBackColor = false;
            this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
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
            this.btnAcervoGeek.TabIndex = 65;
            this.btnAcervoGeek.Text = "Acervo Geek";
            this.btnAcervoGeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcervoGeek.UseVisualStyleBackColor = false;
            this.btnAcervoGeek.Click += new System.EventHandler(this.btnAcervoGeek_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(12, 32);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(54, 54);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 62;
            this.pbUsuario.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(66, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 105);
            this.txtNome.TabIndex = 61;
            this.txtNome.Text = "Nome";
            this.txtNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmColecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 585);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lvItens);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmColecao";
            this.Text = "Coleçao";
            this.Load += new System.EventHandler(this.FrmColecao_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmColecao_MouseMove);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblNomeColecao;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ListView lvItens;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnAcervoGeek;
        private System.Windows.Forms.Button btnDescColecao;
        private System.Windows.Forms.Label txtDataAlteracao;
        private System.Windows.Forms.Label txtDataCriacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblAbrirColecoes;
    }
}