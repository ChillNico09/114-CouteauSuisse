using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouteauSuisseProjet
{
    static internal class Helper
    {
        /// <summary>
        /// Va prendre la saisie de l'utilisateur.
        /// </summary>
        public static int GetUserChoice(int minChoice, int maxChoice, int cursorLeft, int cursorTop)
        {
            bool valueValid = false;
            string userInput = Console.ReadLine();

            int chosenNumber = 0;
            while (!valueValid)
            {
                if (!int.TryParse(userInput, out chosenNumber))
                {
                    EraseUserInput(userInput, cursorLeft, cursorTop);
                    userInput = Console.ReadLine();
                }
                else
                {
                    if (chosenNumber >= minChoice && chosenNumber <= maxChoice)
                    {
                        valueValid = true;
                    }
                    else
                    {
                        EraseUserInput(userInput, cursorLeft, cursorTop);
                        userInput = Console.ReadLine();
                    }
                }
            }
            return chosenNumber;
        }

        /// <summary>
        /// Va effacer l'input de l'utilisateur
        /// </summary>
        /// <param name="userInput">Ce que l'utilisateur a écrit</param>
        private static void EraseUserInput(string userInput, int cursorLeft, int cursorTop)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop);
            for (int i = 0; i < userInput.Length + userInput.Length; i++)
            {
                Console.Write(' ');
            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }

    }
}
