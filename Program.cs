using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int numAdd1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like me to add?");
            int numAdd2 = int.Parse(Console.ReadLine());
            int numAddSum = numAdd1 + numAdd2;
            Console.WriteLine($"The sum of these numbers is: {numAddSum}");

            Console.WriteLine("Give me another number");
            int numSub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like me to subtract?");
            int numSub2 = int.Parse(Console.ReadLine());
            int numSubRemainder = numSub1 - numSub2;
            Console.WriteLine($"The result of subtracting {numSub2} from {numSub1} is {numSubRemainder}");

            Console.WriteLine("Another number please");
            int numMult1 = int.Parse(Console.ReadLine());
            Console.WriteLine("what do you want to multiply that by?");
            int numMult2 = int.Parse(Console.ReadLine());
            int numMultResult = numMult1 * numMult2;
            Console.WriteLine($"The result is {numMultResult}");

            Console.WriteLine("Give me another number");
            int numDiv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What would you like to divide that by?");
            int numDiv2 = int.Parse(Console.ReadLine());
            int numQuotient = numDiv1 / numDiv2;
            int numRemainder = numDiv1 % numDiv2;
            Console.WriteLine($"The result is {numQuotient}, with a remainder of {numRemainder}");



        }
    }
}
