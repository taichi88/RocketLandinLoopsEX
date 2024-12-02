// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;



string rocket = "       ^       \r\n" +
            "      / \\      \r\n" +
            "     /   \\     \r\n" +
            "    /_____\\    \r\n" +
            "    |     |    \r\n" +
            "    |     |    \r\n" +
            "    |     |    \r\n" +
            "   /|     |\\   \r\n" +
            "  /         \\  \r\n" +
            " /___________\\ \r\n" +
            "///////\\\\\\\\    \\ \r\n" +
            "||||||||||||||||";




for (int counter = 8; counter >= 1; counter--)
{
    Console.Clear();
    Console.WriteLine(counter + " Seconds left");
    Console.WriteLine(rocket);
    rocket = "\r\n\r\n" + rocket;
    Thread.Sleep(1000);
    
}
Console.WriteLine("The rocket has Landed");
Console.ReadLine();