using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UserLogin_API.Repository;
using Newtonsoft.Json;


namespace UserLogin.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpGet("LoginUser")]
        public string LoginUser(string username, string password)
        {
            try
            {
                var dbContext = new UserContext();
                var users = dbContext.User.FirstOrDefault(u => u.Username == username && u.Password == password);
                return JsonConvert.SerializeObject(users);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
