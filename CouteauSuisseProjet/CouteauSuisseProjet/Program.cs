///ETML
///Author : Nicolas Marques
///Date   : 11.11.2026
///Description : Un programe couteau Suisse avec plusieur outil à disposition (convertir en code morse. Convertisseur de base. Steganographie)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisseProjet
{
    /// <summary>
    /// Va permettre l'execution des différentes classes et de leur fonction.
    /// </summary>
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
