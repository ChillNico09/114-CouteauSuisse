using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisseProjet
{
    static internal class Menu
    {
        public static int UserOptionChoice { get; private set; }
        public static bool ContinuePlaying { get; private set; } = true;
        public static bool InvalidInput { get; private set; } = false;
        private static int cursorTop_;
        private static int cursorLeft_;

        /// <summary>
        /// Va afficher les différentes options disponibles
        /// Va enregistrer les coordonées du curseur
        /// </summary>
        public static void DisplayOptions()
        {
            Console.Write("=== Couteau Suisse – Utilitaires ===\n" +
                "1. Convertir du texte en code Morse\n" +
                "2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)\n" +
                "3. (à venir)\n" +
                "4. Quitter\n" +
                "Veuillez entrer votre choix (numéro entre 1 et 4) : ");
            cursorLeft_ = Console.CursorLeft;
            cursorTop_ = Console.CursorTop;
        }

        /// <summary>
        /// Va prendre la saisie de l'utilisateur.
        /// </summary>
        public static void GetUserChoice()
        {
            bool valueValid = false;
            string userInput = Console.ReadLine();

            int chosenNumber = 0;
            while (!valueValid)
            {
                if(!int.TryParse(userInput, out chosenNumber))
                {
                    EraseUserInput(userInput);
                    userInput = Console.ReadLine();
                }
                else
                {
                    UserOptionChoice = chosenNumber;
                    if(UserOptionChoice >= 1 && UserOptionChoice <= 4)
                    {
                        valueValid = true;
                    }
                    else
                    {
                        EraseUserInput(userInput);
                        userInput = Console.ReadLine();
                    }
                }
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
                    Morse.ConvertLetterToMorse();
                    break;
                case 2:
                    Console.Clear();
                    InvalidInput = true;
                    break;
                case 3:
                    Console.Clear();
                    InvalidInput = true;
                    break;
                case 4:
                    ContinuePlaying = false;
                    break;
                default:
                    Console.Clear();
                    InvalidInput = true;
                    break;
            }
        }

        /// <summary>
        /// Va effacer l'input de l'utilisateur
        /// </summary>
        /// <param name="userInput">Ce que l'utilisateur a écrit</param>
        private static void EraseUserInput(string userInput)
        {
            Console.SetCursorPosition(cursorLeft_, cursorTop_);
            for (int i = 0; i < userInput.Length + userInput.Length; i++)
            {
                Console.Write(' ');
            }
            Console.SetCursorPosition(cursorLeft_, cursorTop_);
        }
    }
}
