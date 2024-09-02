
namespace ConsoleApp13
{
    public class Second_Largest
    {
        public static void Main()
        {
            var givenArray = new int[] { 2, 3, 1, 9, 8, 7 };
            Console.WriteLine(givenArray);
            Console.ReadKey();
        }

        public static int FindSecondLargest(int [] arr)
        {
            var largest = int.MinValue;
            var secondLargest = int.MinValue;

            foreach(var num in arr)
            {
                if(num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }

                else if (num > secondLargest && secondLargest!= largest)
                {
                    secondLargest = num;
                }
            }
            return (secondLargest! == int.MinValue) ? -1 : secondLargest; 
        }
    }
}
