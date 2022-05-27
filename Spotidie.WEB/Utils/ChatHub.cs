namespace Spotidie.Utils;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    public async Task SendMessage(string message, string userName)
    {
        await Clients.All.SendAsync("ReceiveMessage", message, userName);
    }
}