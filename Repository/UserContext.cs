using Microsoft.EntityFrameworkCore;
using UserLogin_API.Model;

namespace UserLogin_API.Repository
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString: "server=127.0.0.1;Port=3306;database=userlogin;user=root;password=mysql_123");
        }
    }
}
