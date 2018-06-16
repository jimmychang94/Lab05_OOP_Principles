using System;
using Lab05_OOP_Principles.Classes;

namespace Lab05_OOP_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Proof();
        }

        /// <summary>
        /// This just tests that the classes inherit properties
        /// </summary>
        static void Proof()
        {
            ChannelCatfish channelCatfish = new ChannelCatfish();
            FlatheadCatfish flatheadCatfish = new FlatheadCatfish();
            TigerShark tigerShark = new TigerShark();
            GreatWhiteShark greatWhiteShark = new GreatWhiteShark();
            EmperorPenguin emperorPenguin = new EmperorPenguin();
            GalapagosPenguin galapagosPenguin = new GalapagosPenguin();
            Mallard mallard = new Mallard();
            MandarinDuck mandarinDuck = new MandarinDuck();
            PrairieFalcon prairieFalcon = new PrairieFalcon();
            Gyrfalcon gyrfalcon = new Gyrfalcon();
            Dragon dragon = new Dragon();
            KomodoDragon komodoDragon = new KomodoDragon();
            Anaconda anaconda = new Anaconda();
            Rattlesnake rattlesnake = new Rattlesnake();
            Dhole dhole = new Dhole();
            TundraWolf tundraWolf = new TundraWolf();
            HouseCat houseCat = new HouseCat();
            Jaguar jaguar = new Jaguar();

            Console.WriteLine($"channel catfish gets food: {channelCatfish.FoodAquisition()}");
            Console.WriteLine($"flathead catfish habitat: {flatheadCatfish.Habitat}");
            Console.WriteLine($"great white shark cares for young?: {greatWhiteShark.CaresForYoung}");
            Console.WriteLine($"tiger shark move: {tigerShark.FastestMovement()}");
            Console.WriteLine($"emperor penguin swims?: {emperorPenguin.Sing()}");
            Console.WriteLine($"galapagos penguin moves: {galapagosPenguin.FastestMovement()}");
            Console.WriteLine($"mallard sound: {mallard.Sound()}");
            Console.WriteLine($"mandarin duck does barrel roll?: {mandarinDuck.BarrelRoll()}");
            Console.WriteLine($"gyrfalcon does barrel roll?: {gyrfalcon.BarrelRoll()}");
            Console.WriteLine($"prairie falcon sound: {prairieFalcon.Sound()}");
            Console.WriteLine($"dragon does barrel roll?: {dragon.BarrelRoll()}");
            Console.WriteLine($"komodo dragon birth: {komodoDragon.Birth()}");
            Console.WriteLine($" anaconda swims?: {anaconda.Sing()}");
            Console.WriteLine($" rattlesnake gets food: {rattlesnake.FoodAquisition()}");
            Console.WriteLine($"dhole gets food: {dhole.FoodAquisition()}");
            Console.WriteLine($"dhole birth: {dhole.Birth()}");
            Console.WriteLine($"tundra wolf move: {tundraWolf.FastestMovement()}");
            Console.WriteLine($"house cat gets food: {houseCat.FoodAquisition()}");
            Console.WriteLine($"jaguar can climb?: {jaguar.CanClimb}");
        }
    }
}
