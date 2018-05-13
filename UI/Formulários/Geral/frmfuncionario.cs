using DTO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Formulários.Utilitários;

namespace UI
{
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
        }

        //Método público para limpar caixas de texto
        public void limparTexto(Control controles)
        {
            foreach (Control ctl in controles.Controls)
            {
                if (ctl is TextBox) ctl.Text = "";
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            string codigo = "";
            if (txtCodigo.Text.Trim() != "")
            {
                codigo = Convert.ToString(txtCodigo.Text);
            }
            clsFuncionario funcionario = new clsFuncionario();
            funcionario._codigo = codigo;
            funcionario.buscar();
            if (funcionario._nome == null)
            {
                //preparando para inclusao
                limparTexto(gpbComponentes);
                txtCodigo.ReadOnly = true;
                btnGravar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else
            {
                //preparando para alteracao
                limparTexto(gpbComponentes);
                txtCodigo.ReadOnly = true;
                txtCodigo.Text = Convert.ToString(funcionario._codigo);
                txtNome.Text = Convert.ToString(funcionario._nome);
                dtpDataNascimento.Text = Convert.ToString(funcionario._dataNascimento);
                txtNumeroBI.Text = Convert.ToString(funcionario._numeroBI);
                txtSalarioBase.Text = Convert.ToString(funcionario._salarioBase);
                txtMorada.Text = Convert.ToString(funcionario._morada);
                //cbEstado.CheckState= funcionario._estado;
                btnActualizar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;

            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                clsFuncionario funcionario = new clsFuncionario();
                //Dispara o método para buscar o codigo
                funcionario._codigo = funcionario.buscarCodigo();
                funcionario._nome = txtNome.Text;
                funcionario._dataNascimento = dtpDataNascimento.Text;
                funcionario._numeroBI = txtNumeroBI.Text;
                funcionario._salarioBase = Convert.ToDouble(txtSalarioBase.Text);
                funcionario._morada = txtMorada.Text;
                funcionario.gravar();
                string mensagem = "Registro Funcionário: " +
                    funcionario._codigo + "\nNome Completo: " + funcionario._nome +
                    "\nGravado com sucesso";
                MessageBox.Show(mensagem, "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limparTexto(gpbComponentes);
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteu o erro: " + ex.Message, "Erro");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                clsFuncionario funcionario = new clsFuncionario();
                funcionario._codigo = txtCodigo.Text;
                funcionario._nome = txtNome.Text;
                funcionario._dataNascimento = dtpDataNascimento.Text;
                funcionario._numeroBI = txtNumeroBI.Text;
                funcionario._salarioBase = Convert.ToDouble(txtSalarioBase.Text);
                funcionario._morada = txtMorada.Text;
                funcionario.actualizar();
                string mensagem = "Registro Funcionário: " +
                    funcionario._codigo + "\nNome Completo: " + funcionario._nome +
                    "\nAlterado com sucesso";
                MessageBox.Show(mensagem, "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limparTexto(gpbComponentes);
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aconteu o erro: " + ex.Message, "Erro");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string pergunta;
            pergunta = "Deseja excluir o Funcionário: \n" +
                txtCodigo.Text + ": " + txtNome.Text +
                "  ?";
            int ret = Convert.ToInt16(MessageBox.Show(pergunta, "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question));
            if (ret == 6)
            {
                clsFuncionario funcionario = new clsFuncionario();
                funcionario._codigo = txtCodigo.Text;
                funcionario._nome = txtNome.Text;
                funcionario.excluir();
                string mensagem = "Registro Funcionário: " +
                    funcionario._codigo + "\nNome: " + funcionario._codigo +
                    "\nExcluído com sucesso";
                MessageBox.Show(mensagem, "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limparTexto(gpbComponentes);
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                btnExcluir.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Operação Cancelada",
                    "Cancelada", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparTexto(gpbComponentes);
            btnGravar.Enabled = false;
            btnActualizar.Enabled = false;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListagem_Click(object sender, EventArgs e)
        {
            frmlistagem f = new frmlistagem();
            f.Text = "fusionHR - Consulta de Funcionários";
            f.Tag = "funcionario"; //nome da tabela (macete)  :)
            f.ShowDialog();
        }

    }
}
