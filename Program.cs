using System;

namespace RPG_Poo.src.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            hero Arus = new Arus("Arus", 14, "knight");
            Malefus oponente = new Arus("Malefus", 99, "Devil");
            hero Jessica = new Arus("jessica", 20, "white wizzard");
            hero Wedge = new Wedge("Wedge", 30, "ninja");
            hero Topapa = new Topapa("Topapa", 40, "Devil");


            Console.WriteLine(Arus.Attack());
            Console.WriteLine(oponente);
            Console.WriteLine(Jessica.Attack(1));
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Topapa.Attack(1));
        }
    }
}
