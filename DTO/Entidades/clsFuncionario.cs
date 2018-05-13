using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO.Entidades
{
    public class clsFuncionario
    {
        //1 - Campos privados a classe
        private int naturalidade;
        private string codigo;
        private string nome;
        private string dataNascimento;
        private string numeroBI;
        private double salarioBase;
        private string morada;
        private bool estado;


        //2 - Propriedades, acesso aos campos privados (get e set)

        public int _naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }
        public string _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string _dataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public string _numeroBI
        {
            get { return numeroBI; }
            set { numeroBI = value; }
        }

        public double _salarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public string _morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public bool _estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //3 - Métodos da classe de Negócios (clsFuncionario.cs)

        //3.1 Buscar dados do Funcionário cujo codigo foi especificado
        public void buscar()
        {
            string csql;
            csql = "Select * From funcionario where codigo=" + "'" + codigo + "'";
            DataSet ds;
            clsAcessoDados dados = new clsAcessoDados();
            ds = dados.retornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array funcionario = ds.Tables[0].Rows[0].ItemArray;
                naturalidade = Convert.ToInt16(funcionario.GetValue(1));
                codigo = Convert.ToString(funcionario.GetValue(2));
                nome = Convert.ToString(funcionario.GetValue(3));
                dataNascimento = Convert.ToString(funcionario.GetValue(3));
                numeroBI = Convert.ToString(funcionario.GetValue(5));
                salarioBase = Convert.ToDouble(funcionario.GetValue(6));
                morada = Convert.ToString(funcionario.GetValue(7));
                estado = Convert.ToBoolean(funcionario.GetValue(8));
            }
        }

        //3.2 Buscar o ultimo ID criado
        public string buscarCodigo()
        {
            string csql;
            csql = "Select codigo From funcionario order by codigo desc limit 1";
            string codigoBuscado;
            clsAcessoDados funcionario = new clsAcessoDados();
            codigoBuscado = funcionario.retornarCodigo(csql);
            return codigoBuscado;
        }

        //3.3 Método para incluir um novo Funcionário da Base de Dados
        public void gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into funcionario");
            csql.Append("(");
            csql.Append("codigo,");
            csql.Append("nome,");
            csql.Append("dataNascimento,");
            csql.Append("numeroBI,");
            csql.Append("salarioBase,");
            csql.Append("morada,");
            csql.Append("estado) Values(");
            csql.Append("'" + codigo + "'");
            csql.Append(",'" + nome + "',");
            csql.Append("'" + dataNascimento + "',");
            csql.Append("'" + numeroBI + "',");
            csql.Append(salarioBase);
            csql.Append(",'" + morada + "',");
            csql.Append(estado + ")");
            clsAcessoDados funcionario = new clsAcessoDados();
            funcionario.executarComando(csql.ToString());
        }

        //3.4 Método para actualizar (alterar um registro)
        public void actualizar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Update funcionario ");
            csql.Append("set codigo=");
            csql.Append(codigo);
            csql.Append(", nome='");
            csql.Append(nome);
            csql.Append("', dataNascimento='");
            csql.Append(dataNascimento);
            csql.Append("', numeroBI='");
            csql.Append(numeroBI);
            csql.Append("', salarioBase='");
            csql.Append(salarioBase);
            csql.Append("', morada='");
            csql.Append(morada);
            csql.Append("', estado='");
            csql.Append(estado);
            csql.Append("' where codigo=");
            csql.Append(codigo);
            clsAcessoDados funcionario = new clsAcessoDados();
            funcionario.executarComando(csql.ToString());
        }

        //3.5 Método para excluir um Funcionário da Base de Dados
        public void excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From funcionario ");
            csql.Append(" where codigo=");
            csql.Append(codigo);
            clsAcessoDados funcionario = new clsAcessoDados();
            funcionario.executarComando(csql.ToString());
        }
    }
}
