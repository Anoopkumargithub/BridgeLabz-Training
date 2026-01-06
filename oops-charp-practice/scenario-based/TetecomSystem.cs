using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class CallLog
    {
        private string phoneNumber;
        private string message;
        private DateTime timeStamp;

        public CallLog(string phoneNumber, string message, DateTime timeStamp)
        {
            this.phoneNumber = phoneNumber;
            this.message = message;
            this.timeStamp = timeStamp;
        }

        public string PhoneNumber { get { return phoneNumber; } }
        public string Message { get { return message; } }
        public DateTime TimeStamp { get { return timeStamp; } }

        public override string ToString()
        {
            return "Phone : " + phoneNumber +
                   "\nMessage : " + message +
                   "\nTime : " + timeStamp +
                   "\n-----------------------";
        }
    }

    // interface

    internal interface ICallLogService
    {
        void AddCallLog(string phone, string message);
        void SearchByKeyword(string keyword);
        void FilterByTime(DateTime start, DateTime end);
    }

    // utility

    internal class CallLogUtility : ICallLogService
    {
        private CallLog[] logs;
        private int count;

        public CallLogUtility(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }

        public void AddCallLog(string phone, string message)
        {
            if (count < logs.Length)
            {
                logs[count] = new CallLog(phone, message, DateTime.Now);
                count++;
                Console.WriteLine("Call log added successfully");
            }
            else
            {
                Console.WriteLine("Storage full");
            }
        }

        public void SearchByKeyword(string keyword)
        {
            for (int i = 0; i < count; i++)
            {
                if (logs[i].Message.Contains(keyword))
                {
                    Console.WriteLine(logs[i].ToString());
                }
            }
        }

        public void FilterByTime(DateTime start, DateTime end)
        {
            for (int i = 0; i < count; i++)
            {
                if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
                {
                    Console.WriteLine(logs[i].ToString());
                }
            }
        }
    }

    internal class CallLogMenu
    {
        private ICallLogService service;   

        public CallLogMenu(ICallLogService service)
        {
            this.service = service;
        }

        public void ShowMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n--- Call Log Menu ---");
                Console.WriteLine("1. Add Call Log");
                Console.WriteLine("2. Search by Keyword");
                Console.WriteLine("3. Filter by Time");
                Console.WriteLine("4. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLog();
                        break;

                    case 2:
                        SearchLog();
                        break;

                    case 3:
                        FilterLog();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);
        }

        private void AddLog()
        {
            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Message: ");
            string msg = Console.ReadLine();

            service.AddCallLog(phone, msg);
        }

        private void SearchLog()
        {
            Console.Write("Enter keyword: ");
            string key = Console.ReadLine();

            service.SearchByKeyword(key);
        }

        private void FilterLog()
        {
            Console.Write("Enter start hours ago: ");
            int startHour = int.Parse(Console.ReadLine());

            Console.Write("Enter end hours ago: ");
            int endHour = int.Parse(Console.ReadLine());

            DateTime start = DateTime.Now.AddHours(-startHour);
            DateTime end = DateTime.Now.AddHours(-endHour);

            service.FilterByTime(start, end);
        }
    }

    class TelecomSystem
    {
        public static void Main(string[] args)
        {
            ICallLogService service = new CallLogUtility(10); // UPCASTING
            CallLogMenu menu = new CallLogMenu(service);

            menu.ShowMenu();
        }
    }
}
