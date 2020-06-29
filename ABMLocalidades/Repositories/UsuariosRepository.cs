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

        public Compra GetCompra(int idUsuario)
        {
            Compra compra = new Compra();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Idusuario", idUsuario);
                compra = db.QueryFirstOrDefault<Compra>("SP_ComprasGet", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return compra;
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

        public Usuario GetUserByMail(string mail)
        {
           // Usuario usuario = new Usuario(); // solo para recibir lo de la base no usar como parametro
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Email", mail);

                return db.QueryFirstOrDefault<Usuario>("SP_UsuarioGetByMail", parameters, commandType: System.Data.CommandType.StoredProcedure);
           //return usuario;
            }

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
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Nombre", user.Nombre);
                parameters.Add("IdCiudad", user.IdCiudad);
                parameters.Add("IdRol", user.IdRol);
                parameters.Add("Email", user.Email);
                parameters.Add("Clave", user.Clave);
                try
                {
                    user = db.QueryFirstOrDefault<Usuario>("SP_UsuarioInsert", parameters, commandType: System.Data.CommandType.StoredProcedure);
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
