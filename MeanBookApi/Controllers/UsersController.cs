using MeanBookApi.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace MeanBookApi.Controllers
{
    public class UsersController : ApiController
    {
        private static IList<User> onlineUsers = new List<User>();

        [ActionName("list")]
        public UsersListResponse GetList()
        {
            return new UsersListResponse(onlineUsers);
        }

        [ActionName("current")]
        public UsersCurrentResponse PostCurrent()
        {
            return new UsersCurrentResponse(false, null);
        }

        [ActionName("login")]
        public User PostLogin([FromBody] UsernameRequest req)
        {
            User user = new User(req.username);
            onlineUsers.Add(user);
            return user;
        }

        [ActionName("logout")]
        public UsersLogoutResponse PostLogout([FromBody] UsernameRequest req)
        {
            onlineUsers.Remove(new User(req.username));
            return new UsersLogoutResponse(true);
        }
    }
}
