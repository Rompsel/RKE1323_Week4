Random rnd = new Random();
int cpuRandom;
bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number between 1-3.");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine($"Congratulations, you won! Number {cpuRandom} was correct awnser.");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine($"Oops! Try again, because number {userNumber} is not correct awnser!");
    }
}
Console.WriteLine("Have a nice day!");