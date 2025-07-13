namespace MethodsExercise
{
    public class Program
    {

        public static void ShortStory()
        {
            Console.WriteLine("Think of a Name.");
            string name = Console.ReadLine();
            
            Console.WriteLine("Think of a City.");
            string city = Console.ReadLine();
            
            Console.WriteLine("Think of a Color.");
            string color = Console.ReadLine();
            
            Console.WriteLine("Think of an Animal.");
            string animal = Console.ReadLine();
            
            Console.WriteLine("Think of a Genre of Music.");
            string musicGenre  = Console.ReadLine();

            Console.WriteLine($"One day, Hercules Poirot investigated a string of thefts likely conducted by a person named {name} throughout the streets of {city}. Through his findings, {name} is suspected to be wearing a {color} sweater, and has a captive {animal} in his mansion. As Poirot saw {name} leave a café with {musicGenre} music blaring in the vicinity, he alerted the authorities, only to see another individual with identical clothing and accessories also depart. In order to catch {name}, Poirot has to think like a thief and activate his “little grey cells.”\n");

            
        }

        public static void Add()
        {
            Console.WriteLine("Welcome to an Addition Calculator");
            Console.WriteLine("Think of a First number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Think of a Second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            int sum = numOne + numTwo;

            Console.WriteLine($"The output is: {sum}\n");
        }

        public static void Subtract()
        {
            Console.WriteLine("Welcome to a Subtraction Calculator");
            Console.WriteLine("Think of a First number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Think of a Second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            int difference = numOne - numTwo;

            Console.WriteLine($"The output is: {difference}\n");
        }

        public static void Multiply()
        {
            Console.WriteLine("Welcome to an Multiplication Calculator");
            Console.WriteLine("Think of a First number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Think of a Second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            int product = numOne * numTwo;

            Console.WriteLine($"The output is: {product}\n");
        }

        public static void Divide()
        {
            Console.WriteLine("Welcome to an Division Calculator");
            Console.WriteLine("Think of a First number.");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Think of a Second number.");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            int quotient = numOne / numTwo;

            Console.WriteLine($"The output is: {quotient}\n");
            Console.WriteLine("See you next time");

        }
        
        
        static void Main(string[] args)
        {
            
            ShortStory();
            Add();
            Subtract();
            Multiply();
            Divide();
        }
        
    }
    
    
}
