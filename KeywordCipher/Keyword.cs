using System;
using System.Collections.Generic;
using System.Text;

namespace KeywordCipher
{
    class Keyword
    {
        private char[] charValues = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private char[] numChar = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };


        public string Encrypt(string message, string keyword)
        {
            string returnMessage = "";
            int shiftValue = 0;
            int count = 0;
            foreach (char ch in message.ToCharArray())
            {
                if (count == keyword.Length)
                {
                    count = 0;
                }
                shiftValue = GetShiftValue(keyword[count]);
                returnMessage += GetChar(ch, shiftValue);
                count++;
            }
            return returnMessage;
        }

        public int GetShiftValue(char c)
        {
            int shiftValue = 0;
            if (Char.IsDigit(c))
            {
                shiftValue = Array.IndexOf(numChar, c);
            }
            else
            {
                shiftValue = Array.IndexOf(charValues, c);
            }
            return shiftValue;
        }
        public char GetChar(char character, int shiftValue)
        {
            if (character == ' ') { return character; }
            int index = Array.IndexOf(charValues, character);
            int newindex = shiftValue + index;
            char returnCharacter = character;
            if (newindex > 25)
            {
                returnCharacter = charValues[newindex - 25];
            }
            else
            {
                returnCharacter = charValues[newindex];
            }
            return returnCharacter;
        }
    }
}
