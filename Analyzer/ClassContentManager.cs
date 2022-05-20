using System;
using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.analytics
{
    public class ClassContentManager
    {
        public static string GetClassContent(string text, int index) =>
            GetContentInBrackets(DeleteJunk(text, index));

        private static string DeleteJunk(string text, int index) =>
            text.Remove(0, index);

        /*private static string _GetContentInBrackets(string text)
        {
            string OutValue = "";
            bool Start = false;
            int BracketsState = 0;

            foreach (char item in text)
            {
                if (!Start && item == '{')
                {
                    Start = true;
                    BracketsState++;
                    continue;
                }
                else if (Start)
                {
                    if (item == '{')
                    {
                        BracketsState++;
                        if (BracketsState > 0) OutValue += item;
                        continue;
                    }
                    if (item == '}')
                    {
                        BracketsState--;
                        if (BracketsState > 0) OutValue += item;
                        continue;
                    }
                    if (BracketsState <= 0) break;

                    OutValue += item;
                }
            }

            return OutValue;
        }*/
        private static string GetContentInBrackets(string text)
        {
            string SubValue = text.Replace(Regex.Match(text, Patterns.AnyClassPattern).Value, "");
            SubValue = Regex.Match(SubValue, Patterns.AnyClassStructurePattern).Value;
            SubValue = SubValue.Remove(0, 1);
            SubValue = SubValue.Remove(SubValue.Length - 1, 1);
            string OutValue = SubValue;

            GC.Collect();

            return OutValue;
        }
    }
}
