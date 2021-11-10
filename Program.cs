using System;
using MeuJogoRPG.src.Entities;

namespace MeuJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight arus = new Knight("Arus", 42, "Knight", 749, 72); 
            Wizard jennica = new Wizard("Jennica", 42, "White Wizard", 574, 89); 
            BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard", 601, 482);
            Ninja wedge = new Ninja ("Wedge", 42, "Ninja", 385, 641);
                  
            Console.WriteLine();
            Console.WriteLine(arus.Name);
            Console.WriteLine();
            Console.WriteLine(arus);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(arus.SpecialAttack(4));
            Console.WriteLine();
            Console.WriteLine(jennica.Name);
            Console.WriteLine();
            Console.WriteLine(jennica);
            Console.WriteLine(jennica.Attack());
            Console.WriteLine(jennica.SpecialAttack(7));
            Console.WriteLine();
            Console.WriteLine(topapa.Name);
            Console.WriteLine();
            Console.WriteLine(topapa);
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.SpecialAttack(4));
            Console.WriteLine();
            Console.WriteLine(wedge.Name);
            Console.WriteLine();
            Console.WriteLine(wedge);
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(wedge.SpecialAttack(7));

        }
    }
}
