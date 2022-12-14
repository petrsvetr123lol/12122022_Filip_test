using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace _12122022_Filip_test
{
    public class SqlRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employees;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int RecordCount { get; private set; }

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
                            employees.Add(new Employee(
                                sqlDataReader["FirstName"].ToString(),
                                sqlDataReader["LastName"].ToString(),
                                sqlDataReader["Phone"].ToString(),
                                sqlDataReader["Email"].ToString(),
                                Convert.ToDateTime(sqlDataReader["BirthDate"])
                                )
                                );
                        }
                    }
                }
                sqlConnection.Close();
            }
            return employees;
        }

        public void CreateEmployee(Employee employee)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "insert into employee(FirstName,LastName,Phone,Email,BirthDate) values(@FirstName,@LastName,@Phone,@Email,@BirthDate)";
                    cmd.Parameters.AddWithValue("FirstName",employee.FirstName);
                    cmd.Parameters.AddWithValue("LastName",employee.LastName);
                    cmd.Parameters.AddWithValue("Phone", employee.Phone);
                    cmd.Parameters.AddWithValue("Email", employee.Email);
                    cmd.Parameters.AddWithValue("BirthDate", employee.Birthdate);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }

        public void RemoveEmployees(string lastName)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Employee WHERE LastName=@LastName";
                    sqlCommand.Parameters.AddWithValue("LastName", lastName);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public void UpdateEmployee()
        {

        }
        public void OldestEmployee()
        {

        }
        public void YoungestEmployee()
        {
        
        }
        public void AvgEmployee()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT ";
                }
            }
        }
        public int CountEmployee()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using(SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT COUNT(*) FROM Employee";
                    RecordCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
                   
                }
                sqlConnection.Close();


            }
           return RecordCount;
        } 
    }
}

