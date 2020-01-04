using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Entity;
using Infrastructure.Repository;
using UnityEngine;

namespace Infrastructure.Data
{
    [CreateAssetMenu]
    public class UserData : ScriptableObject
    {
        public UserEntity[] userStatuses;
    }
    
    public class ScriptableObjectData : IData
    {
        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
            var userData = Resources.Load<UserData>("MasterData/UserData");

            var userEntitiesList = new List<UserEntity>();
            foreach (var userStatus in userData.userStatuses)
            {
                var userEntity = new UserEntity(userStatus.id, userStatus.name, userStatus.isPaid);
                
                userEntitiesList.Add(userEntity);
            }
            
            return userEntitiesList.ToArray();
        }
    }
}