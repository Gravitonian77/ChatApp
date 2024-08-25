using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{

    private readonly ILogger<ChatHub> _logger;

    public ChatHub(ILogger<ChatHub> logger){
        _logger = logger;
    }

    public async Task SendMessage(string user, string message)
    {
        _logger.LogInformation($"Message received from {user}: {message}");

        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
