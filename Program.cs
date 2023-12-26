// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
string?[] strs = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    strs[i] = Console.ReadLine();
}
Console.WriteLine("Вы ввели следующий массив строк: ");
Console.WriteLine("[" + string.Join(", ",strs) + "]");
string? s = "";
for (int i = 0; i < n; i++)
{
    if (strs[i]?.Length <= 3)
    {
        if (string.IsNullOrEmpty (s)) s = strs[i];
        else s = s + " " + strs[i];
    } 
}
string[] new_strs = s.Split(' ');
Console.WriteLine("Ответ: ");
Console.WriteLine("[" + string.Join(", ",new_strs) + "]");            
