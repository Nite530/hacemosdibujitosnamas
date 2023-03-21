//
class Cerebron
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 3;
        int result = num1 + num2;
        
        Console.WriteLine("la suma de "+ num1 + " y " + num2 + " es " + result);

        int[] numbers = { 8, 2, 5, 1, 9 };
        SortArray(numbers);
        Console.Write("numeros de ascendentes: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}