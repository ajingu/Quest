using Data.Entity;

namespace Domain.Repository
{
    public interface IUserDataStore
    {
        UserEntity[] GetUsers();
    }
}
