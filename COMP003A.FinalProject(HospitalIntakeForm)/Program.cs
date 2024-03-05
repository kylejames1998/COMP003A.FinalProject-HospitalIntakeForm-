// Author: Kyle James
// Course: COMP003A
// Purpose: COMP003A Final Project Code

namespace COMP003A.FinalProject_HospitalIntakeForm_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            int birthYear;
            string gender;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to James Hospital!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please fill out the following:");
            Console.WriteLine();
            do
            {
                Console.Write("Please enter your first name: ");
                fName = Console.ReadLine();
            }
            while (!ValidNameChecker(fName));

            do
            {
                Console.Write("Please enter your last name: ");
                lName = Console.ReadLine();
            }
            while (!ValidNameChecker(lName));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Please enter your birth year: ");
                birthYear = Convert.ToInt32(Console.ReadLine());
            }
            while (!BirthYearValidator(birthYear));

            do
            {
                Console.Write("Please enter your gender (M, F, O, N): ");
                gender = Console.ReadLine();
            }
            while (!GenderValidator(gender));
           // change this to a string ----> char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            // an array of strings that holds all the questionnaire questions
            string[] questions = { "What is your height?", "What is your weight?", "Are you having COVID symptoms?", "Do you use tobacco?", "Who is your primary physician?", "Who is your employer?", "Do you have a California Health Care Directive?", "Have you ever been diagnosed with diabetes?", "Do you exercise?","Do you have a driver's license"};
            Console.Clear();

            // Questionarre Beginning
            Console.WriteLine("Please answer the following questions:");
            Console.Write("What is your height: ");
            string answer1 = Console.ReadLine();
            Console.Write("What is your weight: ");
            string answer2 = Console.ReadLine();
            Console.Write("Are you having COVID symptoms: ");
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
            // An array of strings that holds all the user responses to the questions
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
            // clears the console window before displaying the desired output
            Console.Clear();

            // Profile summary section
            Console.WriteLine("Welcome to James Hospital!");
            Console.WriteLine();
            Console.WriteLine("Profile Summary:");
            Console.WriteLine($"Hello {lName} , {fName}");
            Console.WriteLine($"Age: {AgeCalulator(birthYear)}");
            // add gender full description output here
            Console.WriteLine("Questionnaire:");
            // Loop to print all questions and answers to the console in order
            for (int i = 0; i <questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Response {i + 1}: {userResponses[i]}");
                // adds space between each set of question/answer
                Console.WriteLine();
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

        /// <summary>
        /// Checks name to validate the data and ensure that it doesn't include digits, special characters, or is null
        /// </summary>
        /// <param name="name">Accepts the name you want to validate</param>
        /// <returns>Returns true if the name passes all validity checks. Returns false if it does not pass.</returns>
        static bool ValidNameChecker(string name)
        {
            // checking for empty string
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid! Please enter a name.");
                return false;
            }
            
            // Checking to ensure no digits or special characters are entered
            if (HasDigits(name) || HasSpecialChar(name))
            {
                Console.WriteLine("Invalid! Please enter a name that doesn't include digits or special characters");
                return false;
            }
            
            return true;
        }
            
        /// <summary>
        /// Checks to ensure there are no special characters entered in a name field
        /// </summary>
        /// <param name="input">Accepts the name you want to traverse</param>
        /// <returns>Returns true if the name includes a special character. Returns false if it does not</returns>
        static bool HasSpecialChar(string name)
        {
            foreach (char c in name)
            {
                if (c == '*' || c == '(' || c == '%' || c == '@' || c == '!' || c == '#' || c == '$' || c == '^' || c == '&' || c == '_' || c == '-')
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Checks to ensure there are no digits entered in a name field
        /// </summary>
        /// <param name="input">Accepts the name you want to traverse</param>
        /// <returns>Returns true if the name includes a digit. Returns false if it does not.</returns>
        static bool HasDigits(string name)
        {
            foreach (char c in name)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Calulates the age when the birth year is input as a parameter
        /// </summary>
        /// <param name="birthYear">Accepts the user's birth year</param>
        /// <returns>Returns the user's age based on what year they input</returns>
        static int AgeCalulator(int birthYear)
        {
            int age = DateTime.Now.Year - birthYear;
            return age;
        }

        /// <summary>
        /// Checks for a valid birth year (Between years 1900-1024)
        /// </summary>
        /// <param name="birthYear">Accepts user's birth year as a parameter</param>
        /// <returns>Returns false if the birth year is invalid. Returns true if the birth year is valid.</returns>
        static bool BirthYearValidator(int birthYear)
        {
            if (birthYear > DateTime.Now.Year || birthYear < 1900)
            {
                Console.WriteLine("Invalid! Please enter a year between 1900-2024.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ensures that only M, F, O, or N are the only characters entered in the gender field
        /// </summary>
        /// <param name="gender">Accepts gender as a parameter</param>
        /// <returns> Returns false if the gender is incorrect. Returns true if the gender is valid</returns>
        static bool GenderValidator(string gender)
        {
            switch (gender.ToUpper())
            {
                case "M":
                case "N":
                case "F":
                case "O":
                    return true;
                default:
                    Console.WriteLine("Invalid! Please enter 'M' for male, 'F' for female, 'N' for non-binary, or 'O' for any genders that are not listed");
                    return false;
            }
        }
    }

}
