Console.WriteLine("What will you do during your gap year?");

// instans av klassen
Gapyear gap = new Gapyear();

Console.WriteLine("1. Get a job?");
Console.WriteLine("2. Don't get a job?");

string doWhat = Console.ReadLine();
if (doWhat == "1")
{
    // metoderna som aktiveras
    gap.Job();
    gap.Stats();
}
else if (doWhat == "2")
{
    gap.Stats();
}
else
{
    Console.WriteLine("Not a legit answer, start over");
}
Console.ReadLine();
