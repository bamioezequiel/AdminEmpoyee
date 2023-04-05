using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AdminEmployee.DAL
{
    class ConnectionDAL
    {

        private string strConnection = "Data Source = DESKTOP-34J2GLK\\EZEQUIELBAMIO; Initial Catalog=dbSystem; Integrated Security = True";
        SqlConnection connection;

        public SqlConnection SetConnection()
        {
            this.connection = new SqlConnection(this.strConnection);
            return this.connection;
        }

        public bool ExecuteQuery(string strCommand)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.CommandText = strCommand;
                command.Connection = this.SetConnection();
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;

            } catch
            {
                return false;
            }

        }

        public bool ExecuteQuery(SqlCommand sqlCommand)
        {
            try
            {
                SqlCommand command = sqlCommand;

                command.Connection = this.SetConnection();
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public DataSet ExecuteSentence(SqlCommand sqlCommand)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                SqlCommand command = new SqlCommand();
                command = sqlCommand;
                command.Connection = SetConnection();
                adapter.SelectCommand = command;
                connection.Open();
                adapter.Fill(DS);
                connection.Close();

                return DS;
            } catch
            {
                return DS;
            }

        }
    }
}
