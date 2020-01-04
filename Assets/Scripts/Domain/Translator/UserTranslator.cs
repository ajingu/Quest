using System.Collections.Generic;

using Infrastructure.Entity;
using Domain.Model;

namespace Domain.Translator
{
    public static class UserTranslator
    {
        public static IEnumerable<User> Translate(IEnumerable<UserEntity> userEntities)
        {
            var usersList = new List<User>();

            foreach (var userEntity in userEntities)
            {
                var user = new User(userEntity.id, userEntity.name, userEntity.isPaid);
                usersList.Add(user);
            }
            
            return usersList.ToArray();
        }
    }
}