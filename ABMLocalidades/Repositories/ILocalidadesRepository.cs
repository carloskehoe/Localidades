using ABMLocalidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Repositories
{
    public interface ILocalidadesRepository
    {
        List<Pais> GetPaises();

        List<Provincia> GetProvincias(int paisId);

        List<Ciudad> GetCiudades(int provinciaId);

        Ciudad InsertCiudad(Ciudad ciudad);

        Ciudad UpdateCiudad(Ciudad ciudad);
    }
}
