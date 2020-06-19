using ABMLocalidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Repositories
{
    public interface IUsuariosRepository
    {
        Usuario GetUser(int id);

        Usuario GetUserId(int id);

        Usuario InsertUser(Usuario user);
        
    }
}
