namespace Infrastructure.Entity
{
    [System.Serializable]
    public class UserEntity
    {
        // must be same as json attributes
        public int id;
        public string name;
        public bool isPaid;

        public UserEntity(int id, string name, bool isPaid)
        {
            this.id = id;
            this.name = name;
            this.isPaid = isPaid;
        }
    }

    [System.Serializable]
    public class UsersEntity
    {
        public UserEntity[] users;
    }
}