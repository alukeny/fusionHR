using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Formulários.Utilitários
{
    public partial class frmlistagem : Form
    {
        public frmlistagem()
        {
            InitializeComponent();
        }

        //Ao carregar o formulário, busca todos os itens da tabela em questão.
        private void frmlistagem_Load(object sender, EventArgs e)
        {
            string csql = "Select   * From " + this.Tag.ToString();
            clsAcessoDados geral = new clsAcessoDados();
            DataSet ds = geral.retornarDataSet(csql);
            dgvListagem.DataSource = ds.Tables[0];
            ds.Tables[0].Columns[0].ColumnName.ToString();
            cboColuna.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                cboColuna.Items.Add(ds.Tables[0].Columns[i].ColumnName.ToString());
        }

        //Carrega a combobox coluna para filtrar as colunas.
        private void cboColuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceCampo = cboColuna.SelectedIndex;
            string tipocampo = this.dgvListagem.Columns[indiceCampo].ValueType.ToString();
            if (tipocampo.Trim() == "System.Int32")
            {
                cboParametro.Items.Clear();
                cboParametro.Items.Add("=");
                cboParametro.Items.Add(">");
                cboParametro.Items.Add(">=");
                cboParametro.Items.Add("<");
                cboParametro.Items.Add("<=");
                cboParametro.Items.Add("<>");
            }
            else if (tipocampo.Trim() == "System.String")
            {
                cboParametro.Items.Clear();
                cboParametro.Items.Add("=");
                cboParametro.Items.Add("Começa com");
                cboParametro.Items.Add("Termina em");
                cboParametro.Items.Add("Tem a palavra");
            }
            else
            {
                MessageBox.Show("Contancte o suporte técnico, para adição de novos tipos...");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string campo = cboColuna.Text;
            string parametro = cboParametro.Text;
            string valor = txtValor.Text;
            int indiceCampo = cboColuna.SelectedIndex;
            string tipocampo = this.dgvListagem.Columns[indiceCampo].ValueType.ToString();
            //Para tipos String
            if (tipocampo == "System.String")
            {
                if (parametro == "Tem a palavra")
                {
                    parametro = "Like ";
                    valor = "'%" + valor + "%'";
                }
                else if (parametro == "=")
                {
                    parametro = "=";
                    valor = "'" + valor + "'";
                }
                else if (parametro == "Começa com")
                {
                    parametro = "Like ";
                    valor = "'" + valor + "%'";
                }
                else if (parametro == "Termina em")
                {
                    parametro = "Like ";
                    valor = "'%" + valor + "'";
                }
            }
            //Para tipos int não são necessário ajustes.
            string csql = "Select * from " + this.Tag.ToString() +
                " where " + campo + " " + parametro + " " + valor;
            clsAcessoDados busca = new clsAcessoDados();
            DataSet ds = busca.retornarDataSet(csql);
            this.dgvListagem.DataSource = ds.Tables[0];
        }
    }
}
