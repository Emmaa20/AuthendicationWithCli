using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithCli.ApplicationLogic.Validations
{
    internal class Validation
    {
        public static bool isLengthBetween(string text, int start, int end)
        {
            return text.Length >= start && text.Length < end;

        }
        public static bool isLengthBetween(string text, int start)
        {
            return text.Length >= start;

        }

        public static bool Contains(string text, char targetCharacter)
        {
            foreach (int character in text)
            {
                if (targetCharacter == character)
                {
                    return true;
                }

            }
            return false;


        }
    }
}