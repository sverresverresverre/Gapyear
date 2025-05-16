using System;
using System.Runtime.InteropServices;


public class Gapyear
{
    private bool working = false;

    public void Job()
    {
        working = true;
    }

    public void Stats()
    {
        // berättar för användaren om påståendet stämmer eller inte
        Console.WriteLine($"Getting a job = {working}");
    }
}
