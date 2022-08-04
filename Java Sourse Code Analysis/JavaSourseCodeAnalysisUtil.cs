using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.analysis
{
    public static class JavaSourseCodeAnalysisUtil
    {
        /// <summary>
        ///     This method searches the context for quote boundaries, extracts them, 
        /// and returns a value. This can be handy for finding a java method in context 
        /// as well as its bounds.
        /// 
        ///     With each start character of the '{' bracket it goes up a level above 
        /// 'parenthesesLevel', and with every end character of the '}' bracket it goes 
        /// down a level, when it gets to the end it cuts the context and returns it.
        /// </summary>
        /// <param name="context">Source code context</param>
        /// <param name="start_index">Parsing start index</param>
        /// <returns></returns>
        public static string ProcessDesignateParenthesesBoundaries(this string context, int startIndex)
        {
            bool isFirst = true;
            int endIndex = startIndex;
            int parenthesesLevel = 0;
            for (; endIndex < context.Length; endIndex++)
            {
                if (context[endIndex] == '{')
                {
                    parenthesesLevel++;
                    isFirst = false;
                }
                if (context[endIndex] == '}')
                {
                    parenthesesLevel--;
                    if (parenthesesLevel < 0) throw new CouldNotFindTheEndOfTheParenthesisLevelException();
                }
                if (parenthesesLevel == 0 && !isFirst) break;
            }

            return context.Substring(startIndex, endIndex - startIndex + 1);
        }
    }
}
