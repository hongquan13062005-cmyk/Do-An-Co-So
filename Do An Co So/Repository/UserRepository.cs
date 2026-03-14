using Do_An_Co_So.Models;

namespace Do_An_Co_So.Repositories
{
    public class UserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User { Id=1, Username="admin", Password="123", Role="Admin" }
        };

        public User GetUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Register(User user)
        {
            users.Add(user);
        }
    }
}