using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamondK
{
    public class Diamond
    {
        private const char FirstLetter = 'A';
        private const char PaddingChar = ' ';
        private const string LineSeparator = "\n";


        public static string Create(char middleCharacter)
        {
            if (middleCharacter == FirstLetter) return "A";

            return CreateFullDiamond(CreateHalfDiamond(middleCharacter));
        }

        private static List<string> CreateHalfDiamond(char middleCharacter)
        {
            var lines = new List<string>();
            int paddingLeft = middleCharacter - FirstLetter;
            int length = paddingLeft + 1;
            int paddingMiddle = 1;

            foreach (var character in Enumerable.Range('A', middleCharacter + 1 - 'A'))
            {
                lines.Add(CreateDiamondLine(paddingLeft, character, paddingMiddle));

                paddingMiddle = ++length - --paddingLeft - 2;
            }
            return lines;
        }

        private static string CreateFullDiamond(List<string> halfDiamondRaw)
        {
            var halfDiamond = string.Join(LineSeparator, halfDiamondRaw);
            halfDiamondRaw.Reverse();
            return halfDiamond + LineSeparator + string.Join(LineSeparator, halfDiamondRaw.Skip(1));
        }

        private static string CreateDiamondLine(int paddingLeft, int character, int paddingMiddle)
        {
            var letter = Convert.ToChar(character);
            var line = string.Empty.PadLeft(paddingLeft, PaddingChar) + letter;

            if (letter != FirstLetter)
            {
                line += string.Empty.PadLeft(paddingMiddle, PaddingChar) + letter;
            }
            return line;
        }
    }
}