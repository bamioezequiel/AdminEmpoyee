using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using AdminEmployee.BLL;


namespace AdminEmployee.DAL
{
    class DepartamentDAL
    {
        ConnectionDAL connection;

        public DepartamentDAL()
        {
            connection = new ConnectionDAL();
        }

        public bool Add(DepartamentBLL oDepartament)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Departament (departament) VALUES(@Departament)");
            command.Parameters.Add("@Departament", SqlDbType.VarChar).Value = oDepartament.Departament;

            return connection.ExecuteQuery(command);
            //return connection.ExecuteQuery($"INSERT INTO Departament (departament) VALUES('{oDepartament.Departament}')");
        }

        public bool Delete(DepartamentBLL oDepartament)
        {

            SqlCommand command = new SqlCommand("DELETE FROM Departament WHERE ID=@ID");
            command.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartament.ID;

            return connection.ExecuteQuery(command);
        }
        public bool Update(DepartamentBLL oDepartament)
        {
            SqlCommand command = new SqlCommand("UPDATE Departament SET departament=@Departament WHERE ID=@ID");
            command.Parameters.Add("@Departament", SqlDbType.VarChar).Value = oDepartament.Departament;
            command.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartament.ID;

            return connection.ExecuteQuery(command);
        }


        public DataSet GetDepartament()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Departament");

            return connection.ExecuteSentence(command);
        }
    }
}
