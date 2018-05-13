namespace UI.Formulários.Utilitários
{
    partial class frmlistagem
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
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboColuna = new System.Windows.Forms.ComboBox();
            this.dgvListagem = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboParametro = new System.Windows.Forms.ComboBox();
            this.gbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.label3);
            this.gbOpcoes.Controls.Add(this.cboParametro);
            this.gbOpcoes.Controls.Add(this.btnFiltrar);
            this.gbOpcoes.Controls.Add(this.Label2);
            this.gbOpcoes.Controls.Add(this.txtValor);
            this.gbOpcoes.Controls.Add(this.Label1);
            this.gbOpcoes.Controls.Add(this.cboColuna);
            this.gbOpcoes.Location = new System.Drawing.Point(5, -1);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(523, 58);
            this.gbOpcoes.TabIndex = 3;
            this.gbOpcoes.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(442, 31);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 21);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(271, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(31, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Location = new System.Drawing.Point(274, 31);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(162, 20);
            this.txtValor.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Coluna";
            // 
            // cboColuna
            // 
            this.cboColuna.FormattingEnabled = true;
            this.cboColuna.Location = new System.Drawing.Point(6, 31);
            this.cboColuna.Name = "cboColuna";
            this.cboColuna.Size = new System.Drawing.Size(128, 21);
            this.cboColuna.TabIndex = 2;
            this.cboColuna.SelectedIndexChanged += new System.EventHandler(this.cboColuna_SelectedIndexChanged);
            // 
            // dgvListagem
            // 
            this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagem.Location = new System.Drawing.Point(5, 63);
            this.dgvListagem.Name = "dgvListagem";
            this.dgvListagem.Size = new System.Drawing.Size(523, 193);
            this.dgvListagem.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Paramêtro";
            // 
            // cboParametro
            // 
            this.cboParametro.FormattingEnabled = true;
            this.cboParametro.Location = new System.Drawing.Point(140, 31);
            this.cboParametro.Name = "cboParametro";
            this.cboParametro.Size = new System.Drawing.Size(128, 21);
            this.cboParametro.TabIndex = 7;
            // 
            // frmlistagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.dgvListagem);
            this.MaximizeBox = false;
            this.Name = "frmlistagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fusionHR - Listagem Geral";
            this.Load += new System.EventHandler(this.frmlistagem_Load);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbOpcoes;
        internal System.Windows.Forms.Button btnFiltrar;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtValor;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboColuna;
        internal System.Windows.Forms.DataGridView dgvListagem;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cboParametro;
    }
}