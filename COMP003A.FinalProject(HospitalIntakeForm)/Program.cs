// Author: Kyle James
// Course: COMP003A
// Purpose: COMP003A Final Project Code

namespace COMP003A.FinalProject_HospitalIntakeForm_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "What is your height (in inches)", "What is your weight (in pounds)", "Are you having COVID symptoms?", "Do you use tobacco?", "Who is your primary physician?", "Who is your employer?", "Do you have a California Health Care Directive?", "Have you ever been diagnosed with diabetes?", "Do you exercise?", "Do you have a driver's license" };
            string gender;
            string[] answers = new string[questions.Length];
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to James Hospital!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please fill out the following:");
            Console.WriteLine();
            string fName = ValidNameProdution("first");
            string lName = ValidNameProdution("last");
           int birthYear = BirthYearAsker();
            Console.WriteLine("Thank you!");

            do
            {
                Console.Write("Please enter your gender (M, F, O, N): ");
                gender = Console.ReadLine();
            }
            while (!GenderValidator(gender));
            Console.WriteLine("Thank you!");
            Console.WriteLine();
            Console.Clear();

            // Questionarre Beginning
            Console.WriteLine("Please answer the following questions:");
            // Method that prompts user with all questions and allows them to answer
           PromptUser(questions, answers);
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
            Console.WriteLine($"Gender: {GenderConversion(gender)}");
            Console.WriteLine();
            Console.WriteLine("Questionnaire:");
            // Loop to print all questions and answers to the console in order
            for (int i = 0; i < questions.Length; i++)
            {
                // used i + 1 so that the first question is labeled Question 1 (0 based indexing)
                Console.WriteLine($"Question {i + 1}: {questions[i]}");
                Console.WriteLine($"Response {i + 1}: {answers[i]}");
                // adds space between each set of question/answer
                Console.WriteLine();
            }
        }

        /*
         * METHODS
         */

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
            else if (answer == "0")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks to ensure the value thats passed in as a parameter has a value and is not null
        /// </summary>
        /// <param name="answer">Accepts an integer as a parameter</param>
        /// <returns>Returns false if the value is empty or null. Returns true if the answer has an integer value</returns>
        static bool IntNullChecker(int? answer)
        {
            if (answer.HasValue)
            {
                return true;
            }
            Console.WriteLine("Please don't submit an empty answer.");
            return false;
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

        /// <summary>
        /// Produces a valid first and last name by prompting the user to enter their names.
        /// </summary>
        /// <param name="nameType">Accepts name type (first or last)</param>
        /// <returns>Returns the valid name once entered by the user</returns>
        static string ValidNameProdution(string nameType)
        {
            string name;
            do
            {
                Console.Write($"Please enter your {nameType} name: ");
                name = Console.ReadLine();
            }
            while (!ValidNameChecker(name));

            return name;
        }

        /// <summary>
        /// PRompts the user to answer all questions in the questionaare using a loop
        /// </summary>
        /// <param name="questions">Acceps the questions array as a parameter</param>
        /// <param name="answers">Accepts the answers array as a parameter</param>
        static void PromptUser(string[] questions, string[] answers)
        {
            for (int i = 0; i < questions.Length; i++)
            {
                do
                {
                    Console.Write($"{questions[i]}: ");
                    answers[i] = Console.ReadLine();

                    switch (i)
                    {
                        case 0: // height
                        case 1: // weight
                            if (string.IsNullOrEmpty(answers[i]) || !ContainsDigits(answers[i]) || answers[i] == "0")
                            {
                                Console.WriteLine("Please enter a valid non-zero number for height/weight.");
                                answers[i] = null;
                            }
                            break;
                        case 2: // covid
                        case 3: // tobacco
                        case 6: // chd
                        case 8: // exercise 
                        case 9: // dl
                        case 7: // diabetes
                            if (!SimpleAnswerChecker(answers[i]))
                            {
                                Console.WriteLine("Please enter either 'Yes' or 'No'.");
                                answers[i] = null;
                            }
                            break;
                        case 4: // primary physician 
                        case 5: // employer
                            if (!NullChecker(answers[i]))
                            {
                                Console.WriteLine("Please do not submit an empty answer.");
                                answers[i] = null;
                            }
                            break;
                        default:
                            if (!NullChecker(answers[i]))
                            {
                                Console.WriteLine("Please do not submit an empty answer.");
                                answers[i] = null;
                            }
                            break;
                    }
                }
                while (answers[i] == null);
            }
        }

        /// <summary>
        /// Prompts the user to enter their birth year. It is then validated and a clean birthYear is returned.
        /// </summary>
        /// <returns>Returns a clean birthYear</returns>
        static int BirthYearAsker()
        {
            do
            {
                Console.Write("Please enter your birth year: ");
                string userAnswer = Console.ReadLine();

                try
                {
                    int birthYear = Convert.ToInt32(userAnswer);

                    if (BirthYearValidator(birthYear) && IntNullChecker(birthYear))
                    {
                        return birthYear;
                    }
                    Console.WriteLine("Invalid! Please enter a valid integer.");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Invalid! {ex.Message}");
                }
            }
            while (true);
        }
    }
    
}
