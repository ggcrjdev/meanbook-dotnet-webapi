namespace MeanBookApi.Controllers
{
    public class UsersLogoutResponse
    {
        public bool logggedOut { get; private set; }

        public UsersLogoutResponse(bool logggedOut)
        {
            this.logggedOut = logggedOut;
        }
    }
}
