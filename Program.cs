using System;
using System.Text;

namespace Tema_Obfuscate_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Email:");
            string initialEmail = Console.ReadLine();

            int lenghtOfChange = initialEmail.IndexOf("@");

            Console.WriteLine("Obfuscate Email: {0}{1}", PrintStars(lenghtOfChange), initialEmail.Substring(lenghtOfChange));
        }
        
        static string PrintStars(int lenghtOfChange)
        {
            StringBuilder temporaryText = new StringBuilder();

            for (int i = 0; i <= lenghtOfChange-1; i++)
            {
                temporaryText.Append("*");
            }

            string result = temporaryText.ToString();
            return result;
        }
    }
}
