using System;
using static System.Console;
using MeuJogoRPG.src.Entities;

namespace MeuJogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Knight arus = new Knight("Arus", 1, "Knight", 899, 125, 5); 
            Wizard jennica = new Wizard("Jennica", 1, "White Wizard", 574, 389, 6); 
            BlackWizard topapa = new BlackWizard("Topapa", 1, "Black Wizard", 601, 348, 7);
            Ninja wedge = new Ninja ("Wedge", 1, "Ninja", 712, 261, 8);

            //Demonstração de propriedades de herói e de golpes possíveis de serem realizados

            WriteLine();
            WriteLine(arus.Name);
            WriteLine();
            WriteLine(arus);
            WriteLine(arus.Attack());
            WriteLine(arus.SpecialAttack());
            WriteLine();

            WriteLine(jennica.Name);
            WriteLine();
            WriteLine(jennica);
            WriteLine(jennica.Attack());
            WriteLine(jennica.SpecialAttack());
            WriteLine();

            WriteLine(topapa.Name);
            WriteLine();
            WriteLine(topapa);
            WriteLine(topapa.Attack());
            WriteLine(topapa.SpecialAttack());
            WriteLine();

            WriteLine(wedge.Name);
            WriteLine();
            WriteLine(wedge);
            WriteLine(wedge.Attack());
            WriteLine(wedge.SpecialAttack());

        }
    }
}
