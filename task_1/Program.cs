// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число А: ");
int namberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int namberB = Convert.ToInt32(Console.ReadLine());

if (namberA > namberB){
   Console.Write($"Получим: {namberA}");
} else {
   Console.Write($"Получим: {namberB}");
}
