
const double pi = 3.14159;
double A, B, C;

string[] input = Console.ReadLine().Split(' ');

A = Convert.ToDouble(input[0]);
B = Convert.ToDouble(input[1]);
C = Convert.ToDouble(input[2]);

double triangleArea, circleArea, trapezeArea, squareArea, rectangleArea;

triangleArea = (A * C) / 2.0;
circleArea = pi * Math.Pow(C, 2);
trapezeArea = (A + B) * (C / 2.0);
squareArea = Math.Pow(B, 2);
rectangleArea = A * B;

Console.WriteLine("TRIANGULO: " + string.Format("{0:0.000}", triangleArea));
Console.WriteLine("CIRCULO: " + string.Format("{0:0.000}", circleArea));
Console.WriteLine("TRAPEZIO: " + string.Format("{0:0.000}", trapezeArea));
Console.WriteLine("QUADRADO: " + string.Format("{0:0.000}", squareArea));
Console.WriteLine("RETANGULO: " + string.Format("{0:0.000}", rectangleArea));
