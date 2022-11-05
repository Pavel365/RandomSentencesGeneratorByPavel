using System;

namespace RandomSentencesGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want to stop the program, you write \"Stop\".");
            Console.WriteLine("Click \"Enter\" to generate a new one.");

            string command;

            while ((command = Console.ReadLine())!= "Stop")
            {
                string[] names =
                {
                    "Pavel", "Pesho", "Gosho", "Steve", "John", "Michel", "Alice"
                };

                string[] places =
                {
                    "Sofia", "Plovdiv", "Varna", "Burgas", "Smolyan", "Lovech", "Gabrovo", "Stara Zagora", "Sliven"
                };

                string[] verbs =
                {
                    "eats", "sleeps", "holds", "sees", "plays", "brings", "runs", "talks"
                };

                string[] nouns =
                {
                    "stones", "bikes", "cake", "apple", "laptop", "houses"
                };

                string[] adverbs =
                {
                    "slowly", "diligently", "warmly", "happily", "rapidly",  "sadly"
                };

                string[] details =
                {
                    "near the river", "at home", "in the park", "at the beach"
                };

                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetail = GetRandomWord(details);

                Console.WriteLine("This is your random-generated sentence: ");
                Console.WriteLine($"{randomName} from {randomPlace} {randomAdverb} {randomVerb} {randomNoun} {randomDetail}.");
                Console.WriteLine();
            }
        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, words.Length);
            string word = words[randomIndex];

            return word;
        }
    }
}
