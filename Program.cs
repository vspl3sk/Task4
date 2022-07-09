// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int third_num = Convert.ToInt32(Console.ReadLine());
int max = first_num;
if (max < second_num){
    max = second_num;
}
if (max < third_num){
    max = third_num;
}
Console.WriteLine($"Большее из этих чисел {max}");