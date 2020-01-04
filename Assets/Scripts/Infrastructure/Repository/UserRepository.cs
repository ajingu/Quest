using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;
using Application.UseCase;
using Zenject;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        [Inject]
        private IData _data;

        public async Task<IEnumerable<UserEntity>> FindAll()
        {
            var userEntities = await _data.GetUsers();
            
            return userEntities;
        }
        
    }
}