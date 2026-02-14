using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Services
{
    public class NotificationProcessor : INotificationProcessor
    {
        private readonly INotificationQueue _queue;
        private readonly INotificationSenderFactory _senderFactory;
        private readonly int _workerCount;

        private readonly List<Task> _workers = new();
        private CancellationTokenSource? _internalCts;

        public NotificationProcessor(
            INotificationQueue queue,
            INotificationSenderFactory senderFactory,
            int workerCount = 4)
        {
            _queue = queue;
            _senderFactory = senderFactory;
            _workerCount = workerCount;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            for (int i = 0; i < _workerCount; i++)
            {
                _workers.Add(Task.Run(() => WorkerLoop(_internalCts.Token)));
            }

            return Task.CompletedTask;
        }

        public async Task StopAsync()
        {
            if (_internalCts != null)
            {
                _internalCts.Cancel();
                await Task.WhenAll(_workers);
            }
        }

        private async Task WorkerLoop(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var notification = await _queue.DequeueAsync(cancellationToken);

                    await ProcessNotificationAsync(notification, cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    break; // graceful shutdown
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[WORKER ERROR] {ex.Message}");
                }
            }
        }

        private async Task ProcessNotificationAsync(
            Notification notification,
            CancellationToken cancellationToken)
        {
            try
            {
                notification.MarkAsProcessing();

                var sender = _senderFactory.GetSender(notification.Type);

                await sender.SendAsync(notification, cancellationToken);

                notification.MarkAsSent();

                Console.WriteLine($"[SUCCESS] Notification {notification.NotificationId} sent.");
            }
            catch (Exception ex)
            {
                notification.MarkAsFailed(ex.Message);

                Console.WriteLine(
                    $"[FAILED] Notification {notification.NotificationId} failed: {ex.Message}");
            }
        }
    }
}
