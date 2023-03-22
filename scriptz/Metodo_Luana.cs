class calculadora
{
static void Main()
{
int num1 = 5, num2 = 3, result = num1 + num2;
Console.WriteLine("la suma es " + result);
 int[] numbers = { 8, 2, 5, 1, 9 };
    Array.Sort(numbers);
    Console.Write("Números de mayor a menor: ");
    Console.Write(string.Join(", ", numbers));
    Console.WriteLine();
}