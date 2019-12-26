using System.Collections.Generic;
using Infrastructure.Entity;
using Infrastructure.Repository;
using UnityEngine;

namespace Infrastructure.Database
{
    public class ScriptableObjectDatabase : IDatabase
    {
        public IEnumerable<UserEntity> GetUsers()
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