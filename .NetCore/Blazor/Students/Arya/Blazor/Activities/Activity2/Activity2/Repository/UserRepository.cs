using Activity2.Data;
using Activity2.Interface;

namespace Activity2.Repository
{
    public class UserRepository:IUserRepository
    {
        public readonly AppDbContext context;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

       public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public User GetUser(string Email, string Password)
        {
            return context.Users.FirstOrDefault(x =>
                x.Email == Email &&
                x.Password == Password);
        }

    }
}
