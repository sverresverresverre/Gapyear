Console.WriteLine("What will you do during your gap year?");

// instans av klassen
Gapyear gap = new Gapyear();

Console.WriteLine("1. Get a job?");

string doWhat = Console.ReadLine();
if (doWhat == "1")
{
    // metoderna som aktiveras
    gap.Job();
    gap.Stats();
}
else
{
    gap.Stats();
}
Console.ReadLine();
