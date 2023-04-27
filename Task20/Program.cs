﻿// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double d = Math.Sqrt(5);

// double num = 5.099786232;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);

// double pw = Math.Pow(3, 6);

Console.WriteLine("Введите координаты точки А ()");
Console.Write("X1: ");
double x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
double x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double y2Coordinate = Convert.ToInt32(Console.ReadLine());

double dist = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);

Console.WriteLine(dist);


double Distance (double x1, double y1, double x2, double y2)
{
   double sumcatet = Math.Pow((x2 -x1), 2) + Math.Pow((y2 -y1), 2);

   double distance = Math.Sqrt(sumcatet);

   double round = Math.Round(distance,2, MidpointRounding.ToZero);

   return round;
}


Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2 , MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2 )
{
    int katet1 = x1 - x2;
    int katet2 = y2 - y1;
    double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
    return hypo; 
}



Console.WriteLine("Введите координаты точки A");
Console.WriteLine("x = ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.WriteLine("x = ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y = ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Distance (xA, yA, xB, yB);

Console.WriteLine(Math.Round(distance, 2 , MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2 )
{
    int katet1 = x1 - x2;
    int katet2 = y2 - y1;
    double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
    return hypo; 
}