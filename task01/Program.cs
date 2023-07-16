//  Напишите программу, которая принимает на вход координаты 
//  двух точек и находит расстояние между ними в 3D пространстве. 
//  A (3,6,8); B (2,1,-7), -> 15.84 
//  A (7,-5, 0); B (1,-1,9) -> 11.53


int Coordinat(string message) 
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
double Distance(int x, int y, int z, int x1, int y1, int z1) 
{
    double distance = Math.Sqrt((x1 - x)*(x1 - x) + (y1 - y)*(y1 - y) + (z1 - z)*(z1 - z));
    return distance;
}

int x1 = Coordinat("Введите x координату точки 1: ");
int y1 = Coordinat("Введите y координату точки 1: ");
int z1 = Coordinat("Введите z координату точки 1: ");

int x2 = Coordinat("Введите x координату точки 2: ");
int y2 = Coordinat("Введите y координату точки 2: ");
int z2 = Coordinat("Введите z координату точки 2: ");

Console.WriteLine("Расстояние между точками: " + Distance(x1, y1, z1, x2, y2, z2));