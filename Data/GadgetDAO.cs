using BondMovies.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BondMovies.Data
{
    internal class GadgetDAO
    {

        private string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=BondMovies;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //perform all operations on the database
        public List<GadgetModel> FetchAll()
        {
            List<GadgetModel> returnList = new List<GadgetModel>();

            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from [dbo].[Gadgets]";
            }
        }
    }
}