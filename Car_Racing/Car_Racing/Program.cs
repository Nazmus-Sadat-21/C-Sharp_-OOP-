using System;
using System.Collections.Generic;
using System.Threading;

namespace Car_Racing
{
    // Base Car Class
    public abstract class Car
    {
        public string Name { get; private set; }
        public double Position { get; private set; } = 0;
        public double Speed { get; protected set; } // meters per turn

        public Car(string name)
        {
            Name = name;
        }

        public virtual void Drive()
        {
            Position += Speed;
        }

        public bool HasFinished(double trackLength)
        {
            return Position >= trackLength;
        }
    }

    // Sports Car - Faster acceleration
    public class SportsCar : Car
    {
        public SportsCar(string name) : base(name)
        {
            Speed = 20; // m/turn
        }

        public override void Drive()
        {
            Speed += 0.5; // accelerates over time
            base.Drive();
        }
    }

    // Truck - Slower but stable
    public class Truck : Car
    {
        public Truck(string name) : base(name)
        {
            Speed = 15;
        }

        public override void Drive()
        {
            base.Drive();
        }
    }

    // Formula One Car - Very fast but can slow down randomly
    public class FormulaOneCar : Car
    {
        private Random rand = new Random();

        public FormulaOneCar(string name) : base(name)
        {
            Speed = 25;
        }

        public override void Drive()
        {
            if (rand.Next(1, 10) == 5) // random slowdown
            {
                Speed -= 5;
                Console.WriteLine($"{Name} hit a minor issue and slowed down!");
            }
            else
            {
                Speed += 1;
            }
            base.Drive();
        }
    }

    // Track Class
    public class Track
    {
        public double Length { get; private set; }
        public string SurfaceType { get; private set; }

        public Track(double length, string surfaceType)
        {
            Length = length;
            SurfaceType = surfaceType;
        }
    }

    // Race Class
    public class Race
    {
        private List<Car> cars;
        private Track track;

        public Race(Track track)
        {
            this.track = track;
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void StartRace()
        {
            Console.WriteLine($"🏁 Race started on {track.SurfaceType} track ({track.Length} meters)!\n");
            bool raceFinished = false;

            while (!raceFinished)
            {
                foreach (var car in cars)
                {
                    car.Drive();
                    Console.WriteLine($"{car.Name} is at {car.GetType().Name} position: {car.Position:0.0}m");

                    if (car.HasFinished(track.Length))
                    {
                        Console.WriteLine($"\n🏆 {car.Name} ({car.GetType().Name}) has won the race!");
                        raceFinished = true;
                        break;
                    }
                }

                Console.WriteLine();
                Thread.Sleep(500); // small delay for simulation
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Track track = new Track(200, "Asphalt");

            Race race = new Race(track);
            race.AddCar(new SportsCar("Lightning"));
            race.AddCar(new Truck("BigFoot"));
            race.AddCar(new FormulaOneCar("Speedster"));

            race.StartRace();

            Console.ReadLine();
        }
    }
}
