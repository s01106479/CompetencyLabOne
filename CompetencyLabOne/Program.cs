using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyLabOne
//1. Add a multi-line comment with your name and email address to your Lab One code.
/* Isabella Tomasek
 S01106479@acad.tri-c.edu */

//2. Add a single line comment with your course number and CRN to your Lab One code.
//Course Number: 1050, CRN: 86411

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Add an output statement that prints "This is the first Lab Assignment - Lab One" to the console(screen).
            Console.WriteLine("This is the first Lab Assignment - Lab One");

            //4. Add an output statement that says, "Hello your Name". If your name is Joe, you would output Hello Joe. You can include your last name if you want.
            Console.WriteLine("Hello Isabella.");

            //5. Add an output statement that displays your major. Use undeclared if you're not working towards a degree.
            Console.WriteLine("AA-Computer Science");

            //6. Create an integer variable for the number of times you have written code. Estimate and assign the number of times you have written code in any programming language. Output the value of the variable to the console(screen).
            int codingFrequency;
            codingFrequency = 600;
            Console.WriteLine(codingFrequency);

            //7. Create a string variable for the current semester. Assign the name of the current semester to your string variable. Output the value of the variable to the console(screen).
            string semester;
            semester = "fallSemester";
            Console.WriteLine(semester);

            //8. Create a char variable to store a character. Assign your favorite letter of the alphabet to your char variable. Output the value of the variable to the console(screen).
            char myFavLetter;
            myFavLetter = 'V';
            Console.WriteLine(myFavLetter);

        }
    }
}
