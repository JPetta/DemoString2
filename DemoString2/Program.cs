using System;

namespace DemoString2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jovi Petra ";
            Console.WriteLine("Trim : {0}",fullName.Trim());
            Console.WriteLine("Upper : {0}",fullName.ToUpper().Trim());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index+1);
            Console.WriteLine("First name : "+firstName);
            Console.WriteLine("Last name : " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("\nFirst name : " + names[0]);
            Console.WriteLine("Last name : " + names[1]);

            Console.WriteLine(fullName.Replace("Jovi", "Jovee"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.95f;
            Console.WriteLine(price.ToString("c0"));
        }
    }
}
