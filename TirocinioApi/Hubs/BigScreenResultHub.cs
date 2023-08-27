using System;
using Microsoft.AspNetCore.SignalR;
using TirocinioApi.DataStructure;

namespace TirocinioApi.Hubs;

public class BigScreenResultHub : Hub
{
    private readonly ILogger<RealtimeHub> _logger;
    private static int _connectedClientsCount = 0;


    public BigScreenResultHub(ILogger<RealtimeHub> logger)
    {
        _logger = logger;
    }

    public override async Task OnConnectedAsync()
    {
        _logger.LogInformation($"A new user connected: {Context.ConnectionId}");
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
        _logger.LogInformation($"User disconnected: {Context.ConnectionId}");
        await base.OnDisconnectedAsync(exception);
    }

    [HubMethodName("SendMessageToBigScreen")]
    public async Task SendMessageToBigScreen(Dictionary<string, object> message)
    {
        await Clients.Others.SendAsync("ReceiveMessageBigScreen", message);
    }
}