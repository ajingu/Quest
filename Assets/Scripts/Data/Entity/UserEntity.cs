namespace Data.Entity
{
    public struct UserEntity
    {
        public readonly int Id;
        public readonly string Name;
        public readonly int Money;

        public UserEntity(int id, string name, int money)
        {
            Id = id;
            Name = name;
            Money = money;
        }
    }
}