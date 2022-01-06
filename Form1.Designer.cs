namespace EtiquetasClippStore
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.quantidade = new System.Windows.Forms.Label();
            this.produtoInfo = new System.Windows.Forms.TextBox();
            this.quantidadeInfo = new System.Windows.Forms.TextBox();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.botaoPesquisarProd = new System.Windows.Forms.Button();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoGerar = new System.Windows.Forms.Button();
            this.labelValorEtq = new System.Windows.Forms.Label();
            this.labelCodigoEtq = new System.Windows.Forms.Label();
            this.labelDescEtq = new System.Windows.Forms.Label();
            this.textBoxETQnum = new System.Windows.Forms.TextBox();
            this.textBoxDescEtq = new System.Windows.Forms.TextBox();
            this.Etiqueta = new System.Windows.Forms.GroupBox();
            this.buscarEtq = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNFE = new System.Windows.Forms.RadioButton();
            this.radioProduto = new System.Windows.Forms.RadioButton();
            this.GBProduto = new System.Windows.Forms.GroupBox();
            this.produtoInfoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GBNfe = new System.Windows.Forms.GroupBox();
            this.nfeFornecedor = new System.Windows.Forms.TextBox();
            this.brPesquisaNFE = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelNFEvalor = new System.Windows.Forms.Label();
            this.labelNFEforn = new System.Windows.Forms.Label();
            this.labelNFEnumero = new System.Windows.Forms.Label();
            this.nfeNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firebird_CLIPP = new EtiquetasClippStore.Firebird_CLIPP();
            this.firebirdCLIPPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgETQ = new System.Windows.Forms.DataGridView();
            this.eTIQUETASQUANTIDADESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new EtiquetasClippStore.DataSet2();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBIniciarEm = new System.Windows.Forms.GroupBox();
            this.CBColuna = new System.Windows.Forms.ComboBox();
            this.CBLinha = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.iMPRESSAOETIQUETASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMPRESSAO_ETIQUETASTableAdapter = new EtiquetasClippStore.Firebird_CLIPPTableAdapters.IMPRESSAO_ETIQUETASTableAdapter();
            this.Etiquetas = new System.Windows.Forms.GroupBox();
            this.CheckBoxDG = new System.Windows.Forms.CheckBox();
            this.eTIQUETAS_QUANTIDADESTableAdapter = new EtiquetasClippStore.DataSet2TableAdapters.ETIQUETAS_QUANTIDADESTableAdapter();
            this.eTIQUETASQUANTIDADESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GBTipoPesqProd = new System.Windows.Forms.GroupBox();
            this.RBNome = new System.Windows.Forms.RadioButton();
            this.RBCodigo = new System.Windows.Forms.RadioButton();
            this.GBTipoPesqNfe = new System.Windows.Forms.GroupBox();
            this.RBNomeForn = new System.Windows.Forms.RadioButton();
            this.RBNumNFE = new System.Windows.Forms.RadioButton();
            this.CBIniciarEm = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.ColunaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaQuantidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxColuna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.Etiqueta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBProduto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GBNfe.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firebird_CLIPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firebirdCLIPPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgETQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTIQUETASQUANTIDADESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.GBIniciarEm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMPRESSAOETIQUETASBindingSource)).BeginInit();
            this.Etiquetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eTIQUETASQUANTIDADESBindingSource1)).BeginInit();
            this.GBTipoPesqProd.SuspendLayout();
            this.GBTipoPesqNfe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quantidade
            // 
            this.quantidade.AutoSize = true;
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.ForeColor = System.Drawing.Color.Black;
            this.quantidade.Location = new System.Drawing.Point(6, 47);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(86, 17);
            this.quantidade.TabIndex = 1;
            this.quantidade.Text = "Quantidade:";
            this.quantidade.Click += new System.EventHandler(this.Label1_Click);
            // 
            // produtoInfo
            // 
            this.produtoInfo.Location = new System.Drawing.Point(86, 18);
            this.produtoInfo.MaxLength = 9;
            this.produtoInfo.Name = "produtoInfo";
            this.produtoInfo.Size = new System.Drawing.Size(130, 23);
            this.produtoInfo.TabIndex = 2;
            this.produtoInfo.Visible = false;
            this.produtoInfo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.produtoInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdutoInfo_KeyDown_1);
            this.produtoInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProdutoInfo_KeyPress);
            // 
            // quantidadeInfo
            // 
            this.quantidadeInfo.Location = new System.Drawing.Point(86, 47);
            this.quantidadeInfo.MaxLength = 4;
            this.quantidadeInfo.Name = "quantidadeInfo";
            this.quantidadeInfo.Size = new System.Drawing.Size(130, 23);
            this.quantidadeInfo.TabIndex = 3;
            this.quantidadeInfo.TextChanged += new System.EventHandler(this.QuantidadeInfo_TextChanged);
            this.quantidadeInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantidadeInfo_KeyDown);
            this.quantidadeInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantidadeInfo_KeyPress);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AllowUserToOrderColumns = true;
            this.dgProdutos.AllowUserToResizeRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.GridColor = System.Drawing.Color.White;
            this.dgProdutos.Location = new System.Drawing.Point(9, 40);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersVisible = false;
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(400, 250);
            this.dgProdutos.TabIndex = 6;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgProdutos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProdutos_CellContentDoubleClick);
            this.dgProdutos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgProdutos_ColumnHeaderMouseClick);
            this.dgProdutos.Click += new System.EventHandler(this.DgProdutos_Click);
            // 
            // botaoPesquisarProd
            // 
            this.botaoPesquisarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.botaoPesquisarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoPesquisarProd.ForeColor = System.Drawing.Color.White;
            this.botaoPesquisarProd.Location = new System.Drawing.Point(222, 16);
            this.botaoPesquisarProd.Name = "botaoPesquisarProd";
            this.botaoPesquisarProd.Size = new System.Drawing.Size(88, 25);
            this.botaoPesquisarProd.TabIndex = 7;
            this.botaoPesquisarProd.Text = "Pesquisar";
            this.botaoPesquisarProd.UseVisualStyleBackColor = false;
            this.botaoPesquisarProd.Click += new System.EventHandler(this.BotaoPesquisar_Click);
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSair.ForeColor = System.Drawing.Color.White;
            this.botaoSair.Location = new System.Drawing.Point(794, 562);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(88, 28);
            this.botaoSair.TabIndex = 10;
            this.botaoSair.Text = "Sair";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.BotaoSair_Click_1);
            // 
            // botaoGerar
            // 
            this.botaoGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.botaoGerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botaoGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoGerar.ForeColor = System.Drawing.Color.White;
            this.botaoGerar.Location = new System.Drawing.Point(12, 562);
            this.botaoGerar.Name = "botaoGerar";
            this.botaoGerar.Size = new System.Drawing.Size(88, 28);
            this.botaoGerar.TabIndex = 9;
            this.botaoGerar.Text = "Gerar";
            this.botaoGerar.UseVisualStyleBackColor = false;
            this.botaoGerar.Click += new System.EventHandler(this.BotaoGerar_Click_1);
            // 
            // labelValorEtq
            // 
            this.labelValorEtq.AutoSize = true;
            this.labelValorEtq.BackColor = System.Drawing.Color.Transparent;
            this.labelValorEtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelValorEtq.ForeColor = System.Drawing.Color.Black;
            this.labelValorEtq.Location = new System.Drawing.Point(213, 22);
            this.labelValorEtq.Name = "labelValorEtq";
            this.labelValorEtq.Size = new System.Drawing.Size(36, 18);
            this.labelValorEtq.TabIndex = 16;
            this.labelValorEtq.Text = "0,00";
            this.labelValorEtq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValorEtq.Click += new System.EventHandler(this.LabelValorEtq_Click);
            // 
            // labelCodigoEtq
            // 
            this.labelCodigoEtq.AutoSize = true;
            this.labelCodigoEtq.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoEtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoEtq.ForeColor = System.Drawing.Color.Black;
            this.labelCodigoEtq.Location = new System.Drawing.Point(6, 23);
            this.labelCodigoEtq.Name = "labelCodigoEtq";
            this.labelCodigoEtq.Size = new System.Drawing.Size(58, 17);
            this.labelCodigoEtq.TabIndex = 17;
            this.labelCodigoEtq.Text = "Código";
            this.labelCodigoEtq.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelDescEtq
            // 
            this.labelDescEtq.AutoSize = true;
            this.labelDescEtq.BackColor = System.Drawing.Color.Transparent;
            this.labelDescEtq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescEtq.ForeColor = System.Drawing.Color.Black;
            this.labelDescEtq.Location = new System.Drawing.Point(6, 42);
            this.labelDescEtq.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelDescEtq.Name = "labelDescEtq";
            this.labelDescEtq.Size = new System.Drawing.Size(71, 17);
            this.labelDescEtq.TabIndex = 18;
            this.labelDescEtq.Text = "Descrição";
            // 
            // textBoxETQnum
            // 
            this.textBoxETQnum.Location = new System.Drawing.Point(6, 19);
            this.textBoxETQnum.MaxLength = 3;
            this.textBoxETQnum.Name = "textBoxETQnum";
            this.textBoxETQnum.Size = new System.Drawing.Size(61, 23);
            this.textBoxETQnum.TabIndex = 20;
            this.textBoxETQnum.Text = "001";
            // 
            // textBoxDescEtq
            // 
            this.textBoxDescEtq.Location = new System.Drawing.Point(73, 19);
            this.textBoxDescEtq.Name = "textBoxDescEtq";
            this.textBoxDescEtq.Size = new System.Drawing.Size(237, 23);
            this.textBoxDescEtq.TabIndex = 21;
            this.textBoxDescEtq.Text = "Etiqueta Layout Padrão";
            // 
            // Etiqueta
            // 
            this.Etiqueta.Controls.Add(this.buscarEtq);
            this.Etiqueta.Controls.Add(this.textBoxDescEtq);
            this.Etiqueta.Controls.Add(this.textBoxETQnum);
            this.Etiqueta.Enabled = false;
            this.Etiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.Etiqueta.Location = new System.Drawing.Point(12, 12);
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.Size = new System.Drawing.Size(316, 79);
            this.Etiqueta.TabIndex = 22;
            this.Etiqueta.TabStop = false;
            this.Etiqueta.Text = "Etiqueta";
            // 
            // buscarEtq
            // 
            this.buscarEtq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.buscarEtq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscarEtq.ForeColor = System.Drawing.Color.White;
            this.buscarEtq.Location = new System.Drawing.Point(222, 48);
            this.buscarEtq.Name = "buscarEtq";
            this.buscarEtq.Size = new System.Drawing.Size(88, 25);
            this.buscarEtq.TabIndex = 33;
            this.buscarEtq.Text = "Buscar";
            this.buscarEtq.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNFE);
            this.groupBox1.Controls.Add(this.radioProduto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.groupBox1.Location = new System.Drawing.Point(354, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 79);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo ";
            // 
            // radioNFE
            // 
            this.radioNFE.AutoSize = true;
            this.radioNFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNFE.ForeColor = System.Drawing.Color.Black;
            this.radioNFE.Location = new System.Drawing.Point(7, 44);
            this.radioNFE.Name = "radioNFE";
            this.radioNFE.Size = new System.Drawing.Size(118, 21);
            this.radioNFE.TabIndex = 1;
            this.radioNFE.TabStop = true;
            this.radioNFE.Text = "NF de Entrada";
            this.radioNFE.UseVisualStyleBackColor = true;
            this.radioNFE.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioProduto
            // 
            this.radioProduto.AutoSize = true;
            this.radioProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioProduto.ForeColor = System.Drawing.Color.Black;
            this.radioProduto.Location = new System.Drawing.Point(7, 21);
            this.radioProduto.Name = "radioProduto";
            this.radioProduto.Size = new System.Drawing.Size(76, 21);
            this.radioProduto.TabIndex = 0;
            this.radioProduto.TabStop = true;
            this.radioProduto.Text = "Produto";
            this.radioProduto.UseVisualStyleBackColor = true;
            this.radioProduto.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // GBProduto
            // 
            this.GBProduto.Controls.Add(this.produtoInfoNome);
            this.GBProduto.Controls.Add(this.label4);
            this.GBProduto.Controls.Add(this.label2);
            this.GBProduto.Controls.Add(this.produtoInfo);
            this.GBProduto.Controls.Add(this.botaoPesquisarProd);
            this.GBProduto.Controls.Add(this.quantidadeInfo);
            this.GBProduto.Controls.Add(this.groupBox3);
            this.GBProduto.Controls.Add(this.quantidade);
            this.GBProduto.Enabled = false;
            this.GBProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.GBProduto.Location = new System.Drawing.Point(12, 100);
            this.GBProduto.Name = "GBProduto";
            this.GBProduto.Size = new System.Drawing.Size(316, 154);
            this.GBProduto.TabIndex = 24;
            this.GBProduto.TabStop = false;
            this.GBProduto.Text = "Produto";
            // 
            // produtoInfoNome
            // 
            this.produtoInfoNome.Location = new System.Drawing.Point(86, 18);
            this.produtoInfoNome.MaxLength = 9;
            this.produtoInfoNome.Name = "produtoInfoNome";
            this.produtoInfoNome.Size = new System.Drawing.Size(130, 23);
            this.produtoInfoNome.TabIndex = 27;
            this.produtoInfoNome.Visible = false;
            this.produtoInfoNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProdutoInfoNome_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nome:";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Código:";
            this.label2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDescEtq);
            this.groupBox3.Controls.Add(this.labelValorEtq);
            this.groupBox3.Controls.Add(this.labelCodigoEtq);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 73);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto Selecionado";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // GBNfe
            // 
            this.GBNfe.Controls.Add(this.nfeFornecedor);
            this.GBNfe.Controls.Add(this.brPesquisaNFE);
            this.GBNfe.Controls.Add(this.label7);
            this.GBNfe.Controls.Add(this.groupBox4);
            this.GBNfe.Controls.Add(this.nfeNumero);
            this.GBNfe.Controls.Add(this.label3);
            this.GBNfe.Enabled = false;
            this.GBNfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBNfe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.GBNfe.Location = new System.Drawing.Point(566, 100);
            this.GBNfe.Name = "GBNfe";
            this.GBNfe.Size = new System.Drawing.Size(316, 154);
            this.GBNfe.TabIndex = 27;
            this.GBNfe.TabStop = false;
            this.GBNfe.Text = "Nota Fiscal de Entrada";
            // 
            // nfeFornecedor
            // 
            this.nfeFornecedor.Location = new System.Drawing.Point(91, 18);
            this.nfeFornecedor.MaxLength = 8;
            this.nfeFornecedor.Name = "nfeFornecedor";
            this.nfeFornecedor.Size = new System.Drawing.Size(122, 23);
            this.nfeFornecedor.TabIndex = 39;
            this.nfeFornecedor.Visible = false;
            this.nfeFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NfeFornecedor_KeyDown);
            // 
            // brPesquisaNFE
            // 
            this.brPesquisaNFE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.brPesquisaNFE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brPesquisaNFE.ForeColor = System.Drawing.Color.White;
            this.brPesquisaNFE.Location = new System.Drawing.Point(222, 16);
            this.brPesquisaNFE.Name = "brPesquisaNFE";
            this.brPesquisaNFE.Size = new System.Drawing.Size(88, 25);
            this.brPesquisaNFE.TabIndex = 8;
            this.brPesquisaNFE.Text = "Pesquisar";
            this.brPesquisaNFE.UseVisualStyleBackColor = false;
            this.brPesquisaNFE.Click += new System.EventHandler(this.BrPesquisaNFE_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fornecedor:";
            this.label7.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelNFEvalor);
            this.groupBox4.Controls.Add(this.labelNFEforn);
            this.groupBox4.Controls.Add(this.labelNFEnumero);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.groupBox4.Location = new System.Drawing.Point(9, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 73);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NFE Selecionada";
            // 
            // labelNFEvalor
            // 
            this.labelNFEvalor.AutoSize = true;
            this.labelNFEvalor.BackColor = System.Drawing.Color.Transparent;
            this.labelNFEvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelNFEvalor.ForeColor = System.Drawing.Color.Black;
            this.labelNFEvalor.Location = new System.Drawing.Point(171, 23);
            this.labelNFEvalor.Name = "labelNFEvalor";
            this.labelNFEvalor.Size = new System.Drawing.Size(36, 18);
            this.labelNFEvalor.TabIndex = 22;
            this.labelNFEvalor.Text = "0,00";
            this.labelNFEvalor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNFEforn
            // 
            this.labelNFEforn.AutoSize = true;
            this.labelNFEforn.BackColor = System.Drawing.Color.Transparent;
            this.labelNFEforn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNFEforn.ForeColor = System.Drawing.Color.Black;
            this.labelNFEforn.Location = new System.Drawing.Point(6, 42);
            this.labelNFEforn.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelNFEforn.Name = "labelNFEforn";
            this.labelNFEforn.Size = new System.Drawing.Size(81, 17);
            this.labelNFEforn.TabIndex = 19;
            this.labelNFEforn.Text = "Fornecedor";
            // 
            // labelNFEnumero
            // 
            this.labelNFEnumero.AutoSize = true;
            this.labelNFEnumero.BackColor = System.Drawing.Color.Transparent;
            this.labelNFEnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNFEnumero.ForeColor = System.Drawing.Color.Black;
            this.labelNFEnumero.Location = new System.Drawing.Point(6, 23);
            this.labelNFEnumero.Name = "labelNFEnumero";
            this.labelNFEnumero.Size = new System.Drawing.Size(64, 17);
            this.labelNFEnumero.TabIndex = 18;
            this.labelNFEnumero.Text = "Número";
            this.labelNFEnumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // nfeNumero
            // 
            this.nfeNumero.Location = new System.Drawing.Point(86, 18);
            this.nfeNumero.MaxLength = 8;
            this.nfeNumero.Name = "nfeNumero";
            this.nfeNumero.Size = new System.Drawing.Size(130, 23);
            this.nfeNumero.TabIndex = 5;
            this.nfeNumero.Visible = false;
            this.nfeNumero.TextChanged += new System.EventHandler(this.NfeNumero_TextChanged);
            this.nfeNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NfeNumero_KeyDown);
            this.nfeNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NfeNumero_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero NF:";
            this.label3.Visible = false;
            // 
            // firebird_CLIPP
            // 
            this.firebird_CLIPP.DataSetName = "Firebird_CLIPP";
            this.firebird_CLIPP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firebirdCLIPPBindingSource
            // 
            this.firebirdCLIPPBindingSource.DataSource = this.firebird_CLIPP;
            this.firebirdCLIPPBindingSource.Position = 0;
            // 
            // dgETQ
            // 
            this.dgETQ.AllowUserToAddRows = false;
            this.dgETQ.AllowUserToDeleteRows = false;
            this.dgETQ.AllowUserToOrderColumns = true;
            this.dgETQ.AllowUserToResizeRows = false;
            this.dgETQ.AutoGenerateColumns = false;
            this.dgETQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgETQ.BackgroundColor = System.Drawing.Color.White;
            this.dgETQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgETQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaCodigo,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.vALORDataGridViewTextBoxColumn,
            this.ColunaQuantidades,
            this.CheckBoxColuna});
            this.dgETQ.DataSource = this.eTIQUETASQUANTIDADESBindingSource;
            this.dgETQ.GridColor = System.Drawing.Color.White;
            this.dgETQ.Location = new System.Drawing.Point(451, 40);
            this.dgETQ.MultiSelect = false;
            this.dgETQ.Name = "dgETQ";
            this.dgETQ.RowHeadersVisible = false;
            this.dgETQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgETQ.Size = new System.Drawing.Size(400, 250);
            this.dgETQ.TabIndex = 28;
            this.dgETQ.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgETQ_CellEndEdit);
            this.dgETQ.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgETQ_CellValidating);
            this.dgETQ.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgETQ_EditingControlShowing);
            // 
            // eTIQUETASQUANTIDADESBindingSource
            // 
            this.eTIQUETASQUANTIDADESBindingSource.DataMember = "ETIQUETAS_QUANTIDADES";
            this.eTIQUETASQUANTIDADESBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Registros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(457, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Etiquetas Criadas:";
            // 
            // GBIniciarEm
            // 
            this.GBIniciarEm.Controls.Add(this.CBColuna);
            this.GBIniciarEm.Controls.Add(this.CBLinha);
            this.GBIniciarEm.Controls.Add(this.label10);
            this.GBIniciarEm.Controls.Add(this.label9);
            this.GBIniciarEm.Enabled = false;
            this.GBIniciarEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBIniciarEm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.GBIniciarEm.Location = new System.Drawing.Point(354, 179);
            this.GBIniciarEm.Name = "GBIniciarEm";
            this.GBIniciarEm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GBIniciarEm.Size = new System.Drawing.Size(201, 75);
            this.GBIniciarEm.TabIndex = 31;
            this.GBIniciarEm.TabStop = false;
            this.GBIniciarEm.Text = "Iniciar Impressão em";
            // 
            // CBColuna
            // 
            this.CBColuna.FormattingEnabled = true;
            this.CBColuna.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            " "});
            this.CBColuna.Location = new System.Drawing.Point(75, 45);
            this.CBColuna.Name = "CBColuna";
            this.CBColuna.Size = new System.Drawing.Size(92, 24);
            this.CBColuna.TabIndex = 39;
            this.CBColuna.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // CBLinha
            // 
            this.CBLinha.FormattingEnabled = true;
            this.CBLinha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            " "});
            this.CBLinha.Location = new System.Drawing.Point(75, 19);
            this.CBLinha.Name = "CBLinha";
            this.CBLinha.Size = new System.Drawing.Size(92, 24);
            this.CBLinha.TabIndex = 38;
            this.CBLinha.SelectedIndexChanged += new System.EventHandler(this.CBLinha_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 48);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Coluna:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 19);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Linha:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(321, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 25);
            this.button1.TabIndex = 33;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(763, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 25);
            this.button2.TabIndex = 34;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // iMPRESSAOETIQUETASBindingSource
            // 
            this.iMPRESSAOETIQUETASBindingSource.DataMember = "IMPRESSAO_ETIQUETAS";
            this.iMPRESSAOETIQUETASBindingSource.DataSource = this.firebirdCLIPPBindingSource;
            // 
            // iMPRESSAO_ETIQUETASTableAdapter
            // 
            this.iMPRESSAO_ETIQUETASTableAdapter.ClearBeforeFill = true;
            // 
            // Etiquetas
            // 
            this.Etiquetas.Controls.Add(this.CheckBoxDG);
            this.Etiquetas.Controls.Add(this.dgProdutos);
            this.Etiquetas.Controls.Add(this.label5);
            this.Etiquetas.Controls.Add(this.button2);
            this.Etiquetas.Controls.Add(this.button1);
            this.Etiquetas.Controls.Add(this.dgETQ);
            this.Etiquetas.Controls.Add(this.label6);
            this.Etiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiquetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.Etiquetas.Location = new System.Drawing.Point(12, 260);
            this.Etiquetas.Name = "Etiquetas";
            this.Etiquetas.Size = new System.Drawing.Size(870, 296);
            this.Etiquetas.TabIndex = 36;
            this.Etiquetas.TabStop = false;
            this.Etiquetas.Text = "Seleções";
            // 
            // CheckBoxDG
            // 
            this.CheckBoxDG.AutoSize = true;
            this.CheckBoxDG.Location = new System.Drawing.Point(457, 47);
            this.CheckBoxDG.Name = "CheckBoxDG";
            this.CheckBoxDG.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxDG.TabIndex = 36;
            this.CheckBoxDG.UseVisualStyleBackColor = true;
            this.CheckBoxDG.CheckedChanged += new System.EventHandler(this.CheckBoxDG_CheckedChanged);
            // 
            // eTIQUETAS_QUANTIDADESTableAdapter
            // 
            this.eTIQUETAS_QUANTIDADESTableAdapter.ClearBeforeFill = true;
            // 
            // eTIQUETASQUANTIDADESBindingSource1
            // 
            this.eTIQUETASQUANTIDADESBindingSource1.DataMember = "ETIQUETAS_QUANTIDADES";
            this.eTIQUETASQUANTIDADESBindingSource1.DataSource = this.dataSet2;
            // 
            // GBTipoPesqProd
            // 
            this.GBTipoPesqProd.Controls.Add(this.RBNome);
            this.GBTipoPesqProd.Controls.Add(this.RBCodigo);
            this.GBTipoPesqProd.Enabled = false;
            this.GBTipoPesqProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTipoPesqProd.Location = new System.Drawing.Point(354, 100);
            this.GBTipoPesqProd.Name = "GBTipoPesqProd";
            this.GBTipoPesqProd.Size = new System.Drawing.Size(201, 79);
            this.GBTipoPesqProd.TabIndex = 24;
            this.GBTipoPesqProd.TabStop = false;
            this.GBTipoPesqProd.Text = "Pesquisar Produto por:";
            this.GBTipoPesqProd.Visible = false;
            // 
            // RBNome
            // 
            this.RBNome.AutoSize = true;
            this.RBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNome.Location = new System.Drawing.Point(7, 44);
            this.RBNome.Name = "RBNome";
            this.RBNome.Size = new System.Drawing.Size(137, 21);
            this.RBNome.TabIndex = 1;
            this.RBNome.TabStop = true;
            this.RBNome.Text = "Nome do Produto";
            this.RBNome.UseVisualStyleBackColor = true;
            this.RBNome.CheckedChanged += new System.EventHandler(this.RBNome_CheckedChanged);
            // 
            // RBCodigo
            // 
            this.RBCodigo.AutoSize = true;
            this.RBCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBCodigo.Location = new System.Drawing.Point(7, 21);
            this.RBCodigo.Name = "RBCodigo";
            this.RBCodigo.Size = new System.Drawing.Size(144, 21);
            this.RBCodigo.TabIndex = 0;
            this.RBCodigo.TabStop = true;
            this.RBCodigo.Text = "Código do Produto";
            this.RBCodigo.UseVisualStyleBackColor = true;
            this.RBCodigo.CheckedChanged += new System.EventHandler(this.RBCodigo_CheckedChanged);
            // 
            // GBTipoPesqNfe
            // 
            this.GBTipoPesqNfe.Controls.Add(this.RBNomeForn);
            this.GBTipoPesqNfe.Controls.Add(this.RBNumNFE);
            this.GBTipoPesqNfe.Enabled = false;
            this.GBTipoPesqNfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBTipoPesqNfe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(129)))), ((int)(((byte)(76)))));
            this.GBTipoPesqNfe.Location = new System.Drawing.Point(354, 100);
            this.GBTipoPesqNfe.Name = "GBTipoPesqNfe";
            this.GBTipoPesqNfe.Size = new System.Drawing.Size(201, 79);
            this.GBTipoPesqNfe.TabIndex = 25;
            this.GBTipoPesqNfe.TabStop = false;
            this.GBTipoPesqNfe.Text = "Pesquisar NFE por:";
            this.GBTipoPesqNfe.Visible = false;
            // 
            // RBNomeForn
            // 
            this.RBNomeForn.AutoSize = true;
            this.RBNomeForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNomeForn.ForeColor = System.Drawing.Color.Black;
            this.RBNomeForn.Location = new System.Drawing.Point(7, 44);
            this.RBNomeForn.Name = "RBNomeForn";
            this.RBNomeForn.Size = new System.Drawing.Size(160, 21);
            this.RBNomeForn.TabIndex = 1;
            this.RBNomeForn.TabStop = true;
            this.RBNomeForn.Text = "Nome do Fornecedor";
            this.RBNomeForn.UseVisualStyleBackColor = true;
            this.RBNomeForn.CheckedChanged += new System.EventHandler(this.RBNomeForn_CheckedChanged);
            // 
            // RBNumNFE
            // 
            this.RBNumNFE.AutoSize = true;
            this.RBNumNFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNumNFE.ForeColor = System.Drawing.Color.Black;
            this.RBNumNFE.Location = new System.Drawing.Point(7, 21);
            this.RBNumNFE.Name = "RBNumNFE";
            this.RBNumNFE.Size = new System.Drawing.Size(127, 21);
            this.RBNumNFE.TabIndex = 0;
            this.RBNumNFE.TabStop = true;
            this.RBNumNFE.Text = "Número da NFE";
            this.RBNumNFE.UseVisualStyleBackColor = true;
            this.RBNumNFE.CheckedChanged += new System.EventHandler(this.RBNumNFE_CheckedChanged);
            // 
            // CBIniciarEm
            // 
            this.CBIniciarEm.AutoSize = true;
            this.CBIniciarEm.Enabled = false;
            this.CBIniciarEm.Location = new System.Drawing.Point(361, 179);
            this.CBIniciarEm.Name = "CBIniciarEm";
            this.CBIniciarEm.Size = new System.Drawing.Size(15, 14);
            this.CBIniciarEm.TabIndex = 23;
            this.CBIniciarEm.UseVisualStyleBackColor = true;
            this.CBIniciarEm.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtiquetasClippStore.Properties.Resources.LogoG2;
            this.pictureBox1.Location = new System.Drawing.Point(642, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            // 
            // ColunaCodigo
            // 
            this.ColunaCodigo.DataPropertyName = "CODIGO";
            this.ColunaCodigo.FillWeight = 103.0781F;
            this.ColunaCodigo.HeaderText = "Código";
            this.ColunaCodigo.MinimumWidth = 25;
            this.ColunaCodigo.Name = "ColunaCodigo";
            this.ColunaCodigo.ReadOnly = true;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.FillWeight = 313.0967F;
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dESCRICAODataGridViewTextBoxColumn.MinimumWidth = 180;
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORDataGridViewTextBoxColumn
            // 
            this.vALORDataGridViewTextBoxColumn.DataPropertyName = "VALOR";
            this.vALORDataGridViewTextBoxColumn.FillWeight = 11.50855F;
            this.vALORDataGridViewTextBoxColumn.HeaderText = "R$";
            this.vALORDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.vALORDataGridViewTextBoxColumn.Name = "vALORDataGridViewTextBoxColumn";
            this.vALORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColunaQuantidades
            // 
            this.ColunaQuantidades.DataPropertyName = "QUANTIDADE";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ColunaQuantidades.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColunaQuantidades.HeaderText = "Qtd";
            this.ColunaQuantidades.MinimumWidth = 40;
            this.ColunaQuantidades.Name = "ColunaQuantidades";
            // 
            // CheckBoxColuna
            // 
            this.CheckBoxColuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            this.CheckBoxColuna.DefaultCellStyle = dataGridViewCellStyle2;
            this.CheckBoxColuna.FillWeight = 43.87915F;
            this.CheckBoxColuna.HeaderText = "";
            this.CheckBoxColuna.MinimumWidth = 20;
            this.CheckBoxColuna.Name = "CheckBoxColuna";
            this.CheckBoxColuna.Width = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 602);
            this.Controls.Add(this.CBIniciarEm);
            this.Controls.Add(this.GBTipoPesqNfe);
            this.Controls.Add(this.GBTipoPesqProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Etiquetas);
            this.Controls.Add(this.GBIniciarEm);
            this.Controls.Add(this.GBNfe);
            this.Controls.Add(this.GBProduto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Etiqueta);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.botaoGerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão Etiquetas ClippStore";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.Etiqueta.ResumeLayout(false);
            this.Etiqueta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBProduto.ResumeLayout(false);
            this.GBProduto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GBNfe.ResumeLayout(false);
            this.GBNfe.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firebird_CLIPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firebirdCLIPPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgETQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTIQUETASQUANTIDADESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.GBIniciarEm.ResumeLayout(false);
            this.GBIniciarEm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iMPRESSAOETIQUETASBindingSource)).EndInit();
            this.Etiquetas.ResumeLayout(false);
            this.Etiquetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eTIQUETASQUANTIDADESBindingSource1)).EndInit();
            this.GBTipoPesqProd.ResumeLayout(false);
            this.GBTipoPesqProd.PerformLayout();
            this.GBTipoPesqNfe.ResumeLayout(false);
            this.GBTipoPesqNfe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label quantidade;
        private System.Windows.Forms.TextBox produtoInfo;
        private System.Windows.Forms.TextBox quantidadeInfo;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Button botaoPesquisarProd;
        private System.Windows.Forms.Button botaoSair;
        private System.Windows.Forms.Button botaoGerar;
        private System.Windows.Forms.Label labelValorEtq;
        private System.Windows.Forms.Label labelCodigoEtq;
        private System.Windows.Forms.Label labelDescEtq;
        private System.Windows.Forms.TextBox textBoxETQnum;
        private System.Windows.Forms.TextBox textBoxDescEtq;
        private System.Windows.Forms.GroupBox Etiqueta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNFE;
        private System.Windows.Forms.RadioButton radioProduto;
        private System.Windows.Forms.GroupBox GBProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox GBNfe;
        private System.Windows.Forms.Button brPesquisaNFE;
        private System.Windows.Forms.TextBox nfeNumero;
        private System.Windows.Forms.Label label3;
        private Firebird_CLIPP firebird_CLIPP;
        private System.Windows.Forms.BindingSource firebirdCLIPPBindingSource;
        private System.Windows.Forms.DataGridView dgETQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBIniciarEm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelNFEforn;
        private System.Windows.Forms.Label labelNFEnumero;
        private System.Windows.Forms.Label labelNFEvalor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource iMPRESSAOETIQUETASBindingSource;
        private Firebird_CLIPPTableAdapters.IMPRESSAO_ETIQUETASTableAdapter iMPRESSAO_ETIQUETASTableAdapter;
        private System.Windows.Forms.GroupBox Etiquetas;
        private System.Windows.Forms.Button buscarEtq;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource eTIQUETASQUANTIDADESBindingSource;
        private DataSet2TableAdapters.ETIQUETAS_QUANTIDADESTableAdapter eTIQUETAS_QUANTIDADESTableAdapter;
        private System.Windows.Forms.BindingSource eTIQUETASQUANTIDADESBindingSource1;
        private System.Windows.Forms.CheckBox CheckBoxDG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GBTipoPesqProd;
        private System.Windows.Forms.RadioButton RBNome;
        private System.Windows.Forms.RadioButton RBCodigo;
        private System.Windows.Forms.GroupBox GBTipoPesqNfe;
        private System.Windows.Forms.RadioButton RBNomeForn;
        private System.Windows.Forms.RadioButton RBNumNFE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox produtoInfoNome;
        private System.Windows.Forms.TextBox nfeFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBIniciarEm;
        private System.Windows.Forms.ComboBox CBColuna;
        private System.Windows.Forms.ComboBox CBLinha;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaQuantidades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColuna;
    }
}

