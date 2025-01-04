// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



class Program
{
    static void Main()
    {
    
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "apple", "A sweet fruit that grows on trees." },
            { "book", "A set of written or printed pages bound together." },
            { "computer", "An electronic device for storing and processing data." },
            { "programming", "The process of writing and maintaining the source code of a computer program." },
            { "dictionary", "A reference book or online resource that lists words and their meanings." }
        };

        Console.WriteLine("Welcome to the Dictionary Program!");
        
        while (true)
        {
          
            Console.Write("\nEnter a word to search for its meaning (or type 'exit' to quit): ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

           
            if (dictionary.TryGetValue(input, out string meaning))
            {
                Console.WriteLine($"Meaning of '{input}': {meaning}");
            }
            else
            {
                Console.WriteLine($"Sorry, the word '{input}' is not in the dictionary.");
            }
        }
    }
}

