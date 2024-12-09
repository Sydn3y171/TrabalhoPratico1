using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace GestaoObras.models.Singleton
{
    public class BDSingleton
    {
        #region Private Properties
        private static readonly Lazy<BDSingleton> _instancia = new Lazy<BDSingleton>(() => new BDSingleton());

        #endregion

        public static BDSingleton Instancia => _instancia.Value;

        private string connectionString;

        private BDSingleton()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BDConnection"].ConnectionString;
        }


        #region Conexao Method

        public SqlConnection OpenConection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        #endregion

        #region Consulta Tabela Method

        public DataTable ConsultaTabela(string query, SqlParameter[] parametros)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (SqlConnection connection = OpenConection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parametros != null)
                        {
                            command.Parameters.AddRange(parametros);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(tabela);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao realizar a consulta: " + ex.Message);
                throw;
            }

            return tabela;
        }


        #endregion
    }
}
