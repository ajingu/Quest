using System.Collections.Generic;

using Data.Entity;
using Domain.Model;

namespace Domain.Translator
{
    public static class UserTranslator
    {
        public static UsersModel Translate(IEnumerable<UserEntity> userEntities)
        {
            var usersList = new List<UserModel>();

            foreach (var userEntity in userEntities)
            {
                var userModel = new UserModel(userEntity);
                usersList.Add(userModel);
            }
            
            var usersModel = new UsersModel(usersList.ToArray());
            return usersModel;
        }
    }
}