using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;
using Infrastructure.Repository;
using UnityEngine;

namespace Infrastructure.Database
{
    public class ScriptableObjectDatabase : IDatabase
    {
        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
            var userData = Resources.Load<UserData>("MasterData/UserData");

            var userEntitiesList = new List<UserEntity>();
            foreach (var userStatus in userData.userStatuses)
            {
                //var userEntity = UserEntity(userStatus.id, userStatus.name, userStatus.isPaid);
                var userEntity = new UserEntity();
                userEntity.id = userStatus.id;
                userEntity.name = userStatus.name;
                userEntity.isPaid = userStatus.isPaid;
                
                userEntitiesList.Add(userEntity);
            }
            
            return userEntitiesList.ToArray();
        }
    }
}