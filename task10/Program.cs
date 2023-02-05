Console.Clear();

Console.Write("Введите трёхзначное число: ");
int trinity = Convert.ToInt32(Console.ReadLine());

if (trinity < 100 || trinity > 999)
    Console.WriteLine("Это не трехзначное число");
else  
    {  
    trinity = (trinity/10)%10;
    Console.WriteLine(trinity);
    }

