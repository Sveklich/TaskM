using ConsoleApp7;
using System;
using System.Diagnostics;

internal class Program
{
    public static void Main()
    {
        Console.SetWindowSize(200, 48);
        Process[] processess = Process.GetProcesses();
        string[] proc = new string[processess.Length];
        TaskManager.ShowProcesses();
        int choice = Menu.Show(proc.Length);
        Console.Clear();
        Process[] processes = Process.GetProcessesByName(proc[choice]);
        TaskManager.ShowProcessDetails(processess[choice]);
        Process procName = processess[choice];
        Console.WriteLine("  Enter 'd' to terminate the process.");

        choice = Menu.Show(proc.Length);
        if (choice == -2)
        {
            TaskManager.TerminateProcess(procName);
        }
        else if (choice == -1)
        {
            Console.Clear();
            Main();
        }
    }
}