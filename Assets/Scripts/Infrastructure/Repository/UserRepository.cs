using System.Collections.Generic;
using Infrastructure.Entity;
using Application.UseCase;
using Zenject;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        [Inject]
        private IDatabase _database;

        public IEnumerable<UserEntity> FindAll()
        {
            var userEntities = _database.GetUsers();
            
            return userEntities;
        }
        
    }
}