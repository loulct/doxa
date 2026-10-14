using Microsoft.AspNetCore.SignalR;
using doxa.Shared.Models;

namespace doxa.Server.Hubs;

public class ChatHub : Hub
{
    public async Task JoinChannel(string channelId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, channelId);
    }

    public async Task SendMessage(ChatMessage message)
    {
        await Clients.Group(message.ChannelId.ToString()).SendAsync("ReceiveMessage", message);
    }
}
