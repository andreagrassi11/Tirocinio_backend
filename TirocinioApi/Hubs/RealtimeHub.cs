using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TirocinioApi.DataStructure;

namespace TirocinioApi.Hubs;

public class RealtimeHub : Hub
{
    private readonly ILogger<RealtimeHub> _logger;
    private int _connectedClientsCount;


    public RealtimeHub(ILogger<RealtimeHub> logger)
    {
        _logger = logger;
    }

    public override async Task OnConnectedAsync()
    {
        _logger.LogInformation($"A new user connected: {Context.ConnectionId}");
        _connectedClientsCount++;
        await base.OnConnectedAsync();
        await Clients.All.SendAsync("ClientCountUpdated", _connectedClientsCount);
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
        _logger.LogInformation($"User disconnected: {Context.ConnectionId}");
        _connectedClientsCount--;
        await base.OnDisconnectedAsync(exception);
        await Clients.All.SendAsync("ClientCountUpdated", _connectedClientsCount);
    }

    [HubMethodName("SendMessageToServer")]
    public async Task SendMessageToServer(Dictionary<string, object> message)
    {
        await Clients.Others.SendAsync("ReceiveMessage", message);
    }
}

