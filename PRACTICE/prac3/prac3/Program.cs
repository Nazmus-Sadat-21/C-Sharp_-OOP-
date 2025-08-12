using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3
{
    internal class Program
    {

        class Library
        {
            internal string libraryName = "Unknown";
            internal int totalBooks, shelfCount;
            internal double maintenanceCost;

            internal Library()
            {
                Console.WriteLine("Library initialized.");
                libraryName = "Central Library";
                totalBooks = 500;
                shelfCount = 25;
                maintenanceCost = shelfCount * 20.5;
                Console.WriteLine($"{libraryName} has {totalBooks} books and costs {++maintenanceCost} per month.");
            }

            internal Library(string name, int shelves)
            {
                this.libraryName = name;
                this.shelfCount = ++shelves;
                maintenanceCost = shelves * 30.0;
                Console.WriteLine($"{libraryName} setup with {shelfCount} shelves.");
                Console.WriteLine("Estimated Cost: " + maintenanceCost);
            }
        }

        class Book : Library
        {
            int pageCount = 100;

            internal Book(string name, int shelves) : base(name, shelves)
            {
                this.libraryName = name;
                Console.WriteLine("Book added to: " + libraryName);
                Console.WriteLine("Total Pages: " + pageCount * shelves);
                Console.WriteLine(ProcessChapters());
            }

            string ProcessChapters()
            {
                string[] chapters = { "Intro", "Basics", "OOP", "Advanced", "Summary" };
                Console.WriteLine("Chapters Count: " + chapters.Length);
                int count = 0;

                foreach (var ch in chapters)
                {
                    count++;
                    if (count == 2 || count == 4) continue;
                    Console.WriteLine($"Chapter {count}: {ch}");
                }

                return "Book Setup Complete";
            }
        }

        static void Main(string[] args)
        {

            Library lib1 = new Library();
            Console.WriteLine();
           
            Console.WriteLine();
            Book b1 = new Book("Community Library", 3);

        }
    }
}
