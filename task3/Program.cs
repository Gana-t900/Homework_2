// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру недели:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
string isWeekend = (dayOfWeek > 0 && dayOfWeek < 8) 
? (dayOfWeek == 6 || dayOfWeek == 7) ? "да" : "нет"
: "не день недели";
Console.WriteLine($"{dayOfWeek} -> {isWeekend}");