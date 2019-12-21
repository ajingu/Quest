using Data.Entity;

namespace Domain.UseCase
{
    public interface IUserRepository
    {
        UserEntity[] GetUsers();
    }
}
