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
            string answer3;
            string answer1;
            string answer2;
            string answer4;
            string answer5;
            string answer6;
            string answer7;
            string answer8;
            string answer9;
            string answer10;

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
            Console.WriteLine("Thank you!");

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
                string userAnswer = Console.ReadLine();

                try
                {
                    birthYear = Convert.ToInt32(userAnswer);

                    if (BirthYearValidator(birthYear) && NullCheckerr(birthYear))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid! Please enter a valid integer." );
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Invalid! {ex.Message}");
                }
            }
            while (true);
            Console.WriteLine("Thank you!");

            do
            {
                Console.Write("Please enter your gender (M, F, O, N): ");
                gender = Console.ReadLine();
            }
            while (!GenderValidator(gender));
            Console.WriteLine("Thank you!");
            Console.WriteLine();
            // an array of strings that holds all the questionnaire questions
            string[] questions = { "What is your height?", "What is your weight?", "Are you having COVID symptoms?", "Do you use tobacco?", "Who is your primary physician?", "Who is your employer?", "Do you have a California Health Care Directive?", "Have you ever been diagnosed with diabetes?", "Do you exercise?","Do you have a driver's license"};
            Console.Clear();

            // Questionarre Beginning
            Console.WriteLine("Please answer the following questions:");
            do
            {
                Console.Write("Enter your height (in inches): ");
                answer1 = Console.ReadLine();
            }
            while (!ContainsDigits(answer1));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Enter your weight (in pounds): ");
                answer2 = Console.ReadLine();
            }
            while (!ContainsDigits(answer2));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Are you having COVID symptoms: ");
                 answer3 = Console.ReadLine();
            }
            while (!SimpleAnswerChecker(answer3));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Do you use tobacco: ");
                answer4 = Console.ReadLine();
            }
            while(!SimpleAnswerChecker(answer4));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Who is your primary physician: ");
                answer5 = Console.ReadLine();
            }
            while (!NullChecker(answer5));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Who is your employer: ");
                answer6 = Console.ReadLine();
            }
            while (!NullChecker(answer6));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Do you have a California Health Care Directive: ");
                answer7 = Console.ReadLine();
            }
            while (!SimpleAnswerChecker(answer7));
            Console.WriteLine("Thank you!");
            do
            {
               Console.Write("Have you ever been diagnosed with diabetes: ");
                answer8 = Console.ReadLine();
            }
            while (!SimpleAnswerChecker(answer8));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Do you exercise: ");
                answer9 = Console.ReadLine();
            } 
            while (!SimpleAnswerChecker(answer9));
            Console.WriteLine("Thank you!");
            do
            {
                Console.Write("Do you have a driver's license: ");
                answer10 = Console.ReadLine();
            }
            while (!SimpleAnswerChecker(answer10));
            Console.WriteLine("Thank you!");
            // An array of strings that holds all the user responses to the questions
            string[] userResponses = new string[10];
            try
            {
                AddToArray(answer1, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer2, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer3, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer4, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer5, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer6, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer7, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer8, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer9, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                AddToArray(answer10, userResponses);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // clears the console window before displaying the desired output
            Console.Clear();

            // Profile summary section
            // changes header text color
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to James Hospital!");
            // changes the rest of the text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Profile Summary:");
            Console.WriteLine();
            Console.WriteLine($"Hello {lName}, {fName}");
            Console.WriteLine($"Age: {AgeCalulator(birthYear)}");
            // Converts and prints the correct gender to the console
            // Catches basic exceptions as well as an argument exception (issue with the parameter passed in)
            try
            {
                Console.WriteLine($"Gender: {GenderConversion(gender)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            Console.WriteLine();
            Console.WriteLine("Questionnaire:");
            // Loop to print all questions and answers to the console in order
            // Catches basic exceptions as well as IndexOutOfRangeExceptions 
            try
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    // used i + 1 so that the first question is labeled Question 1 (0 based indexing)
                    Console.WriteLine($"Question {i + 1}: {questions[i]}");
                    Console.WriteLine($"Response {i + 1}: {userResponses[i]}");
                    // adds space between each set of question/answer
                    Console.WriteLine();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error! {e.Message}");
            }

        }

        /*
         * METHODS
         */

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
        /// Checks the string input to ensure it isn't null or empty
        /// </summary>
        /// <param name="answer">Accepts a string answer as a parameter</param>
        /// <returns>Returns false is the string is not empty. Returns true if the string is in fact null.</returns>
        static bool NullChecker(string answer)
        {
            if (answer == "")
            {
                Console.WriteLine("Please don't submit an empty answer.");
                return false;
            }
            return true;
        }

        static bool NullCheckerr(int? answer)
        {
            if (answer.HasValue)
            {
                Console.WriteLine("Please don't submit an empty answer.");
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
        /// Checks the answer to ensure that only digits are entered
        /// </summary>
        /// <param name="answer">Accepst a string answer as a parameter</param>
        /// <returns>Returns false if answer contains any characters other than a digit. Returns true if the anser only contains digits</returns>
        static bool ContainsDigits(string answer)
        {
            foreach (char c in answer)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("Please enter a height/weight with digits only.");
                    return false;
                }
            }
            return true;
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

        /// <summary>
        /// Converts teh single character gender to the full description (EX: M->Male, F-> Female... etc)
        /// </summary>
        /// <param name="gender">Accepts a string input</param>
        /// <returns>Returns the full description of whatever gender is passed in as a parameter</returns>
         static string GenderConversion(string gender)
        {
            switch (gender.ToUpper())
            {
                case "M":
                    return "Male";                  
                case "F":
                    return "Female";                  
                case "O":
                    return "Other/ Not listed";                  
                case "N":
                    return "Non-Binary";
                default:
                    return "Invalid gender.";   
            }
        }

        /// <summary>
        /// Checks the user's response to ensure that they only enter yes or no (not case sensititve)
        /// </summary>
        /// <param name="answer">Accepts a string to validate as a parameter</param>
        /// <returns>Returns true if the answer is in fact 'yes' or 'no'. Returns false if the answer was not 'yes' or 'no'</returns>
        static bool SimpleAnswerChecker(string answer)
        {
            if (answer.ToUpper() == "YES" || answer.ToUpper() == "NO")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid! Please enter either 'Yes' or 'No'. ");
                return false;
            }
            
        }

    }
    
}
