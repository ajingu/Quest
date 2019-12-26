using UniRx;

namespace Domain.Model
{
   public class User
   {
      public readonly int Id;
      public StringReactiveProperty Name = new StringReactiveProperty();
      public BoolReactiveProperty IsPaid = new BoolReactiveProperty();

      public User(int id, string name, bool isPaid)
      {
          Id = id;
          Name.Value = name;
          IsPaid.Value = isPaid;
      }
   }
}