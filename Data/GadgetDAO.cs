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
                string sqlQuery = "SELECT * from [dbo].[GadgetModels]";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new gadget object and add it to the list.
                        GadgetModel gadget = new GadgetModel();
                        gadget.Id = reader.GetInt32(0);
                        gadget.Name = reader.GetString(1);
                        gadget.Description = reader.GetString(2);
                        gadget.AppersIn = reader.GetString(3);
                        gadget.WithThisActor = reader.GetString(4);

                        returnList.Add(gadget);
                    }
                }
            }
            return returnList;
        }

        public GadgetModel FetchOne(int id)
        {
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * from [dbo].[GadgetModels] WHERE Id = @id";

                //associate @id with the Id parameter

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                GadgetModel gadget = new GadgetModel();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new gadget object and add it to the list.
                        
                        gadget.Id = reader.GetInt32(0);
                        gadget.Name = reader.GetString(1);
                        gadget.Description = reader.GetString(2);
                        gadget.AppersIn = reader.GetString(3);
                        gadget.WithThisActor = reader.GetString(4);

                    }
                }
                return gadget;
            }
        }

        //create new
        public int Create(GadgetModel gadgetModel)
        {
            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO [dbo].[GadgetModels] Values(@Name, @Description, @AppersIn, @WithThisActor)";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar, 1000).Value = gadgetModel.Name;
                command.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 1000).Value = gadgetModel.Description;
                command.Parameters.Add("@AppersIn", System.Data.SqlDbType.VarChar, 1000).Value = gadgetModel.AppersIn;
                command.Parameters.Add("@WithThisActor", System.Data.SqlDbType.VarChar, 1000).Value = gadgetModel.WithThisActor;

                connection.Open();
                int newID = command.ExecuteNonQuery();

                return newID;
            }
        }

        //delete one

        //update one

        //search for one

        //search for description
    }
}