using Data.Entity;

namespace Domain.Model
{
   public class UserModel
   {
      public readonly int Id;
      public readonly string Name;
      public readonly int Money;

      public UserModel(UserEntity userEntity)
      {
          Id = userEntity.Id;
          Name = userEntity.Name;
          Money = userEntity.Money;
      }
   }
}