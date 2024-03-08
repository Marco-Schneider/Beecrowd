
const double pi = 3.14159;
double radius, volume;

radius = Convert.ToDouble(Console.ReadLine());

volume = (4/3.0) * pi * Math.Pow(radius, 3);

Console.WriteLine("VOLUME = " + string.Format("{0:0.000}", volume));
