namespace MeanBookApi.Controllers
{
    public class UsersCurrentResponse
    {
        public bool authenticated { get; private set; }
	    public string username { get; private set; }

        public UsersCurrentResponse(bool authenticated, string username)
        {
            this.authenticated = authenticated;
            this.username = username;
        }
    }
}
