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
    /// Va permettre d'avoir l'affichage principale du programe. Et de continuer d'éxecuter le programe.
    /// </summary>
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

        public static void GetUserChoice()
        {
            UserOptionChoice = Helper.GetUserChoice(1, 4, cursorLeft_, cursorTop_);
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
                    Convertisseur.DisplayOptions();
                    Convertisseur.GetUserChoice(true);
                    //Convertisseur.GetUserChoice(false);
                    Convertisseur.UserChoiceHandler();
                    
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

    }
}
