using AuthentificationService.DAL.Entities;
using System.Collections.Generic;

namespace AuthentificationService.BLL.Interfaces
{
    public interface IUserRepository
    {
        User GetByLogin(string login);
        IEnumerable<User> GetAll();
    }

}
