using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalDS.dao
{
    class ConexaoBD
    {

        private static String conectionString = "Server = localhost; Database = acervoGeek; UId = acervoGeek; Pwd = 12345";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConxao()
        {
            conn = new MySqlConnection(conectionString);
            try
            {
                conn.Open();
            }
            catch (MySqlException sqle)
            {
                conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
