using Globomantics.Models;

namespace Globomantics.Repositories;

public class UserRepository : IUserRepository
{
    private List<UserModel> users = new () 
    {
        new UserModel { Id = 123, Name = "test", Password = "", Role = "Admin", FavoriteColor = "green" }
    };

    public UserModel? GetByUsernameAndPassword(string username, string password)
    {
        var user = users.SingleOrDefault(
            u => u.Name && u.Password == password.Sha256());
        return user;
    }
}