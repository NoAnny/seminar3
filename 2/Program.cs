// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double GetLineLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
double d = Math.Sqrt ((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
return Math.Round(d, 2);
}

System.Console.WriteLine("Введите координаты первой точки:");
System.Console.Write("х1 = ");
int x1 = int.Parse(Console.ReadLine()!);
System.Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine()!);
System.Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты второй точки:");
System.Console.Write("х2 = ");
int x2 = int.Parse(Console.ReadLine()!);
System.Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine()!);
System.Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Искомая длина отрезка равна:");
System.Console.Write(GetLineLenght(x1,y1,z1,x2,y2,z2));