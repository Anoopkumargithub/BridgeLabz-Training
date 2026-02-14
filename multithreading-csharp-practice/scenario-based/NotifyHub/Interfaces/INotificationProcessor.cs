using System;
using System.Threading;
using System.Threading.Tasks;

namespace NotifyHub.Interfaces
{
    public interface INotificationProcessor
    {
        Task StartAsync(CancellationToken cancellationToken);

        Task StopAsync();
    }
}
