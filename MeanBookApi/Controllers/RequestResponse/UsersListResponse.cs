using MeanBookApi.Models;
using System.Collections.Generic;

namespace MeanBookApi.Controllers
{
    public class UsersListResponse
    {
        public IList<User> users { get; private set; }

        public UsersListResponse(IList<User> users)
        {
            this.users = users;
        }
    }
}
