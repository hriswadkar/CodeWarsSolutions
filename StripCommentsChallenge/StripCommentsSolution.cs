using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripCommentsChallenge
{
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            System.Text.StringBuilder finalString = new System.Text.StringBuilder();
            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            
            foreach(string s in commentSymbols)
            {
                int index = text.IndexOf(s);
                int newLineIndex = text.IndexOf("\n");
                if(index > 0)
                {
                    finalString.Append(text.Remove(index, newLineIndex));
                }
            }

            return finalString.ToString().TrimEnd();
        }
    }
}
