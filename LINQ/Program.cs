using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;


namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] videoGameNames = {"Stardew Valley", "Mike Tyson's Punch-Out",
                "NCAA Football 2014", "Red Dead Redemption 2", "Civilization 5",
                "Hotline Miami", "Tony Hawk's Pro Skater 2", "Donkey Kong Country", "WCW/NWO Revenge"};

            videoGameNames.OrderByDescending(game => game.Length).ToList().ForEach(game => Console.WriteLine(game));
        }
    }
}
