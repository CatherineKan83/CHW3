Console.WriteLine("Введите координаты первой точки: ");
int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки: ");
int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());
double Distance = Math.Sqrt(Math.Pow(X2-X1, 2) +Math.Pow(Y2-Y1, 2) + Math.Pow(Z2 - Z1, 2));
Console.WriteLine($"Расстояние между двумя точками: {Distance} .");

