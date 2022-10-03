string [] arr = {" ","понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(arr[a]);
if (a == 6 ^ a == 7)
{
Console.WriteLine(" - день является выходным ");
}
else 
{
Console.WriteLine(" - день не является выходным ");
}