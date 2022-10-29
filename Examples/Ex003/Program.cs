// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Пример из 5 элементов:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Write("Введите ряд чисел, без запятой: ");
// В начале вводим строку из чисел, потом вызываем метод .Split(' '), аргумент указывает, что строка будет разделена на множество строк по пробелу, 
//на выходе у нас будет массив из строк, которыми будут являться числа. .Select(numbers => int.Parse(numbers)), numbers - это переменная, select полностью проходит по массиву и выполняет какие-то действия, 
//то есть при каждой итерации в numbers записывается значение элемента массива, после указываем действие над ним int.Parse(numbers) строку в числа, и ToArray()

int[] numbers = Console.ReadLine().Split(' ').Select(numbers => int.Parse(numbers)).ToArray();

void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
PrintArry(numbers);