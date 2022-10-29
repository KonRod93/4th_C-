// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
double numberB = Convert.ToInt32(Console.ReadLine());
double exponentiation = Math.Pow(numberA, numberB);
Console.WriteLine($"Ответ: {exponentiation}");