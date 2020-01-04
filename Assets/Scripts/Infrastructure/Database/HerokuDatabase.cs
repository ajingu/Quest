using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Infrastructure.Entity;
using Infrastructure.Repository;
using UnityEngine;

namespace Infrastructure.Database
{
    public class HerokuDatabase : IDatabase
    {
        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(@"https://ajingu-quest-server.herokuapp.com/users/all");
                var usersJson = await response.Content.ReadAsStringAsync();
                var usersEntity = JsonUtility.FromJson<UsersEntity>("{\"users\":" + usersJson + "}");
                Debug.Log(usersEntity.users[0].name);
                /*
                string userJson = System.IO.File.ReadAllText(UnityEngine.Application.dataPath + "/Resources/JSON/user.json");
                Debug.Log(userJson);
                var userEntity = JsonUtility.FromJson<UserEntity>(userJson);
                Debug.LogFormat("{0}, {1}, {2}", userEntity.id, userEntity.name, userEntity.isPaid);
                
                var usersJson = System.IO.File.ReadAllText(UnityEngine.Application.dataPath + "/Resources/JSON/users.json");
                Debug.Log(usersJson);
                var usersEntity = JsonUtility.FromJson<UsersEntity>("{\"users\":" + usersJson + "}");
                Debug.Log(usersEntity.users[0].name);
                */
                
                return usersEntity.users;
            }
        }
    }
    
    
}