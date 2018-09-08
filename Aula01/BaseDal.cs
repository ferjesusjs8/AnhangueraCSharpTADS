using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    public class BaseDal
    {
        SqlConnection connectBase;
        SqlCommand commandBase;
        string connectionString;

        public BaseDal(string endereco)
        {
            connectionString = endereco;
        }

        public int executarComando(String cmd)
        {
            using (connectBase = new SqlConnection(connectionString))
            {
                connectBase.Open();

                commandBase = new SqlCommand(cmd, connectBase);
                int retorno = commandBase.ExecuteNonQuery();
                connectBase.Close();

                return retorno;
            }
        }

        public DataTable ListaDados(String cmd)
        {
            using (connectBase = new SqlConnection(connectionString))
            {
                connectBase.Open();
                commandBase = new SqlCommand(cmd, connectBase);
                SqlDataReader leitor = commandBase.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(leitor);

                connectBase.Close();
                return dt;
            }
        }
    }
}
