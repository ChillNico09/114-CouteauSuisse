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
        private static string numberToEnter_;
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
        /// Gère si l'utilisateur choisi une méthode de conversion ou s'il doit entrer un nombre
        /// </summary>
        /// <param name="isChoosingBase">Si l'utilisateur choisit une méthode de conversion</param>
        public static void GetUserChoice(bool isChoosingBase)
        {
            if (isChoosingBase)
            {
                UserOptionChoice = Helper.GetUserChoice(1, 4, cursorLeft_, cursorTop_);
            }
            else
            {
                Console.Write($"Entrer un nombre en {numberToEnter_} : ");
                cursorLeft_ = Console.CursorLeft;
                cursorTop_ = Console.CursorTop;
                UserOptionChoice = Helper.GetUserChoice(int.MinValue, int.MaxValue, cursorLeft_, cursorTop_);
            }
        }

        /// <summary>
        /// Va gérer le choix de l'utilisateur
        /// </summary>
        public static void UserChoiceHandler()
        {
            switch (UserOptionChoice)
            {
                case 1:
                    numberToEnter_ = "décimal";
                    GetUserChoice(false);
                    ConvertDecimalToBinary(UserOptionChoice);
                    break;
                case 2:
                    numberToEnter_ = "binaire (ignore tout chiffre pas égal à 1 ou 0)";
                    GetUserChoice(false);
                    ConvertBinaryToDecimal(UserOptionChoice);
                    break;
                case 3:
                    numberToEnter_ = "binaire";
                    ConvertBinaryToOctal();
                    break;
                case 4:
                    numberToEnter_ = "octale";
                    ConvertOctalToBinary();
                    break;
                default:
                    Console.Clear();
                    InvalidInput = true;
                    break;
            }
        }

        /// <summary>
        /// Convertir une valeur décimal en binaire
        /// </summary>
        /// <param name="userDecimalValue">La valeur entrez par l'utilisateur</param>
        public static void ConvertDecimalToBinary(double userDecimalValue)
        {
            string binaryValue = "";
            double lastValue = 0;
            double currentNumber = userDecimalValue * 2;
            int reste = 0;
            while(currentNumber > 1)
            {
                lastValue = currentNumber;
                currentNumber = Math.Floor(lastValue / 2);
                reste = (int)currentNumber % 2;
                binaryValue += reste;
            }
            string reversedBinaryValue = new string(binaryValue.Reverse().ToArray()); 
            Console.WriteLine(reversedBinaryValue);
        }

        /// <summary>
        /// Convertir une valeur binaire en décimal
        /// </summary>
        public static void ConvertBinaryToDecimal(int userBinaryValue)
        {
            int exposantValue = 0;
            string binaryValue = new string(userBinaryValue.ToString().Reverse().ToArray());
            int decimalValue = 0;
            foreach(char bit in binaryValue)
            {
                double twoToPower = Math.Pow(2, exposantValue);
                int singleDecimalValue = 0;
                switch (bit)
                {
                    case '0':
                        decimalValue = CalculateBinaryToDecimal(singleDecimalValue, twoToPower, decimalValue, true);
                        exposantValue++;
                        break;
                    case '1':
                        decimalValue = CalculateBinaryToDecimal(singleDecimalValue, twoToPower, decimalValue, false);
                        exposantValue++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(decimalValue);
        }
        /// <summary>
        /// Va calculez et additioner
        /// </summary>
        /// <param name="singleDecimalValue">La valeur du bit binaire en décimal (parti de la valeur totale)</param>
        /// <param name="twoToPower">2 à la puissance d'exposant</param>
        /// <param name="decimalValue">La valeur décimal a rajouté au total de la conversion</param>
        /// <param name="isZero">Si le bit est égal à 0 ou non</param>
        /// <returns>Une partie de la valeur décimal final</returns>
        private static int CalculateBinaryToDecimal(int singleDecimalValue, double twoToPower, int decimalValue, bool isZero)
        {
            int bitValue = isZero ? 0 : 1;
            singleDecimalValue = bitValue * (int)twoToPower;
            decimalValue += singleDecimalValue;
            return decimalValue;
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
