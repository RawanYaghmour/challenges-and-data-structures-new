namespace Reverse_Words
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("csharp is programming language"));   // Output: "language programming is csharp"
            Console.WriteLine(ReverseWords("Reverse the words in this sentence")); // Output: "sentence this in words the Reverse"
            Console.WriteLine(ReverseWords("challenges and data structures")); // Output: "structures data and challenges"
            Console.WriteLine(ReverseWords("")); // Output: ""

        }
        public  string ReverseWords(string input_string)
        {
            if (string.IsNullOrWhiteSpace(input_string))
            {
                return string.Empty;
            }

            string[] words = input_string.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        
    }
}
