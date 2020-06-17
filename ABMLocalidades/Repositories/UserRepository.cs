using ABMLocalidades.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Repositories
{
    public class UserRepository: IUserRepository
    {
        string _connectionString;
        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public User GetUser(int id)
        {
            User user = new User();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.QueryFirst<User>("Select top 1 * From Users");
            }
            return user;
        }

        public User GetUserId(int id)
        {
            User user = new User();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.QueryFirst<User>($"Select * From Users where Id = {id}");
            }
            return user;
        }

        public User InsertUser(User user)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                try
                {
                    user = db.QueryFirstOrDefault<User>($"INSERT INTO [dbo].[Users]([Id],[Nombre],[IdLocalidad])VALUES({user.Id}, '{user.Nombre}', {user.IdLocalidad})");
                }
                catch (Exception e)
                {

                    throw;
                }

            }
            return user;
        }

    }
}
