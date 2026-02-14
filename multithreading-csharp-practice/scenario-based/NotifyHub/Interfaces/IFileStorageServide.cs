using System;
using NotifyHub.Models;

namespace NotifyHub.Interfaces
{
    public interface IFileStorageService
    {
        Task SaveAsync(Notification notification);
    }
}
