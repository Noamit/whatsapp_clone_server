using Microsoft.AspNetCore.SignalR;

namespace whatsapp_WEBAPI.Hubs
{
    public class ChatsHub : Hub
    {
        public async Task connectUserToServer(string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, user);
        }

    }
}
