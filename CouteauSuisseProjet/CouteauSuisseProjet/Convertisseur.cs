///ETML
///Author : Nicolas Marques
///Date   : 011.11.2026
///Description : Un programe couteau Suisse avec plusieur outil à disposition (convertir en code morse. Convertisseur de base. Steganographie)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisseProjet
{
    static internal class Convertisseur
    {
        public static int UserOptionChoice { get; private set; }

        public static void DisplayOptions()
        {
            Console.Write("\n\n\n=== Convertisseur de bases ===\n" +
            "1. Décimal > Binaire\n" +
            "2. Binaire > Décimal\n" +
            "3. Binaire > Octal\n" +
            "4. Octal > Binaire\n" +
            "Veuillez entrer votre choix : ");
        }

        public static void ConvertDecimalToBinary(string userInput)
        {

        }

        public static void ConvertBinaryToDecimal(string userInput)
        {

        }

        public static void ConvertBinaryToOctal(string userInput)
        {

        }

        public static void ConvertOctalToBinary(string userInput)
        {

        }
    }
}
