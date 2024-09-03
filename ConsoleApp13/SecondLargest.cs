
namespace ConsoleApp13
{
    public class SecondLargest
    {
        public static void Main()
        {
            var numbers = new int[] { 2, 5, 7, 10, 12, 14, 15 };

            var output = FindSecondLargest(numbers);

            Console.WriteLine(output);
        }

        public static int FindSecondLargest(int[] numbers)
        {
            var largest = int.MinValue;
            var secondLargest = int.MinValue;

            foreach (var num in numbers)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest != int.MinValue)
            {
                return secondLargest;
            }
            return -1;
        }
    }
}
