// На самом деле я не понял для чего именно в этой задаче использовать массивы и функции(сделал и с тем что было на лекции и так как на мой взгляд проще)
// я бы сделал так(ибо по условию задачи есть всего 2 числа):
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a == b*b)
    {
        Console.WriteLine("Число a является квадратом числа b"); 
    }
    else
    {
        Console.WriteLine("Число a не является квадратом числа b");
    }
}
else if (b > a)
{
    if (b == a*a)
    {
        Console.WriteLine("Число b является квадратом числа a"); 
    }
    else
    {
        Console.WriteLine("Число b не является квадратом числа a");
    }
}
else 
{
   Console.WriteLine("Числа a и b равны"); 
}

// С использованием массива и функции
int Сheck(int arg1, int arg2)
{
 if (arg1 > arg2)
{
    if ( arg1 == arg2*arg2)
    {
    Console.WriteLine("Первое число является квадратом второго числа");
    }
    else
    { 
    Console.WriteLine("Первое число не является квадратом второго числа");  
    }
}
else if (arg2 > arg1)
{
    if ( arg2 == arg1*arg1)    
    {
    Console.WriteLine("Второе число является квадратом первого числа"); 
    }   
    else 
    {
    Console.WriteLine("Второе число не является квадратом первого числа");     
    }
}
else 
{
   Console.WriteLine("Числа равны");  
}
return 0;
}
int a = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[a];
for( int i = 0; i < a; i++)
{
 arr[i] = Convert.ToInt32(Console.ReadLine()); 
 
}
Сheck(arr[0], arr[1]);