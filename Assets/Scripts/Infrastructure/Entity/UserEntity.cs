namespace Infrastructure.Entity
{
    [System.Serializable]
    public class UserEntity
    {
        public int id;
        public string name;
        public bool isPaid;
/*
        public UserEntity(int id, string name, bool isPaid)
        {
            Id = id;
            Name = name;
            IsPaid = isPaid;
        }*/
    }

    [System.Serializable]
    public class UsersEntity
    {
        public UserEntity[] users;
    }
}