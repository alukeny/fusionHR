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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
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
            this.gbOpcoes.SuspendLayout();
            this.gpbComponentes.SuspendLayout();
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
            this.gbOpcoes.Location = new System.Drawing.Point(6, -1);
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
            this.gpbComponentes.Controls.Add(this.txtCodigoInterno);
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
            this.gpbComponentes.Location = new System.Drawing.Point(6, 39);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(511, 133);
            this.gpbComponentes.TabIndex = 36;
            this.gpbComponentes.TabStop = false;
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoInterno.Location = new System.Drawing.Point(8, 26);
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.Size = new System.Drawing.Size(190, 20);
            this.txtCodigoInterno.TabIndex = 35;
            this.txtCodigoInterno.TextChanged += new System.EventHandler(this.txtCodigoInterno_TextChanged);
            this.txtCodigoInterno.Leave += new System.EventHandler(this.txtCodigoInterno_Leave);
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
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 321);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.gpbComponentes);
            this.MaximizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fusionHR - Editor de Funcionários";
            this.gbOpcoes.ResumeLayout(false);
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.GroupBox gbOpcoes;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnActualizar;
        internal System.Windows.Forms.GroupBox gpbComponentes;
        internal System.Windows.Forms.TextBox txtCodigoInterno;
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
    }
}