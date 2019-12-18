namespace Domain.Model
{
    public class UsersModel
    {
        public readonly UserModel[] UserModels;

        public UsersModel(UserModel[] userModels)
        {
            UserModels = userModels;
        }
    }
}