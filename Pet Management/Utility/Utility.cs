using System;
using System.Text.RegularExpressions;

namespace Pet_Management.Common
{
    public class Utility
    {
        /// <summary>
        /// Check for numeric
        /// </summary>
        /// <param name="sInput">Character string</param>
        /// <returns>TRUE:OK | FALSE:Fail</returns>
        public static bool isNumber(string sInput)
        {
            for (int i = 0; i < sInput.Length; i++)
            {
                if (sInput[i] < '0' || sInput[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Check email address format
        /// </summary>
        /// <param name="sEmail">mail address</param>
        /// <returns>TRUE: OK, FALSE: Fail</returns>
        public static bool CheckEmailAddress(string sEmail, out string errMsg)
        {
            errMsg = String.Empty;

            // email address format
            string sPattern = @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b";
            if (String.IsNullOrEmpty(sEmail) || Regex.IsMatch(sEmail, sPattern, RegexOptions.IgnoreCase))
            {
                return true;
            }

            errMsg = FuncDef.ERR_EMAIL_ADDRESS;
            return false;
        }
    }
}
