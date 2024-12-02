// See https://aka.ms/new-console-template for more information
Console.WriteLine("CountDown for rocket launch ");
/* For Loops 

 */

for (int counter = 15; counter >= 1; counter--)
{
    Console.WriteLine(counter + " Seconds left");
    Thread.Sleep(1000);
    Console.Clear();
}

Console.ReadLine();