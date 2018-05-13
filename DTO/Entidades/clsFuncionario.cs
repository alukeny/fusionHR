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
        private int id;
        private int codigoInterno;
        private string nome;
        private string dataNascimento;
        private string numeroBI;
        private double salarioBase;
        private string morada;
        private bool estado;
        

        //2 - Propriedades, acesso aos campos privados (get e set)
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public int _codigoInterno
        {
            get { return codigoInterno; }
            set { codigoInterno = value; }
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
            csql = "Select * From funcionario where codigoInterno=" + codigoInterno;
            DataSet ds;
            clsAcessoDados dados = new clsAcessoDados();
            ds = dados.retornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array funcionario = ds.Tables[0].Rows[0].ItemArray;
                id = Convert.ToInt16(funcionario.GetValue(0));
                codigoInterno = Convert.ToInt16(funcionario.GetValue(1));
                nome = Convert.ToString(funcionario.GetValue(2));
                dataNascimento = Convert.ToString(funcionario.GetValue(3));
                numeroBI = Convert.ToString(funcionario.GetValue(4));
                salarioBase = Convert.ToDouble(funcionario.GetValue(5));
                morada = Convert.ToString(funcionario.GetValue(4));
                estado = Convert.ToBoolean(funcionario.GetValue(5));
            }
        }

        //3.2 Buscar o ultimo ID criado
        public int buscarID()
        {
            string csql;
            csql = "Select codigoInterno From funcionario order by codigoInterno desc limit 1";
            int idBuscado;
            clsAcessoDados funcionario = new clsAcessoDados();
            idBuscado = funcionario.retornarIdNumerico(csql);
            return idBuscado;
        }

        //3.3 Método para incluir um novo Funcionário da Base de Dados
        public void gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into funcionario");
            csql.Append("(");
            csql.Append("codigoInterno,");
            csql.Append("nome,");
            csql.Append("dataNascimento,");
            csql.Append("numeroBI,");
            csql.Append("salarioBase,");
            csql.Append("morada,");
            csql.Append("estado) Values(");
            csql.Append(codigoInterno);
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
            csql.Append("set codigoInterno=");
            csql.Append(codigoInterno);
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
            csql.Append("' where codigoInterno=");
            csql.Append(codigoInterno);
            clsAcessoDados funcionario = new clsAcessoDados();
            funcionario.executarComando(csql.ToString());
        }

        //3.5 Método para excluir um Funcionário da Base de Dados
        public void excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From funcionario ");
            csql.Append(" where codigoInterno=");
            csql.Append(codigoInterno);
            clsAcessoDados funcionario = new clsAcessoDados();
            funcionario.executarComando(csql.ToString());
        }
    }
}
