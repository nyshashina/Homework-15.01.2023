// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите координату первой точки по оси x");
int coordX1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату первой точки по оси y");
int coordY1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату первой точки по оси z");
int coordZ1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по оси x");
int coordX2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по оси y");
int coordY2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координату второй точки по оси z");
int coordZ2 = int.Parse(Console.ReadLine() ?? "0");

int sqrdist = (coordX2 - coordX1) * (coordX2 - coordX1) + (coordY2 - coordY1) * (coordY2 - coordY1) + (coordZ2 - coordZ1) * (coordZ2 - coordZ1);
double dist = Math.Sqrt(sqrdist);

Console.WriteLine("Расстояние между этими точками равно " + dist);