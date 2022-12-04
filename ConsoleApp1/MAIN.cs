using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{
    class MainProgram
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine(booleanisPalindrome("Was it a cat I saw?"));
            
        }
        public static bool booleanisPalindrome (String text)
        {
            Regex r1 = new Regex ([^a - zA - Z0 - 9];

            //sddsda
        }
        

        public static bool ETALON(String text)
        {
            string a = new Regex("[^a-zA-Z0-9]").Replace(text.ToLower(), "");
            StringBuilder reverce = new StringBuilder();
            for (int i = a.Length -1; i >= 0; i--) 
            {
                reverce.Append(a[i]);
            }
            return a.Equals(reverce.ToString());
        }
       

            




        }

            
      






     



    }
