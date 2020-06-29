using ABMLocalidades.Entities;
using Microsoft.AspNetCore.SignalR;
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
        Usuario GetUserByMail(string mail);

        Usuario InsertUser(Usuario user);

        Compra GetCompra(int id);
        
    }
}
