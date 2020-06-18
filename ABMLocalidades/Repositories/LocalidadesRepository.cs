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
    public class LocalidadesRepository: ILocalidadesRepository
    {
        string _connectionString;
        public LocalidadesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Pais> GetPaises()
        {
            List<Pais> paises = new List<Pais>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("");
                paises = db.Query<Pais>("SP_PaisesGet").ToList();
            }
            return paises;
        }

        public List<Provincia> GetProvincias(int paisId)
        {
            List<Provincia> provincias = new List<Provincia>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("paisId", paisId);
                provincias = db.Query<Provincia>($"SP_ProvinciasGet", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
            return provincias;
        }

        public List<Ciudad> GetCiudades(int idProvincia)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("IdProvincia", idProvincia);
                ciudades = db.Query<Ciudad>("SP_CiudadesGet", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
            return ciudades;
        }

        public Ciudad InsertCiudad(Ciudad ciudad)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Nombre", ciudad.Nombre);
                parameters.Add("IdProvincia", ciudad.IdProvincia);
                try
                {
                    ciudad = db.QueryFirstOrDefault<Ciudad>("SP_CiudadesInsert",parameters,commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (Exception e)
                {

                    throw;
                }

            }
            return ciudad;
        }

        public Ciudad UpdateCiudad(Ciudad ciudad)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Nombre", ciudad.Nombre);
                parameters.Add("Id", ciudad.Id);
                ciudad = db.QueryFirstOrDefault<Ciudad>("SP_CiudadesUpdate", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
            return ciudad;
        }
    }
}
