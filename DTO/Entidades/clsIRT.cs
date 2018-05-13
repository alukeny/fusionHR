using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entidades
{
    public class clsIRT
    {
        //1 - Campos privados a classe
        private string codigo;
        private string descricao;
        private decimal de;
        private decimal ate;
        private string percetntagem;
        private bool estado;


        //2 - Propriedades, acesso aos campos privados (get e set)
        public string _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string _descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public decimal _de
        {
            get { return de; }
            set { de = value; }
        }

        public decimal _ate
        {
            get { return ate; }
            set { ate = value; }
        }

        public string _percentagem
        {
            get { return percetntagem; }
            set { percetntagem = value; }
        }

        public bool _estado
        {
            get { return estado; }
            set { estado = value; }
        }

        //3 - Métodos da classe de Negócios (clsIRT.cs)

        //3.1 Buscar dados do IRT cujo codigo foi especificado
        public void buscar()
        {
            string csql;
            csql = "Select * From irt where codigo=" + codigo;
            DataSet ds;
            clsAcessoDados dados = new clsAcessoDados();
            ds = dados.retornarDataSet(csql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Array irt = ds.Tables[0].Rows[0].ItemArray;
                codigo = Convert.ToString(irt.GetValue(1));
                descricao = Convert.ToString(irt.GetValue(2));
                de = Convert.ToDecimal(irt.GetValue(3));
                ate = Convert.ToDecimal(irt.GetValue(4));
                percetntagem = Convert.ToString(irt.GetValue(5));
                estado = Convert.ToBoolean(irt.GetValue(5));
            }
        }

        //3.2 Buscar o ultimo ID criado
        public string buscarCodigo()
        {
            string csql;
            csql = "Select id From irt order by id desc limit 1";
            string codigoBuscado;
            clsAcessoDados irt = new clsAcessoDados();
            codigoBuscado = irt.retornarCodigo(csql);
            return codigoBuscado;
        }

        //3.3 Método para incluir um novo IRT da Base de Dados
        public void gravar()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Insert into irt");
            csql.Append("(");
            csql.Append("codigo,");
            csql.Append("descricao,");
            csql.Append("de,");
            csql.Append("ate,");
            csql.Append("percentagem,");
            csql.Append("estado) Values(");
            csql.Append(codigo);
            csql.Append(",'" + descricao + "',");
            csql.Append(de);
            csql.Append("," + ate);
            csql.Append(",'" + percetntagem + "',");
            csql.Append(estado + ")");
            clsAcessoDados irt = new clsAcessoDados();
            irt.executarComando(csql.ToString());
        }

        //3.5 Método para excluir um registo do IRT da Base de Dados
        public void excluir()
        {
            StringBuilder csql = new StringBuilder();
            csql.Append("Delete From irt ");
            csql.Append(" where codigo=");
            csql.Append(codigo);
            clsAcessoDados irt = new clsAcessoDados();
            irt.executarComando(csql.ToString());
        }

    }
}
