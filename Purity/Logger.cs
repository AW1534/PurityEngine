using System;
namespace Purity;


public static class Logger {
    
    public static void Log(string txt) {
        Console.WriteLine(txt);
    }

    public static void Warn(string txt) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("WARNING: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(txt + "\n");
    }

    public static void Critical(string txt) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("CRITICAL: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(txt + "\n");
    }

    public static void Error(string txt) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("ERROR: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(txt + "\n");
        System.Environment.Exit(1);
    }
}