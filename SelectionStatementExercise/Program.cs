namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my favorite number guessing game!");
            Console.WriteLine("Try to guess my favorite number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse); 

            var random = new Random();
            var number = random.Next(1, upperLimit);


            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Too high! Guess again.");
            }

            else if (guess < number)
            {
                Console.WriteLine("Too low. Guess again");
            }
            else
            {
                Console.WriteLine("You are on point!");
            }
        }
    }
}
