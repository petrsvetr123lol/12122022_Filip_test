using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _12122022_Filip_test
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "select * from Employee";
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            var employee = new Employee()
                            {
                                Id = Convert.ToInt32(sqlDataReader["Id"]),
                                FirstName = sqlDataReader["Firstname"].ToString(),
                                LastName = sqlDataReader["Lastname"].ToString(),
                                Phone = sqlDataReader["Phone"].ToString(),
                                Email = sqlDataReader["Email"].ToString(),
                                Birthdate = Convert.ToDateTime(sqlDataReader["Birthdate"])
                            };
                            employees.Add(employee);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }

        /*
        public List<Employee> InsertEmployees()
        {
            
        }
        */
        

    }
}

