
double A, B, average;

A = Convert.ToDouble(Console.ReadLine());
B = Convert.ToDouble(Console.ReadLine());

average = ((A * 3.5) + (B * 7.5)) / 11.0 ;

Console.WriteLine("MEDIA = " + string.Format("{0:0.00000}", average));
