using StripCommentsChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = StripCommentsSolution.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new[] { "#", "!" });
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
