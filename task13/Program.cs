Console.Clear();

Console.Write("Введите, как минимум, трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
    Console.WriteLine("Третьей цифры нет");
else  
    {    
    while (number > 999)
        {
        number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine(result);
    }
