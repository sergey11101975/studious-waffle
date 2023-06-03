// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты 1 точки");
Console.Write("X1=");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1=");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1=");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты 2 точки");
Console.Write("x2=");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y=");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2=");
int z2 = int.Parse(Console.ReadLine());
double distance = DistanceBetweenTwoPoints(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Расстояние между двумя точками равно=");
Console.Write(distance);
double DistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2){
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
