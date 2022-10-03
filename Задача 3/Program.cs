int quarter(int arg1)
{
    if (arg1 == 1)
    {
    Console.WriteLine("X > 0, Y > 0");
    }
    else if (arg1 == 2)
    {
    Console.WriteLine("X > 0, Y < 0"); 
    }
    else if (arg1 == 3)
    {
    Console.WriteLine("X < 0, Y < 0"); 
    }
    else if (arg1 == 4)
    {
    Console.WriteLine("X < 0, Y > 0"); 
    }
    return arg1;
}
int a = Convert.ToInt32(Console.ReadLine());
quarter(a);