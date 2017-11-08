using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Khanh Nguyen ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            // better way is to split
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            ;
            Console.WriteLine(fullName.Replace("Khanh", "CON"));

            //This was the old method to validate strings by trimming whitespace
            if (String.IsNullOrEmpty(" ".Trim()))
            Console.WriteLine("Invalid");
            //but later, Microsoft released newer method below
            String.IsNullOrWhiteSpace(" ");
            Console.WriteLine("Invalid");
            //now you dont need to trim an empty string
            // just like JS, user input always comes as strings

            var str = "25";
            Convert.ToInt32(str);
            //integer is 4 bytes, but we only need 1 byte, so...
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
                //every object in .net has a ToString method
                //we can use no arguments or we can provide a format string
        }
    }
}
