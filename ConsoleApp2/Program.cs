namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var arrayInt = new int[5];

            Console.WriteLine("Please enter the amount of integers (5):");

            for (int i = 0; i < arrayInt.Length; i++)
            {                
                arrayInt[i] = Convert.ToInt32(Console.ReadLine());
            }

            var sortedArray = Sorter.Sort(arrayInt);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }


            var arrayDouble = new double[5];
           
            Console.WriteLine("Please enter the amount of doubles (5):");

            for (int i = 0; i < arrayDouble.Length; i++)
            {
                
                arrayDouble[i] = Convert.ToDouble(Console.ReadLine());
            }

            var sortedArrayDouble = Sorter.SortDoble(arrayDouble);

            for (int i = 0; i < sortedArrayDouble.Length; i++)
            {
                Console.WriteLine(sortedArrayDouble[i]);
            }






        }
    }
}    