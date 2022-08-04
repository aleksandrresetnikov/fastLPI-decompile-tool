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
        public static string ProcessDesignateParenthesesBoundaries(string context, int start_index)
        {
            bool is_first = true;
            int end_index = start_index;
            int Parentheses_level = 0;
            for (; end_index < context.Length; end_index++)
            {
                if (context[end_index] == '{')
                {
                    Parentheses_level++;
                    is_first = false;
                }
                if (context[end_index] == '}')
                {
                    Parentheses_level--;
                    if (Parentheses_level < 0) throw new CouldNotFindTheEndOfTheParenthesisLevelException();
                }
                if (Parentheses_level == 0 && !is_first) break;
            }

            return context.Substring(start_index, end_index - start_index + 1);
        }
    }
}
