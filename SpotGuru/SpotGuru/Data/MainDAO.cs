using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace SpotGuru.Data
{
    public class MainDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=mainDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Aqui vai ser desenvolvido o codigo que acede a BD

        public List<Models.MonumentosView> fetchAll()
        {
            List<Models.MonumentosView> ret = new List<Models.MonumentosView>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from dbo.Monumentos";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader sqlR = cmd.ExecuteReader();
                if (sqlR != null && sqlR.HasRows)
                {
                    while (sqlR.Read())
                    {
                        Models.MonumentosView monumento = new Models.MonumentosView();
                        monumento.Id = sqlR.GetInt32(0);
                        monumento.Nome = sqlR.GetString(1);
                        monumento.Descrição = sqlR.GetString(2);
                        monumento.Localizacao = new Models.LocalizacaoView(sqlR.GetDouble(3), sqlR.GetDouble(4));
                        monumento.Categoria = sqlR.GetString(5);
                        monumento.IDHorario = sqlR.GetInt32(6);
                        ret.Add(monumento);
                    }
                }
                return ret;
            }

        }
    }
}
