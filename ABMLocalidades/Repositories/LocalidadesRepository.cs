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
                paises = db.Query<Pais>("Select * From Pais").ToList();
            }
            return paises;
        }
        public List<Provincia> GetProvincias(int paisId)
        {
            List<Provincia> provincias = new List<Provincia>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                provincias = db.Query<Provincia>($"Select * From Provincia where IdPais = {paisId}").ToList();
            }
            return provincias;
        }
        public List<Ciudad> GetCiudades(int ProvinciaId)
        {
            List<Ciudad> Ciudades = new List<Ciudad>();
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                Ciudades = db.Query<Ciudad>($"Select * From Ciudades where IdProvincia = {ProvinciaId}").ToList();
            }
            return Ciudades;
        }
        public Ciudad InsertCiudad(Ciudad ciudad)
        {

            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                try
                {
                    ciudad = db.QueryFirstOrDefault<Ciudad>($"INSERT INTO [dbo].[Ciudades]([Nombre],[IdProvincia])VALUES('{ciudad.Nombre}', {ciudad.IdProvincia})");
                }
                catch (Exception e)
                {

                    throw;
                }

            }
            return ciudad;
        }
    }
}
