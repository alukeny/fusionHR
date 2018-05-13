namespace UI
{
    partial class frmfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionario));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnListagem = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNumeroBI = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbcFuncionario = new System.Windows.Forms.TabControl();
            this.tbpPessoais = new System.Windows.Forms.TabPage();
            this.tbpParentesco = new System.Windows.Forms.TabPage();
            this.tbpGlobais = new System.Windows.Forms.TabPage();
            this.tbpFinanceiros = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.gbOpcoes.SuspendLayout();
            this.gpbComponentes.SuspendLayout();
            this.tbcFuncionario.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Location = new System.Drawing.Point(430, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 21);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGravar.Location = new System.Drawing.Point(6, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 21);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Incluir";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btnCancelar);
            this.gbOpcoes.Controls.Add(this.btnExcluir);
            this.gbOpcoes.Controls.Add(this.btnActualizar);
            this.gbOpcoes.Controls.Add(this.btnSair);
            this.gbOpcoes.Controls.Add(this.btnGravar);
            this.gbOpcoes.Location = new System.Drawing.Point(6, 71);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(511, 40);
            this.gbOpcoes.TabIndex = 35;
            this.gbOpcoes.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(251, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 21);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(168, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 21);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Location = new System.Drawing.Point(87, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 21);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.txtCodigo);
            this.gpbComponentes.Controls.Add(this.btnListagem);
            this.gpbComponentes.Controls.Add(this.cbEstado);
            this.gpbComponentes.Controls.Add(this.Label6);
            this.gpbComponentes.Controls.Add(this.txtMorada);
            this.gpbComponentes.Controls.Add(this.dtpDataNascimento);
            this.gpbComponentes.Controls.Add(this.Label5);
            this.gpbComponentes.Controls.Add(this.txtSalarioBase);
            this.gpbComponentes.Controls.Add(this.Label4);
            this.gpbComponentes.Controls.Add(this.txtNumeroBI);
            this.gpbComponentes.Controls.Add(this.Label3);
            this.gpbComponentes.Controls.Add(this.Label1);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.Label2);
            this.gpbComponentes.Location = new System.Drawing.Point(6, 111);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(511, 133);
            this.gpbComponentes.TabIndex = 36;
            this.gpbComponentes.TabStop = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(8, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(190, 20);
            this.txtCodigo.TabIndex = 35;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // btnListagem
            // 
            this.btnListagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListagem.Location = new System.Drawing.Point(204, 26);
            this.btnListagem.Name = "btnListagem";
            this.btnListagem.Size = new System.Drawing.Size(52, 20);
            this.btnListagem.TabIndex = 37;
            this.btnListagem.Text = "L";
            this.btnListagem.UseVisualStyleBackColor = true;
            this.btnListagem.Click += new System.EventHandler(this.btnListagem_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.Location = new System.Drawing.Point(139, 10);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(59, 17);
            this.cbEstado.TabIndex = 48;
            this.cbEstado.Text = "Estado";
            this.cbEstado.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(268, 87);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 47;
            this.Label6.Text = "Morada";
            // 
            // txtMorada
            // 
            this.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMorada.Location = new System.Drawing.Point(271, 102);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(234, 20);
            this.txtMorada.TabIndex = 46;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "0000-00-00";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(8, 102);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(248, 20);
            this.dtpDataNascimento.TabIndex = 45;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(268, 49);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(66, 13);
            this.Label5.TabIndex = 44;
            this.Label5.Text = "Salário Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioBase.Location = new System.Drawing.Point(271, 64);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(234, 20);
            this.txtSalarioBase.TabIndex = 43;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(268, 11);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(137, 13);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Identidade B.I | Passport Nº";
            // 
            // txtNumeroBI
            // 
            this.txtNumeroBI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroBI.Location = new System.Drawing.Point(271, 26);
            this.txtNumeroBI.Name = "txtNumeroBI";
            this.txtNumeroBI.Size = new System.Drawing.Size(234, 20);
            this.txtNumeroBI.TabIndex = 41;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(5, 86);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 13);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Data de Nascimento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 49);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(8, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 20);
            this.txtNome.TabIndex = 38;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 13);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "Código Interno";
            // 
            // tbcFuncionario
            // 
            this.tbcFuncionario.Controls.Add(this.tbpPessoais);
            this.tbcFuncionario.Controls.Add(this.tbpParentesco);
            this.tbcFuncionario.Controls.Add(this.tbpGlobais);
            this.tbcFuncionario.Controls.Add(this.tbpFinanceiros);
            this.tbcFuncionario.Location = new System.Drawing.Point(674, 174);
            this.tbcFuncionario.Name = "tbcFuncionario";
            this.tbcFuncionario.SelectedIndex = 0;
            this.tbcFuncionario.Size = new System.Drawing.Size(307, 114);
            this.tbcFuncionario.TabIndex = 37;
            // 
            // tbpPessoais
            // 
            this.tbpPessoais.Location = new System.Drawing.Point(4, 22);
            this.tbpPessoais.Name = "tbpPessoais";
            this.tbpPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPessoais.Size = new System.Drawing.Size(299, 88);
            this.tbpPessoais.TabIndex = 0;
            this.tbpPessoais.Text = "Pessoais";
            this.tbpPessoais.UseVisualStyleBackColor = true;
            // 
            // tbpParentesco
            // 
            this.tbpParentesco.Location = new System.Drawing.Point(4, 22);
            this.tbpParentesco.Name = "tbpParentesco";
            this.tbpParentesco.Padding = new System.Windows.Forms.Padding(3);
            this.tbpParentesco.Size = new System.Drawing.Size(299, 88);
            this.tbpParentesco.TabIndex = 1;
            this.tbpParentesco.Text = "Parentesco";
            this.tbpParentesco.UseVisualStyleBackColor = true;
            // 
            // tbpGlobais
            // 
            this.tbpGlobais.Location = new System.Drawing.Point(4, 22);
            this.tbpGlobais.Name = "tbpGlobais";
            this.tbpGlobais.Size = new System.Drawing.Size(299, 88);
            this.tbpGlobais.TabIndex = 2;
            this.tbpGlobais.Text = "Globais";
            this.tbpGlobais.UseVisualStyleBackColor = true;
            // 
            // tbpFinanceiros
            // 
            this.tbpFinanceiros.Location = new System.Drawing.Point(4, 22);
            this.tbpFinanceiros.Name = "tbpFinanceiros";
            this.tbpFinanceiros.Size = new System.Drawing.Size(299, 88);
            this.tbpFinanceiros.TabIndex = 3;
            this.tbpFinanceiros.Text = "Financeiros";
            this.tbpFinanceiros.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripButton4,
            this.toolStripLabel4,
            this.toolStripButton5,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 38;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Incluir";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Actualizar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel3.Text = "Excluir";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "Cancelar";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(26, 22);
            this.toolStripLabel5.Text = "Sair";
            // 
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 348);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbcFuncionario);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.gpbComponentes);
            this.MaximizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fusionHR - Editor de Funcionários";
            this.gbOpcoes.ResumeLayout(false);
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            this.tbcFuncionario.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.GroupBox gbOpcoes;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.GroupBox gpbComponentes;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Button btnListagem;
        internal System.Windows.Forms.CheckBox cbEstado;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtMorada;
        internal System.Windows.Forms.DateTimePicker dtpDataNascimento;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSalarioBase;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtNumeroBI;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TabControl tbcFuncionario;
        private System.Windows.Forms.TabPage tbpPessoais;
        private System.Windows.Forms.TabPage tbpParentesco;
        private System.Windows.Forms.TabPage tbpGlobais;
        private System.Windows.Forms.TabPage tbpFinanceiros;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
    }
}