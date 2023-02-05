Console.Clear();

Console.Write("Введите последовательность натуральных чисел через пробел (завершние числом 0): ");
int n = Convert.ToInt32(Console.ReadLine());
List<double> n = new List<double>;
while (n != 0)
{
    var secondMax = n.OrderByDescending(r => r).Skip(1).FirstOrDefault();
}
Console.WriteLine(secondMax);  

// Я пытался )