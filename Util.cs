using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.analytics;

namespace fastLPI.tools.decompiler.helper
{
    public static class Util
    {
        public static string RemoveSpaces(this string Text) =>
            Text.Replace(" ", "");

        public static Accesslevel GetAccesslevel(string text)
        {
            //Console.WriteLine($"!{text.ToLower()}!");

            if (text.ToLower().RemoveSpaces().Contains("publicfinal")) return Accesslevel.PublicFinal;
            else if (text.ToLower().RemoveSpaces().Contains("publicabstract")) return Accesslevel.PublicAbstract;
            else if (text.ToLower().RemoveSpaces().Contains("public")) return Accesslevel.Public;
            else if (text.ToLower().RemoveSpaces().Contains("private")) return Accesslevel.Private;
            else if (text.ToLower().RemoveSpaces().Contains("protected")) return Accesslevel.Protected;
            else if (text.ToLower().RemoveSpaces().Contains("default")) return Accesslevel.Default;
            else return Accesslevel.None;
        }

        public static string GetClassName(string text)
        {
            string subText = text.Replace(
                Regex.Match(text, Patterns.JavaClassStartPattern).Value, "");
            string outValue = "";

            foreach (char item in subText)
            {
                if (!Regex.IsMatch(item.ToString(), @"\w")) break;
                outValue += item;
            }

            return outValue.RemoveSpaces();
        }

        public static string GetInterfaceName(string text)
        {
            string subText = text.Replace(
                Regex.Match(text, Patterns.JavaInterfaceStartPattern).Value, "");
            string outValue = "";

            foreach (char item in subText)
            {
                if (!Regex.IsMatch(item.ToString(), @"\w")) break;
                outValue += item;
            }

            return outValue.RemoveSpaces();
        }

        public static string GetEnumName(string text)
        {
            string subText = text.Replace(
                Regex.Match(text, Patterns.JavaEnumStartPattern).Value, "");
            string outValue = "";

            foreach (char item in subText)
            {
                if (!Regex.IsMatch(item.ToString(), @"\w")) break;
                outValue += item;
            }

            return outValue.RemoveSpaces();
        }
    }
}