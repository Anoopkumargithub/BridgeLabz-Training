using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_linkedlist.circular_linkedlist
{
    internal class TaskSchedulerSystem
    {
        // Node Class
        internal class TaskNode
        {
            public int TaskId;
            public string TaskName;
            public int Priority;
            public string DueDate;

            public TaskNode next;

            public TaskNode(int id, string name, int priority, string dueDate)
            {
                TaskId = id;
                TaskName = name;
                Priority = priority;
                DueDate = dueDate;
                next = null;
            }
        }

        // Circular Linked List Class
        internal class TaskCircularLinkedList
        {
            private TaskNode head;
            private TaskNode current;

            // Add at Beginning
            public void AddAtBeginning(int id, string name, int priority, string dueDate)
            {
                TaskNode newNode = new TaskNode(id, name, priority, dueDate);

                if (head == null)
                {
                    head = newNode;
                    newNode.next = head;
                    current = head;
                }
                else
                {
                    TaskNode temp = head;
                    while (temp.next != head)
                    {
                        temp = temp.next;
                    }

                    newNode.next = head;
                    temp.next = newNode;
                    head = newNode;
                }
            }

            // Add at End
            public void AddAtEnd(int id, string name, int priority, string dueDate)
            {
                TaskNode newNode = new TaskNode(id, name, priority, dueDate);

                if (head == null)
                {
                    head = newNode;
                    newNode.next = head;
                    current = head;
                }
                else
                {
                    TaskNode temp = head;
                    while (temp.next != head)
                    {
                        temp = temp.next;
                    }

                    temp.next = newNode;
                    newNode.next = head;
                }
            }

            // Add at Specific Position (1-based)
            public void AddAtPosition(int position, int id, string name, int priority, string dueDate)
            {
                if (position <= 1)
                {
                    AddAtBeginning(id, name, priority, dueDate);
                    return;
                }

                TaskNode currentNode = head;
                int index = 1;

                while (currentNode.next != head && index < position - 1)
                {
                    currentNode = currentNode.next;
                    index++;
                }

                TaskNode newNode = new TaskNode(id, name, priority, dueDate);
                newNode.next = currentNode.next;
                currentNode.next = newNode;
            }

            // Remove by Task ID
            public void RemoveByTaskId(int id)
            {
                if (head == null)
                {
                    Console.WriteLine("Task list is empty");
                    return;
                }

                TaskNode temp = head;
                TaskNode prev = null;

                do
                {
                    if (temp.TaskId == id)
                    {
                        if (prev == null)
                        {
                            TaskNode last = head;
                            while (last.next != head)
                            {
                                last = last.next;
                            }

                            if (head.next == head)
                            {
                                head = current = null;
                            }
                            else
                            {
                                last.next = head.next;
                                head = head.next;
                                current = head;
                            }
                        }
                        else
                        {
                            prev.next = temp.next;
                        }

                        Console.WriteLine("Task removed: " + id);
                        return;
                    }

                    prev = temp;
                    temp = temp.next;

                } while (temp != head);

                Console.WriteLine("Task not found");
            }

            // View Current Task & Move Next
            public void ViewCurrentTask()
            {
                if (current == null)
                {
                    Console.WriteLine("No tasks available");
                    return;
                }

                DisplayTask(current);
                current = current.next;
            }

            // Display All Tasks
            public void DisplayAllTasks()
            {
                if (head == null)
                {
                    Console.WriteLine("No tasks to display");
                    return;
                }

                TaskNode temp = head;
                Console.WriteLine("\nAll Tasks:");

                do
                {
                    DisplayTask(temp);
                    temp = temp.next;
                } while (temp != head);
            }

            // Search by Priority
            public void SearchByPriority(int priority)
            {
                if (head == null)
                {
                    Console.WriteLine("No tasks available");
                    return;
                }

                TaskNode temp = head;
                bool found = false;

                do
                {
                    if (temp.Priority == priority)
                    {
                        DisplayTask(temp);
                        found = true;
                    }
                    temp = temp.next;
                } while (temp != head);

                if (!found)
                {
                    Console.WriteLine("No tasks found with priority: " + priority);
                }
            }

            // Helper Method
            private void DisplayTask(TaskNode task)
            {
                Console.WriteLine(
                    $"Task ID: {task.TaskId}, Name: {task.TaskName}, Priority: {task.Priority}, Due: {task.DueDate}"
                );
            }
        }

        // Main Class
        class Program
        {
            static void Main(string[] args)
            {
                TaskCircularLinkedList scheduler = new TaskCircularLinkedList();

                scheduler.AddAtEnd(1, "Design Module", 1, "2026-01-10");
                scheduler.AddAtBeginning(2, "Fix Bugs", 2, "2026-01-08");
                scheduler.AddAtEnd(3, "Write Tests", 3, "2026-01-12");
                scheduler.AddAtPosition(2, 4, "Code Review", 1, "2026-01-09");

                scheduler.DisplayAllTasks();

                Console.WriteLine("\nCurrent Task Rotation:");
                scheduler.ViewCurrentTask();
                scheduler.ViewCurrentTask();
                scheduler.ViewCurrentTask();

                scheduler.SearchByPriority(1);

                scheduler.RemoveByTaskId(3);
                scheduler.DisplayAllTasks();
            }
        }
    }
}
