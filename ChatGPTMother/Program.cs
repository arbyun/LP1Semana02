using System;

namespace ChatGPTMother
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ask me anything!");
                string question = Console.ReadLine();

                if (question != null)
                    switch (question.ToLower())
                    {
                        case "what's your name?":
                            Console.WriteLine("I'm Chat Bot GPT Mother.");
                            break;

                        case "how are you?":
                            Console.WriteLine("I'm fine, thank you.");
                            break;

                        case "are you an AI?":
                            Console.WriteLine("No, I'm just a simple automatized program.");
                            break;

                        case "how old are you?":
                            Console.WriteLine("I'm one day old.");
                            break;
                    }
            }
        }
    }
}
