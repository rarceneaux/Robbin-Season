using System;

namespace Robbin__Season
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan you Robbery Big Pat");

            var robber1 = new Robber();

            Console.WriteLine("Please enter Robber Name");
            robber1.Name = Console.ReadLine();

            Console.WriteLine("Please enter robber's skill level between 0 to 10.");
            robber1.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter robber's courage factor 0.0 to 2.0");
            robber1.CougarFactor = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{robber1.Name} has robbing skill: {robber1.SkillLevel} and courage factor of {robber1.CougarFactor}");
        }
    }
}
