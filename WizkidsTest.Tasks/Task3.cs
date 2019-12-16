using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WizkidsTest.Tasks
{
    public class Task3
    {
        /// <summary>
        /// Finds and replace valid email adresses in a string
        /// </summary>
        /// <param name="emailText">Email text</param>
        /// <param name="newEmailAddress">Email that will replace all valid emails</param>
        /// <returns></returns>
        public static string FindAndReplaceEmails(string emailText, string newEmailAddress)
        {
            string emailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"; ;
            string[] emailTextArray = emailText.Split(' ');
            string replacedEmailText = string.Empty;

            foreach (string word in emailTextArray)
            {
                if (Regex.IsMatch(word, emailRegex, RegexOptions.IgnoreCase))
                {
                    replacedEmailText += newEmailAddress;
                }
                else
                {
                    replacedEmailText += word;
                }
                replacedEmailText += " ";
            }

            return replacedEmailText;
        }

    }
}
