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
    /// Va permettre de gérer l'interface et fonction pour diverse conversion de base.
    /// 
    /// Décimal (Base 10) - 0 à 9
    /// Binaire (Base 2)  - 0 à 1
    /// Octal (Base 8)    - 0 à 7
    /// </summary>
    static internal class Convertisseur
    {
        public static int UserOptionChoice { get; private set; }
        public static bool InvalidInput { get; private set; } = false;
        private static int cursorTop_;
        private static int cursorLeft_;

        /// <summary>
        /// Afficher les différentes options disponibles
        /// </summary>
        public static void DisplayOptions()
        {
            Console.Write("\n\n\n=== Convertisseur de bases ===\n" +
            "1. Décimal > Binaire\n" +
            "2. Binaire > Décimal\n" +
            "3. Binaire > Octal\n" +
            "4. Octal > Binaire\n" +
            "Veuillez entrer votre choix : ");
            cursorLeft_ = Console.CursorLeft;
            cursorTop_ = Console.CursorTop;
        }

        /// <summary>
        /// Convertir une valeur décimal en binaire
        /// </summary>
        public static void ConvertDecimalToBinary()
        {

        }

        /// <summary>
        /// Convertir une valeur binaire en décimal
        /// </summary>
        public static void ConvertBinaryToDecimal()
        {

        }

        /// <summary>
        /// Convertir une valeur binaire en octal
        /// </summary>
        public static void ConvertBinaryToOctal()
        {

        }

        /// <summary>
        /// Convertir une valeur octal en binaire
        /// </summary>
        public static void ConvertOctalToBinary()
        {

        }
    }
}
