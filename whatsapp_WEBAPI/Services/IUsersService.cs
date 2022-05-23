using Microsoft.AspNetCore.Mvc;

namespace whatsapp_WEBAPI.Services
{
    public interface IUsersService
    {

        public Task<int> Login(string id, User logginUser);
        public Task<int> Register(User newUser);

    }
}
