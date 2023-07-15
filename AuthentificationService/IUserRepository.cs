namespace AuthentificationService
{
    public interface IUserRepository
    {
      
        void IEnumerable<User> GetAll();

         void UserGetByLogin(string login);
    }

}
