using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        public static string RemoveMuchSpace(string expression)
        {
            expression = expression.Trim();
            string newEx = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ' && expression[i + 1] == ' ')
                {
                    continue;
                }

                newEx += expression[i];
            }

            return newEx;
        }
    }
}
