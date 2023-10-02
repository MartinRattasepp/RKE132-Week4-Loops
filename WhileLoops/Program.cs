
Random rnd = new Random();
int cpuRandom;

bool loopactive = true; //bool - true/fals

while (loopactive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess, Enter a number 1-3");

    int usernumber = Int32.Parse(Console.ReadLine());

    if (usernumber == cpuRandom)
    {
        Console.WriteLine("Congratulation, you won!");
        //loopactive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops, try again.");
    }
}

Console.WriteLine("Have a nice day");