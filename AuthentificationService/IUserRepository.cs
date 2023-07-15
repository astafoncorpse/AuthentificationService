using System.Collections.Generic;

namespace AuthentificationService
{
    public interface IUserRepository
    {
        User GetByLogin(string login);
        IEnumerable<User> GetAll();
    }

}
