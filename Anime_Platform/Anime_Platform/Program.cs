using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Platform
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hero h1 = new Hero("Lufi","324","One Piece",900,"No",160);
            h1.ShowInfo();
            Console.WriteLine();
            Villain v1 = new Villain("madra","465","Naruto",80,"Win");
            v1.ShowInfo();
            Console.WriteLine();
            v1.EvilScore = 70;
            v1.ShowInfo();
            Console.WriteLine();
            h1.MainCharacter = "Yes";
            h1.ShowInfo();

        }
    }
}
