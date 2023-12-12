using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public static class TaskManager
    {
        public static void ShowProcesses()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                Console.WriteLine($"  Process Name: {process.ProcessName} | Physical Memory Usage: {process.WorkingSet64} bytes | Virtual Memory Usage: {process.VirtualMemorySize64} bytes");
            }
        }

        public static void ShowProcessDetails(Process process)
        {
            try
            {
                Console.WriteLine($"  Process ID: {process.Id}");
                Console.WriteLine($"  Process Name: {process.ProcessName}");
                Console.WriteLine($"  Start Time: {process.StartTime}");
                Console.WriteLine($"  Total Processor Time: {process.TotalProcessorTime}");
                Console.WriteLine($"  Priority: {process.PriorityClass}");
                Console.WriteLine($"  Physical Memory Usage: {process.WorkingSet64} bytes");
                Console.WriteLine($"  Virtual Memory Usage: {process.VirtualMemorySize64} bytes");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error: {ex.Message}");
            }
        }

        public static void TerminateProcess(Process process)
        {
            try
            {
                process.Kill();
                Console.WriteLine($"  Process {process.ProcessName} terminated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error: {ex.Message}");
            }
        }

        public static void TerminateAllProcesses(string processName)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }

                Console.WriteLine($"  All processes with name '{processName}' terminated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  Error: {ex.Message}");
            }
        }
    }
}

