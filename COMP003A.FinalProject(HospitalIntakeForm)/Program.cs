// Author: Kyle James
// Course: COMP003A
// Purpose: COMP003A Final Project Code

namespace COMP003A.FinalProject_HospitalIntakeForm_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to James Hospital!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please fill out the following:");
            Console.WriteLine();
            Console.Write("Please enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("Please enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your gender (M, F, O): ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please answer the following questions:");
            Console.Write("What is your height: ");
            string answer1 = Console.ReadLine();
            Console.Write("What is your weight: ");
            string answer2 = Console.ReadLine();
            Console.Write("Are you having covid symptoms: ");
            string answer3 = Console.ReadLine();
            Console.Write("Do you use tobacco: ");
            string answer4 = Console.ReadLine();
            Console.Write("Who is your primary physician: ");
            string answer5 = Console.ReadLine();
            Console.Write("Who is your employer: ");
            string answer6 = Console.ReadLine();
            Console.Write("Do you have a California Health Care Directive: ");
            string answer7 = Console.ReadLine();
            Console.Write("Have you ever been diagnosed with diabetes: ");
            string answer8 = Console.ReadLine();
            Console.Write("Do you exercise: ");
            string answer9 = Console.ReadLine();
            Console.Write("Do you have a driver's license: ");
            string answer10 = Console.ReadLine();
            string[] userResponses = new string[10];
            AddToArray(answer1, userResponses);
            AddToArray(answer2, userResponses);
            AddToArray(answer3, userResponses);
            AddToArray(answer4, userResponses);
            AddToArray(answer5, userResponses);
            AddToArray(answer6, userResponses);
            AddToArray(answer7, userResponses);
            AddToArray(answer8, userResponses);
            AddToArray(answer9, userResponses);
            AddToArray(answer10, userResponses);
            foreach (var response in userResponses)
            {
                Console.WriteLine(response);
            }



        }

        /// <summary>
        /// Adds all user answers into an array.
        /// </summary>
        /// <param name="value">Accepts the value you want added to the array</param>
        /// <param name="array">Accepts which array you want the value added into</param>
        static void AddToArray(string value, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                {
                    array[i] = value;
                    return;
                }
            }
        }

    }

}
