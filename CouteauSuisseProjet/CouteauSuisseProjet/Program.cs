using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisseProjet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Menu.ContinuePlaying)
            {
                Menu.DisplayOptions();
                Menu.GetUserChoice();
                Menu.UserChoiceHandler();
                if (Menu.ContinuePlaying)
                {
                    if (!Menu.InvalidInput)
                    {
                        Console.WriteLine("Appuyer sur n'importe quel touche pour continuer");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
