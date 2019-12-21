using Data.Entity;

namespace Data.DataStore
{
    public interface IUserNetwork
    {
        UserEntity[] GetUsers();
    }
}
