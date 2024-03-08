using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list
{
    internal class Program
    {

        static List<string> tasks = new List<string>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                DisplayTasks();

                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. Delete task");
                Console.WriteLine("3. Mark the task as completed");
                Console.WriteLine("0. Go out");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        AddTask();
                        break;
                    case '2':
                        RemoveTask();
                        break;
                    case '3':
                        MarkTaskAsDone();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nWrong choice. Try again.");
                        break;
                }
            }
        }

        static void DisplayTasks()
        {
            Console.WriteLine("List of tasks:");

            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void AddTask()
        {
            Console.WriteLine("\nEnter a new task:");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
        }

        static void RemoveTask()
        {
            Console.WriteLine("\nEnter the number of the task you want to delete:");

            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void MarkTaskAsDone()
        {
            Console.WriteLine("\n Enter the number of the task you completed: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.WriteLine($"Done: {tasks[taskNumber - 1]}");
                tasks.RemoveAt(taskNumber - 1);
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}