using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.analytics;

namespace fastLPI.tools.decompiler.helper
{
    public static class MethodUtil
    {
        public static Method[] GetMethodsInClass(string text)
        {
            Queue<Method> OutMethods = new Queue<Method>();

            MatchCollection MethodItems = Regex.Matches(text, Patterns.AnyMethodPattern);
            Console.WriteLine(MethodItems.Count);
            for (int i = 0; i < MethodItems.Count; i++)
            {
                Match MethodLabelStructureItem = Regex.Match(MethodItems[i].Value, @"(public|private|protected|virtual|abstract|\b)(\s+?)*");
                OutMethods.Enqueue(GetMethod(MethodItems[i].Value, MethodLabelStructureItem.Value));
            }

            return OutMethods.ToArray();
        }

        public static Method GetMethod(string Context, string LabelContext)
        {
            string RemoteAccessContext = Context.Replace(LabelContext, "");
            string ArgumentContext = Regex.Match(RemoteAccessContext, Patterns.AnyMethodArgumentsStructurePattern).Value;

            Method method = new Method();
            method.Context = Context;
            method.Name = TrimToParentheses(RemoteAccessContext);
            method.ArgumentContext = ArgumentContext;
            method.Arguments = ArgumentContext.Split(',');
            return method;
        }

        public static string TrimToParentheses(string text)
        {
            string outValue = text.Replace(Regex.Match(text, Patterns.AnyMethodArgumentsStructurePattern).Value, "");
            string[] items = outValue.Split(' ');
            return items[items.Length - 1].Replace(" ", "");
        }
    }
}
