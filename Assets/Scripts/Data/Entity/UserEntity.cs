namespace Data.Entity
{
    public struct UserEntity
    {
        public readonly int Id;
        public readonly string Name;
        public readonly bool IsPaid;

        public UserEntity(int id, string name, bool isPaid)
        {
            Id = id;
            Name = name;
            IsPaid = isPaid;
        }
    }
}