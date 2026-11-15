using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Sys = Cosmos.Kernel.System;

namespace KDOS;

/// <summary>
/// Main kernel class - inherits from Cosmos.Kernel.System.Kernel.
/// </summary>
public class Kernel : Sys.Kernel
{
    private string currUser = "placeholder";
    private double ver = 0.1;
    protected override void BeforeRun()
    {
        Console.Write("Enter your username: ");
        currUser = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Welcome to KDOS {ver}!");

    }

    protected override void Run()
    {
        Console.Write("KDOS: ");
        var userCmd = Console.ReadLine();

        if (string.IsNullOrEmpty(userCmd))
            return;

        switch (userCmd.ToLower())
        {
            case "help":
                Console.WriteLine("help - Show this help message");
                Console.WriteLine("clear, cls - Clear the screen");
                Console.WriteLine("sysinfo - Show system info");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("shutdown - Shutdown the system");
                Console.WriteLine("reboot - Reboot the system");
                Console.ResetColor();
                break;

            case "sysinfo":
                Console.WriteLine($"KDOS Version {ver}");
                Console.WriteLine($"Logged in as: {currUser}");
                Console.WriteLine("Made by tallynerd");
                break;

            case "clear" or "cls":
                Console.Clear();
                break;

            case "shutdown":
                Console.WriteLine("Shutting down...");
                Sys.Power.Shutdown();
                break;

            case "reboot":
                Console.WriteLine("Rebooting...");
                Sys.Power.Reboot();
                break;

            default:
                Console.WriteLine($"\"{userCmd}\" is not a command");
                break;
        }
    }
}
