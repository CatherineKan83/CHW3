Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Таблица кубов генерируется...");
Console.WriteLine();
for(int i=1; i<n+1; i++)
{
    Console.WriteLine($"{i} = {Math.Pow(i, 3)}");
    Console.WriteLine();
}
Console.WriteLine("---");