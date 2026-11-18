using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CouteauSuisseProjet
{
    static internal class Morse
    {
        /// <summary>
        /// Cette méthode demande à l'utilisateur d'entrer un mot pour le convertir en code morse.
        /// S'il y a des accents, il les remets en lettre normale.
        /// Si c'est des caractères non supporté, il ignore.
        /// </summary>
        public static void ConvertLetterToMorse()
        {
            Console.Write("Entrez votre texte : ");
            string userText = Console.ReadLine();

            userText = userText.Normalize(NormalizationForm.FormD);
            var normalizedText = userText.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
            string upperCaseText = new string(normalizedText).Normalize(NormalizationForm.FormC).ToUpper();
            string morseText = "";

            foreach (var letter in upperCaseText)
            {
                switch (letter)
                {
                    case 'A':
                        morseText += ".-";
                        break;
                    case 'B':
                        morseText += "-...";
                        break;
                    case 'C':
                        morseText += "-.-.";
                        break;
                    case 'D':
                        morseText += "-..";
                        break;
                    case 'E':
                        morseText += ".";
                        break;
                    case 'F':
                        morseText += "..-.";
                        break;
                    case 'G':
                        morseText += "--.";
                        break;
                    case 'H':
                        morseText += "....";
                        break;
                    case 'I':
                        morseText += "..";
                        break;
                    case 'J':
                        morseText += ".---";
                        break;
                    case 'K':
                        morseText += "-.-";
                        break;
                    case 'L':
                        morseText += ".-..";
                        break;
                    case 'M':
                        morseText += "--";
                        break;
                    case 'N':
                        morseText += "-.";
                        break;
                    case 'O':
                        morseText += "---";
                        break;
                    case 'P':
                        morseText += ".--.";
                        break;
                    case 'Q':
                        morseText += "--.-";
                        break;
                    case 'R':
                        morseText += ".-.";
                        break;
                    case 'S':
                        morseText += "...";
                        break;
                    case 'T':
                        morseText += "-";
                        break;
                    case 'U':
                        morseText += "..-";
                        break;
                    case 'V':
                        morseText += "...-";
                        break;
                    case 'W':
                        morseText += ".--";
                        break;
                    case 'X':
                        morseText += "-..-";
                        break;
                    case 'Y':
                        morseText += "-.--";
                        break;
                    case 'Z':
                        morseText += "--..";
                        break;
                    case '0':
                        morseText += "-----";
                        break;
                    case '1':
                        morseText += ".----";
                        break;
                    case '2':
                        morseText += "..---";
                        break;
                    case '3':
                        morseText += "...--";
                        break;
                    case '4':
                        morseText += "....-";
                        break;
                    case '5':
                        morseText += ".....";
                        break;
                    case '6':
                        morseText += "-....";
                        break;
                    case '7':
                        morseText += "--...";
                        break;
                    case '8':
                        morseText += "---..";
                        break;
                    case '9':
                        morseText += "----.";
                        break;
                    case ' ':
                        morseText += "/";
                        break;
                    default:
                        break;
                }
                morseText += " ";
            }
            Console.WriteLine($"Résultat de la conversion en code morse :\n{morseText}");
        }
    }
}
