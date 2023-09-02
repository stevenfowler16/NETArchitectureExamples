using BirdWranglers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdWranglerInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomizeColors();

            Console.WriteLine("Creating Wrangler");
            var birdCapacity = 10;
            var birdWrangler = new BirdWrangler(birdCapacity);

            Console.WriteLine("Creating Blue Bird");
            var blueBird = new Bird(12, "Blue", "Blue Jay");

            Console.WriteLine("Adding Blue Bird To Wrangler's Care");
            birdWrangler.AddBirdToCare(blueBird);

            Console.WriteLine("Feeding Birds");
            birdWrangler.FeedBirds();

            Console.WriteLine("Press any key to exit");

            Console.ReadKey();
        }

        static void CustomizeColors()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
