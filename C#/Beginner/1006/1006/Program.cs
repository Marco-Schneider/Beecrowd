
double A, B, C, average;

A = Convert.ToDouble(Console.ReadLine());
B = Convert.ToDouble(Console.ReadLine());
C = Convert.ToDouble(Console.ReadLine());

average = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

Console.WriteLine("MEDIA = " + string.Format("{0:0.0}", average));
