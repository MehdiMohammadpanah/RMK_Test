using Microsoft.EntityFrameworkCore;
using Domain.User;
using Microsoft.AspNetCore.Identity;

namespace Persistence.Seeds

{
    public class DataBaseContextSeed
    {
        private static readonly PasswordHasher<User> _passwordHasher = new PasswordHasher<User>(); 
        public static void UserSeed(ModelBuilder modelBuilder)
        {
            foreach (var user in GetUser())
            {
                modelBuilder.Entity<User>().HasData(user);
            }
        }
        private static IEnumerable<User> GetUser()
        {
            var users = new List<User>();
            users.Add(new User { Id = Guid.NewGuid(), Username = "admin", Password = _passwordHasher.HashPassword(new User(), "admin"), Role = "role_admin"}); 
            users.Add(new User { Id = Guid.NewGuid(), Username = "user", Password = _passwordHasher.HashPassword(new User(), "user"), Role = "role_user" });
            return users;
        }
    }
}
