using ABMLocalidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABMLocalidades.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int id);

        User GetUserId(int id);

        User InsertUser(User user);
    }
}
