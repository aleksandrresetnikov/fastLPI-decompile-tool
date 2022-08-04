using System;
using System.Text.RegularExpressions;

//using fastLPI.tools.decompiler.analytics;
using fastLPI.tools.decompiler.data;

namespace fastLPI.tools.decompiler.helper
{
    public static class Util
    {
        public static string GetLokationFolder() => (Environment.CurrentDirectory);

        public static string RemoveSpaces(this string Text) =>
            Text.Replace(" ", "");

        /*public static Accesslevel GetAccesslevel(string text)
        {
            //Console.WriteLine($"!{text.ToLower()}!");

            if (text.ToLower().RemoveSpaces().Contains("publicfinal")) return Accesslevel.PublicFinal;
            else if (text.ToLower().RemoveSpaces().Contains("publicabstract")) return Accesslevel.PublicAbstract;
            else if (text.ToLower().RemoveSpaces().Contains("public")) return Accesslevel.Public;
            else if (text.ToLower().RemoveSpaces().Contains("private")) return Accesslevel.Private;
            else if (text.ToLower().RemoveSpaces().Contains("protected")) return Accesslevel.Protected;
            else if (text.ToLower().RemoveSpaces().Contains("default")) return Accesslevel.Default;
            else return Accesslevel.None;
        }*/

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

        public static string GetDumpDate() => $"[{DateTime.Now.ToString()}] - ";
        public static string GetNewDumpName(string name, string path)
        {
            int value = 1;

            string newName = name;
            while (true)
            {
                newName = name + GetFixNum(value);
                if (!new System.IO.FileInfo(path + $@"\{newName}.log").Exists) break;
                value++;
            }

            return newName;
        }

        public static string GetFixNum(int num)
        {
            if (num < 10) return $"000{num}";
            else if (num < 100) return $"00{num}";
            else if (num < 1000) return $"0{num}";
            else if (num < 10000) return $"{num}";
            else return num.ToString();
        }

        public static string GetPackageNameFromReference(string referenceContext)
        {
            string[] items = referenceContext.Split('.');
            string outputValue = "";

            for (int i = 0; i < items.Length - 1; i++)
                outputValue += $"{(i != 0 ? "." : "")}{items[i]}";

            return outputValue;
        }
    }
}