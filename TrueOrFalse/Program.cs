using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = { "Snakes are scaly", "Dogs are hairy", "Bread used to be dough" };
            bool[] answers = { true, true, true };
            RunQuiz(questions, answers);
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            bool[] responses = new bool[questions.Length];
            int askingIndex = 0;

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("There is a bugg in the cøde. Please make sure there are answers to every question.");
            }

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine("True or false?");
                string input = Console.ReadLine();
                bool inputBool;
                bool isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine(response);
                Console.WriteLine($"{scoringIndex}. Input: {response} | Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
