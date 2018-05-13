using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class clsAcessoDados
    {

        // Atribuição da string de conexão
        string conexao = "server=localhost;user id=root;password=Borboleta2014;persistsecurityinfo=True;port=3306;database=fusion;connectiontimeout=300";

        //Classe para Abrir a Base de Dados
        private MySqlConnection abrirBD()
        {
           MySqlConnection cn = new MySqlConnection(conexao);
            cn.Open();
            return cn;
        }

        //Classe para Fechar o Banco de Dados
        public void fecharBD(MySqlConnection cn)
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        //Classe para execução de comando
        public void executarComando(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = abrirBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharBD(cn);
            }
        }
        //Classe que retorna um objeto DataSet
        public DataSet retornarDataSet(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = abrirBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                /*  Declarado um dataadapter e um dataset
                    passar o comando para o da (SqlDataAdapter) e
                    carregar o dataset com resultado da busca */
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharBD(cn);
            }
        }
        //Classe para retornar um DataReader()
        public MySqlDataReader retornarDataReader(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = abrirBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharBD(cn);
            }
        }

        //Classe para retornar um Id Numérico
        public string retornarCodigo(string strQuery)
        {
            MySqlConnection cn = new MySqlConnection();
            try
            {
                cn = abrirBD();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strQuery.ToString();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cn;
                MySqlDataReader dr = cmd.ExecuteReader();
                string codigo;
                if (dr.Read())
                    codigo = Convert.ToString(dr[0]) + 1;
                else
                    codigo = "";
                return codigo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharBD(cn);
            }
        }
    }
}
