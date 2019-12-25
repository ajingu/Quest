using Data.DataStore;
using Data.Entity;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Network
{
    public class ScriptableObjectUserNetwork : IUserNetwork
    {
        public UserEntity[] GetUsers()
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