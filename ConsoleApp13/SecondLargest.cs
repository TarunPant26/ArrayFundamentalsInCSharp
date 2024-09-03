
namespace ConsoleApp13
{
    public class SecondLargest
    {
        public static void Main()
        {
            var numbers = new int[] { 2, 5, 7, 10, 12, 14, 15 };
        }

        public static int FindSecondLargest(int[] numbers)
        {
            var largest = int.MinValue;
            var seconLargest = int.MinValue;

            foreach (var num in numbers)
            {
                if(num > largest)
                {
                    seconLargest = largest;
                    largest = num;
                }
                else if(seconLargest < num && num!=largest)
                {
                    seconLargest = num;
                }
            }

            return seconLargest == int.MinValue ? -1 : seconLargest;
        }
    }
}
