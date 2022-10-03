// Это задание заставило подумать

double Points_2D (double arg_x1, double arg_x2, double arg_y1, double arg_y2, double distance_2D)
{
distance_2D = Math.Sqrt(Math.Pow(arg_x2 - arg_x1, 2) + Math.Pow(arg_y2 - arg_y1, 2));
Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance_2D}");
Console.ReadKey(); 
return 0;
}
double Points_3D (double arg_x1, double arg_x2, double arg_y1, double arg_y2, double arg_z1, double arg_z2, double distance_3D)
{
distance_3D = Math.Sqrt(Math.Pow(arg_x2 - arg_x1, 2) + Math.Pow(arg_y2 - arg_y1, 2) + Math.Pow(arg_z2 - arg_z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance_3D}");
Console.ReadKey();
return 0;
}
char selection;
Double x1, x2, y1, y2, z1, z2, distance_2d = 0, distance_3d = 0;

Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
Console.WriteLine("Выберите нужный пункт (1 или 2):");

selection = Convert.ToChar(Console.ReadLine());
switch (selection)
{

case '1':
Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
Points_2D(x1, x2, y1, y2, distance_2d);
break;

case '2':
Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z1: ");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты z2: ");
z2 = Convert.ToDouble(Console.ReadLine());
Points_3D(x1, x2, y1, y2, z1, z2, distance_3d);
break;

default:
Console.WriteLine("Вы ввели неверный символ");
Console.ReadKey();
break;
}

    

    
