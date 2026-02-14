using System.Text.Json;
using NotifyHub.Interfaces;
using NotifyHub.Models;

namespace NotifyHub.Services
{
    public class JsonFileStorageService : IFileStorageService
    {
        private readonly string _filePath = "notifications-log.json";
        private readonly SemaphoreSlim _semaphore = new(1, 1);

        public async Task SaveAsync(Notification notification)
        {
            try
            {
                await _semaphore.WaitAsync();

                var json = JsonSerializer.Serialize(notification);
                await File.AppendAllTextAsync(_filePath, json + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File write error: {ex.Message}");
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
