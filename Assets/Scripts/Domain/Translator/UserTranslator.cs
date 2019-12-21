using System.Collections.Generic;

using Data.Entity;
using Domain.Model;

namespace Domain.Translator
{
    public static class UserTranslator
    {
        public static UserModel[] Translate(IEnumerable<UserEntity> userEntities)
        {
            var usersList = new List<UserModel>();

            foreach (var userEntity in userEntities)
            {
                var userModel = new UserModel(userEntity.Id, userEntity.Name, userEntity.IsPaid);
                usersList.Add(userModel);
            }
            
            return usersList.ToArray();
        }
    }
}