using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NotifyHub.Interfaces;
using NotifyHub.Models;
using NotifyHub.Infrastructure;
using NotifyHub.Senders;
using NotifyHub.Services;
using NotifyHub.Factories;

namespace NotifyHub
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting NotifyHub...");

            // ===== Infrastructure =====
            INotificationQueue queue = new InMemoryPriorityQueue();

            // ===== Senders =====
            var senders = new List<INotificationSender>
            {
                new EmailNotificationSender(),
                new SmsNotificationSender(),
                new AppNotificationSender()
            };

            INotificationSenderFactory factory =
                new NotificationSenderFactory(senders);

            // ===== Validation + Intake =====
            INotificationValidator validator = new NotificationValidator();
            INotificationIntakeService intakeService =
                new NotificationIntakeService(validator, queue);

            // ===== Processor =====
            INotificationProcessor processor =
                new NotificationProcessor(queue, factory, workerCount: 4);

            using var cts = new CancellationTokenSource();

            await processor.StartAsync(cts.Token);

            Console.WriteLine("Processor started.\n");

            // ===== Simulate Incoming Notifications =====
            GenerateTestNotifications(intakeService);

            Console.WriteLine("\nPress ENTER to stop...");
            Console.ReadLine();

            await processor.StopAsync();

            Console.WriteLine("NotifyHub stopped.");
        }

        private static void GenerateTestNotifications(
            INotificationIntakeService intakeService)
        {
            var notifications = new List<Notification>
            {
                new Notification(
                    notificationId: "1",
                    recipient: "user1@example.com",
                    message: "Welcome Email!",
                    priority: NotificationPriority.High)
                {
                    Type = NotificationType.Email
                },
                new Notification(
                    notificationId: "2",
                    recipient: "+919999999999",
                    message: "Your OTP is 1234",
                    priority: NotificationPriority.Critical)
                {
                    Type = NotificationType.Sms
                },
                new Notification(
                    notificationId: "3",
                    recipient: "appUser",
                    message: "You have a new alert",
                    priority: NotificationPriority.Medium)
                {
                    Type = NotificationType.AppAlert
                },
                new Notification(
                    notificationId: "4",
                    recipient: "fail@example.com",
                    message: "This will fail",
                    priority: NotificationPriority.High)
                {
                    Type = NotificationType.Email
                }
            };

            foreach (var notification in notifications)
            {
                if (!intakeService.TryAccept(notification, out string reason))
                {
                    Console.WriteLine(
                        $"[REJECTED] {notification.NotificationId}: {reason}");
                }
                else
                {
                    Console.WriteLine(
                        $"[ACCEPTED] {notification.NotificationId} queued.");
                }
            }
        }
    }
}
