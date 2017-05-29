using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a simple message to the user.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // Process any incoming args.
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            // Process any incoming args using foreach.
            foreach (string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            // Get arguments using System.Environment.
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            // Helper method within the Program class.
            ShowEnvironmentDetails();

            // Wait for Enter key to be pressed before shutting down.
            Console.ReadLine();

            // Return an arbitrary error code.
            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Driver: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
            Console.WriteLine("ExitCode: {0}", Environment.ExitCode);
            Environment.ExitCode = -1;
            Console.WriteLine("ExitCode: {0}", Environment.ExitCode);
            Console.WriteLine("Is64bitOS: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Is64bitProcess: {0}", Environment.Is64BitProcess);
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("SystemDirectory: {0}", Environment.SystemDirectory);
            Console.WriteLine("UserName: {0}", Environment.UserName);
            Console.WriteLine("CommandLine: {0}", Environment.CommandLine);
            Console.WriteLine("CurrentDirectory: {0}", Environment.CurrentDirectory);
            Console.WriteLine("CurrentManagedThreadId: {0}", Environment.CurrentManagedThreadId);
            Console.WriteLine("Windows Path: {0}", Environment.GetFolderPath(Environment.SpecialFolder.Windows));
            Console.WriteLine("HasShutdownStarted: {0}", Environment.HasShutdownStarted);
            Console.WriteLine("SystemPageSize: {0}", Environment.SystemPageSize);
            Console.WriteLine("TickCount: {0}", Environment.TickCount);
            Console.WriteLine("UserDomainName: {0}", Environment.UserDomainName);
            Console.WriteLine("UserInteractive: {0}", Environment.UserInteractive);
            Console.WriteLine("WorkingSet: {0}", Environment.WorkingSet);
        }
    }
}
