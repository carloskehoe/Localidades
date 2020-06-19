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
    public class UsuariosRepository: IUsuariosRepository
    {
        string _connectionString;
        public UsuariosRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Usuario GetUser(int id)
        {
            Usuario user = new Usuario();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.QueryFirst<Usuario>("Select top 1 * From Users");
            }
            return user;
        }

        public Usuario GetUserId(int id)
        {
            Usuario user = new Usuario();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                user = db.QueryFirst<Usuario>($"Select * From Users where Id = {id}");
            }
            return user;
        }

        public Usuario InsertUser(Usuario user)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                try
                {
                    user = db.QueryFirstOrDefault<Usuario>($"INSERT INTO [dbo].[Users]([Id],[Nombre],[IdCiudad])VALUES({user.Id}, '{user.Nombre}', {user.IdCiudad})");
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
