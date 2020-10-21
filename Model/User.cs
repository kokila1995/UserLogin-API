using System.ComponentModel.DataAnnotations;

namespace UserLogin_API.Model
{
    public class User
    {
            
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

