using System;
using System.Text;
namespace String_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Input: ");
            string str= Convert.ToString(Console.ReadLine()).Trim();
            Console.WriteLine(Reverse(str)); 
        }
        /// <summary>
        /// Reverse Methode Created
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string Reverse(string str)
        {
            StringBuilder result = new StringBuilder();
            
         //   string result=string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }
    }
}
