namespace Tarefa_CFA
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup21 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup22 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup23 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup24 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup25 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup26 = new System.Windows.Forms.ListViewGroup("Documentário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup27 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("Ficção científica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Pesquisa", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LISTA_FILMES = new System.Windows.Forms.ListView();
            this.COLUNA_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_GÊNERO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_DATA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLUNA_LOCAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Tnome = new System.Windows.Forms.TextBox();
            this.Tgenero = new System.Windows.Forms.ComboBox();
            this.Tlocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Exclusao = new System.Windows.Forms.Button();
            this.PERQUISA = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Tdata = new System.Windows.Forms.DateTimePicker();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.FecharPesquisa = new System.Windows.Forms.Button();
            this.Tdata_Ate = new System.Windows.Forms.DateTimePicker();
            this.ATE = new System.Windows.Forms.Label();
            this.AbilitarData = new System.Windows.Forms.RadioButton();
            this.DesabilitarData = new System.Windows.Forms.RadioButton();
            this.LFRASE = new System.Windows.Forms.Label();
            this.LMENSAGEM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetaNome = new System.Windows.Forms.PictureBox();
            this.SetaGenero = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetaNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetaGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // LISTA_FILMES
            // 
            this.LISTA_FILMES.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LISTA_FILMES.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COLUNA_NOME,
            this.COLUNA_GÊNERO,
            this.COLUNA_DATA,
            this.COLUNA_LOCAL});
            listViewGroup21.Header = "Ação";
            listViewGroup21.Name = "Ação";
            listViewGroup22.Header = "Aventura";
            listViewGroup22.Name = "Aventura";
            listViewGroup23.Header = "Comédia";
            listViewGroup23.Name = "Comédia";
            listViewGroup24.Header = "Terror";
            listViewGroup24.Name = "Terror";
            listViewGroup25.Header = "Suspense";
            listViewGroup25.Name = "Suspense";
            listViewGroup26.Header = "Documentário";
            listViewGroup26.Name = "Documentário";
            listViewGroup27.Header = "Infantil";
            listViewGroup27.Name = "Infantil";
            listViewGroup28.Header = "Romance";
            listViewGroup28.Name = "Romance";
            listViewGroup29.Header = "Ficção científica";
            listViewGroup29.Name = "Ficção científica";
            listViewGroup30.Header = "Pesquisa";
            listViewGroup30.Name = "Pesquisa";
            this.LISTA_FILMES.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup21,
            listViewGroup22,
            listViewGroup23,
            listViewGroup24,
            listViewGroup25,
            listViewGroup26,
            listViewGroup27,
            listViewGroup28,
            listViewGroup29,
            listViewGroup30});
            this.LISTA_FILMES.Location = new System.Drawing.Point(15, 151);
            this.LISTA_FILMES.Name = "LISTA_FILMES";
            this.LISTA_FILMES.Size = new System.Drawing.Size(785, 398);
            this.LISTA_FILMES.TabIndex = 0;
            this.LISTA_FILMES.UseCompatibleStateImageBehavior = false;
            this.LISTA_FILMES.View = System.Windows.Forms.View.Details;
            this.LISTA_FILMES.DoubleClick += new System.EventHandler(this.LISTA_FILMES_DoubleClick);
            // 
            // COLUNA_NOME
            // 
            this.COLUNA_NOME.Text = "Nome";
            this.COLUNA_NOME.Width = 257;
            // 
            // COLUNA_GÊNERO
            // 
            this.COLUNA_GÊNERO.Text = "Gênero";
            this.COLUNA_GÊNERO.Width = 118;
            // 
            // COLUNA_DATA
            // 
            this.COLUNA_DATA.Text = "Data";
            this.COLUNA_DATA.Width = 144;
            // 
            // COLUNA_LOCAL
            // 
            this.COLUNA_LOCAL.Text = "Local";
            this.COLUNA_LOCAL.Width = 653;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // Tnome
            // 
            this.Tnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tnome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Tnome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Tnome.Location = new System.Drawing.Point(15, 45);
            this.Tnome.Name = "Tnome";
            this.Tnome.Size = new System.Drawing.Size(437, 20);
            this.Tnome.TabIndex = 2;
            this.Tnome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TNOME_MouseClick);
            // 
            // Tgenero
            // 
            this.Tgenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tgenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tgenero.FormattingEnabled = true;
            this.Tgenero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção científica"});
            this.Tgenero.Location = new System.Drawing.Point(555, 45);
            this.Tgenero.Name = "Tgenero";
            this.Tgenero.Size = new System.Drawing.Size(236, 21);
            this.Tgenero.TabIndex = 3;
            this.Tgenero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TGENERO_MouseClick);
            // 
            // Tlocal
            // 
            this.Tlocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tlocal.AutoCompleteCustomSource.AddRange(new string[] {
            "Na minha casa",
            "No cinema",
            "No serviço",
            "Na casa da sogra",
            "Não sei aonde estou"});
            this.Tlocal.Location = new System.Drawing.Point(15, 84);
            this.Tlocal.Name = "Tlocal";
            this.Tlocal.Size = new System.Drawing.Size(437, 20);
            this.Tlocal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gênero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local:";
            // 
            // Adicionar
            // 
            this.Adicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Adicionar.Location = new System.Drawing.Point(555, 82);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 9;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.ADICIONAR_Click);
            // 
            // Exclusao
            // 
            this.Exclusao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exclusao.Enabled = false;
            this.Exclusao.Location = new System.Drawing.Point(717, 82);
            this.Exclusao.Name = "Exclusao";
            this.Exclusao.Size = new System.Drawing.Size(75, 23);
            this.Exclusao.TabIndex = 10;
            this.Exclusao.Text = "Excluir";
            this.Exclusao.UseVisualStyleBackColor = true;
            this.Exclusao.Click += new System.EventHandler(this.EXCLUIR_Click);
            // 
            // PERQUISA
            // 
            this.PERQUISA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PERQUISA.Location = new System.Drawing.Point(636, 120);
            this.PERQUISA.Name = "PERQUISA";
            this.PERQUISA.Size = new System.Drawing.Size(75, 23);
            this.PERQUISA.TabIndex = 11;
            this.PERQUISA.Text = "Pesquisa";
            this.PERQUISA.UseVisualStyleBackColor = true;
            this.PERQUISA.Click += new System.EventHandler(this.PERQUISA_Click);
            // 
            // Alterar
            // 
            this.Alterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Alterar.Enabled = false;
            this.Alterar.Location = new System.Drawing.Point(636, 82);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 14;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.ALTERAR_Click);
            // 
            // Tdata
            // 
            this.Tdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tdata.Location = new System.Drawing.Point(15, 123);
            this.Tdata.Name = "Tdata";
            this.Tdata.Size = new System.Drawing.Size(102, 20);
            this.Tdata.TabIndex = 16;
            // 
            // Pesquisa
            // 
            this.Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pesquisa.Location = new System.Drawing.Point(555, 82);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(108, 23);
            this.Pesquisa.TabIndex = 17;
            this.Pesquisa.Text = "Pesquisar";
            this.Pesquisa.UseVisualStyleBackColor = true;
            this.Pesquisa.Visible = false;
            this.Pesquisa.Click += new System.EventHandler(this.PESQUISAR_Click);
            // 
            // FecharPesquisa
            // 
            this.FecharPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FecharPesquisa.Location = new System.Drawing.Point(683, 82);
            this.FecharPesquisa.Name = "FecharPesquisa";
            this.FecharPesquisa.Size = new System.Drawing.Size(108, 23);
            this.FecharPesquisa.TabIndex = 18;
            this.FecharPesquisa.Text = "Sair da Pesquisa";
            this.FecharPesquisa.UseVisualStyleBackColor = true;
            this.FecharPesquisa.Visible = false;
            this.FecharPesquisa.Click += new System.EventHandler(this.FECHAR_PESQUISA_Click);
            // 
            // Tdata_Ate
            // 
            this.Tdata_Ate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tdata_Ate.Location = new System.Drawing.Point(135, 124);
            this.Tdata_Ate.Name = "Tdata_Ate";
            this.Tdata_Ate.Size = new System.Drawing.Size(102, 20);
            this.Tdata_Ate.TabIndex = 19;
            this.Tdata_Ate.Visible = false;
            // 
            // ATE
            // 
            this.ATE.AutoSize = true;
            this.ATE.Location = new System.Drawing.Point(132, 107);
            this.ATE.Name = "ATE";
            this.ATE.Size = new System.Drawing.Size(26, 13);
            this.ATE.TabIndex = 20;
            this.ATE.Text = "Até:";
            this.ATE.Visible = false;
            // 
            // AbilitarData
            // 
            this.AbilitarData.AutoSize = true;
            this.AbilitarData.Checked = true;
            this.AbilitarData.Location = new System.Drawing.Point(255, 125);
            this.AbilitarData.Name = "AbilitarData";
            this.AbilitarData.Size = new System.Drawing.Size(80, 17);
            this.AbilitarData.TabIndex = 21;
            this.AbilitarData.TabStop = true;
            this.AbilitarData.Text = "Abilitar data";
            this.AbilitarData.UseVisualStyleBackColor = true;
            this.AbilitarData.Visible = false;
            // 
            // DesabilitarData
            // 
            this.DesabilitarData.AutoSize = true;
            this.DesabilitarData.Location = new System.Drawing.Point(354, 126);
            this.DesabilitarData.Name = "DesabilitarData";
            this.DesabilitarData.Size = new System.Drawing.Size(98, 17);
            this.DesabilitarData.TabIndex = 22;
            this.DesabilitarData.TabStop = true;
            this.DesabilitarData.Text = "Desabilitar data";
            this.DesabilitarData.UseVisualStyleBackColor = true;
            this.DesabilitarData.Visible = false;
            // 
            // LFRASE
            // 
            this.LFRASE.AutoSize = true;
            this.LFRASE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFRASE.Location = new System.Drawing.Point(12, 9);
            this.LFRASE.Name = "LFRASE";
            this.LFRASE.Size = new System.Drawing.Size(256, 13);
            this.LFRASE.TabIndex = 23;
            this.LFRASE.Text = "Para cadastrar insira os dados e clique em Adicionar.";
            // 
            // LMENSAGEM
            // 
            this.LMENSAGEM.AutoSize = true;
            this.LMENSAGEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMENSAGEM.ForeColor = System.Drawing.Color.Black;
            this.LMENSAGEM.Location = new System.Drawing.Point(6, 16);
            this.LMENSAGEM.Name = "LMENSAGEM";
            this.LMENSAGEM.Size = new System.Drawing.Size(431, 13);
            this.LMENSAGEM.TabIndex = 24;
            this.LMENSAGEM.Text = "Para atualizar ou excluir dados, de clique duplo em cima do item desejado.";
            this.LMENSAGEM.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LMENSAGEM);
            this.groupBox1.Location = new System.Drawing.Point(15, 561);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 39);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação";
            // 
            // SetaNome
            // 
            this.SetaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetaNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SetaNome.Image = ((System.Drawing.Image)(resources.GetObject("SetaNome.Image")));
            this.SetaNome.Location = new System.Drawing.Point(458, 45);
            this.SetaNome.Name = "SetaNome";
            this.SetaNome.Size = new System.Drawing.Size(37, 20);
            this.SetaNome.TabIndex = 26;
            this.SetaNome.TabStop = false;
            this.SetaNome.Visible = false;
            // 
            // SetaGenero
            // 
            this.SetaGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetaGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SetaGenero.Image = ((System.Drawing.Image)(resources.GetObject("SetaGenero.Image")));
            this.SetaGenero.Location = new System.Drawing.Point(507, 45);
            this.SetaGenero.Name = "SetaGenero";
            this.SetaGenero.Size = new System.Drawing.Size(37, 20);
            this.SetaGenero.TabIndex = 27;
            this.SetaGenero.TabStop = false;
            this.SetaGenero.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 612);
            this.Controls.Add(this.SetaGenero);
            this.Controls.Add(this.SetaNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LFRASE);
            this.Controls.Add(this.DesabilitarData);
            this.Controls.Add(this.AbilitarData);
            this.Controls.Add(this.ATE);
            this.Controls.Add(this.Tdata_Ate);
            this.Controls.Add(this.FecharPesquisa);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.Tdata);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.PERQUISA);
            this.Controls.Add(this.Exclusao);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tlocal);
            this.Controls.Add(this.Tgenero);
            this.Controls.Add(this.Tnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LISTA_FILMES);
            this.Name = "Form1";
            this.Text = "Cadastro de filmes assistidos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SetaNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetaGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LISTA_FILMES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tnome;
        private System.Windows.Forms.ComboBox Tgenero;
        private System.Windows.Forms.TextBox Tlocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Exclusao;
        private System.Windows.Forms.Button PERQUISA;
        private System.Windows.Forms.ColumnHeader COLUNA_NOME;
        private System.Windows.Forms.ColumnHeader COLUNA_GÊNERO;
        private System.Windows.Forms.ColumnHeader COLUNA_DATA;
        private System.Windows.Forms.ColumnHeader COLUNA_LOCAL;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.DateTimePicker Tdata;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.Button FecharPesquisa;
        private System.Windows.Forms.DateTimePicker Tdata_Ate;
        private System.Windows.Forms.Label ATE;
        private System.Windows.Forms.RadioButton AbilitarData;
        private System.Windows.Forms.RadioButton DesabilitarData;
        private System.Windows.Forms.Label LFRASE;
        private System.Windows.Forms.Label LMENSAGEM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox SetaNome;
        private System.Windows.Forms.PictureBox SetaGenero;
    }
}

