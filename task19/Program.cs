Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());
if(N<100000 & N>9999)
{
    int FirstDigit = N/10000;
    int SecondDigit = N/1000%10;
    int FourthDigit = N%100/10;
    int FifthDigit = N%10;
    if((FirstDigit == FifthDigit) & (SecondDigit == FourthDigit))
    {
        Console.WriteLine("Данное число является палиандром.");
    }
    else 
    {
        Console.WriteLine("Данное число не является палиандром. ");
    }
}
else
{
    Console.WriteLine("Вы ввели число, не являющееся пятизначным.");
}