
const double pi = 3.14159; 

double radius = Convert.ToDouble(Console.ReadLine());

double area = pi * Math.Pow(radius, 2);

Console.WriteLine("A=" + string.Format("{0:0.0000}", area));