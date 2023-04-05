using AdminEmployee.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AdminEmployee.DAL
{
    class EmployeeDAL
    {
        ConnectionDAL connection;

        public EmployeeDAL()
        {
            connection = new ConnectionDAL();
        }

        public bool Add(EmployeeBLL oEmployee)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Employee (firstname, lastname, email, picture, idDepartament) VALUES(@Name, @Lastname, @Email, @Image, @Departament)");

                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = oEmployee.Name;
                command.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = oEmployee.Lastname;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = oEmployee.Email;
                command.Parameters.Add("@Image", SqlDbType.Image).Value = oEmployee.Image;
                command.Parameters.Add("@Departament", SqlDbType.Int).Value = oEmployee.Departament;

                return connection.ExecuteQuery(command);
            } catch
            {
                return false;
            }
           
        }

        public bool Delete(EmployeeBLL oEmployee)
        {

            SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE ID=@ID");
            command.Parameters.Add("@ID", SqlDbType.Int).Value = oEmployee.ID;

            return connection.ExecuteQuery(command);

        }
        public bool Update(EmployeeBLL oEmployee)
        {
                SqlCommand command = new SqlCommand("UPDATE Employee SET firstname = @Name ,lastname = @Lastname,email = @Email,picture = @Image,idDepartament = @Departament WHERE ID=@ID");

                command.Parameters.Add("@ID", SqlDbType.Int).Value = oEmployee.ID;
                command.Parameters.Add("@Name", SqlDbType.VarChar).Value = oEmployee.Name;
                command.Parameters.Add("@Lastname", SqlDbType.VarChar).Value = oEmployee.Lastname;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = oEmployee.Email;
                command.Parameters.Add("@Image", SqlDbType.Image).Value = oEmployee.Image;
                command.Parameters.Add("@Departament", SqlDbType.Int).Value = oEmployee.Departament;

            return connection.ExecuteQuery(command);         
           

        }
        public DataSet GetEmployee()
        {
            SqlCommand command = new SqlCommand("SELECT id, firstname, lastname, email, idDepartament, picture FROM Employee");

            return connection.ExecuteSentence(command);
        }
    }
}
