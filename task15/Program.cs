Console.Clear();

Console.Write("Введите, цифру от 1 до 7, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
    Console.WriteLine("Ошибка ввода");
else  
    {    
    if (number == 6 || number == 7)
        Console.WriteLine("да");
    else 
        Console.WriteLine("нет");
    }
