using final_authorization_and_authorization.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace final_authorization_and_authorization.Services
{
    public class UserService : IUserService
    {

        private string connectionString = "Data Source=syn-sql-01; Initial Catalog = viraj.langhnoda; User ID = viraj.langhnoda; Password=Viraj@!@#$%^";

        List<User> userList = new List<User>();
        private readonly List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "admin", Role = "Admin" },
            new User { Id = 2, Username = "user", Password = "user", Role = "User" }
            
        };

        public User Authenticate(string username, string password)
        {
            GetAllUsers();
            var user = userList.SingleOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }

        public List<User> GetAllUsers()
        {
SqlConnection con = new SqlConnection(connectionString);

        string sqlQuery = "SELECT * FROM [dbo].[Users]";

        SqlCommand sqlcomm = new SqlCommand(sqlQuery, con);

        con.Open();

            SqlDataReader reader = sqlcomm.ExecuteReader();


        userList.Clear();
 
            while (reader.Read())

            {

                User project = new User

                {

                    Id = Convert.ToInt32(reader["Id"]),

                    Username = reader["Username"].ToString(),

                    Password = reader["Password"].ToString(),

                    Role = reader["Role"].ToString()

                };

        userList.Add(project);

            }

    con.Close();

            return userList;
        }
    }
}
