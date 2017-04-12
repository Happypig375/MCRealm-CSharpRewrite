using System;

namespace MCRealm
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jar = "";
            while (true)
            {
                var Command = Console.ReadLine();
                var Content = Command.Substring(Command.IndexOf(' ') + 1);
                switch (Command.Remove(Command.IndexOf(' ')).ToLowerInvariant())
                {
                    case "jar":
                        Jar = Content;
                        break;
                    case "start":
                        break;
                    case var s when s.StartsWith("/"):
                        break;
                    default:
                        break;
                    case "print":
                        Console.WriteLine(Content);
                        break;
                    case "end":
                        goto Exit;
                }
            }
            Exit:;
        }
    }
}