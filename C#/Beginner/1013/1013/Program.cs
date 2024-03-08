
int A, B, C;

string[] input = Console.ReadLine().Split(' ');

A = Convert.ToInt32(input[0]);
B = Convert.ToInt32(input[1]);
C = Convert.ToInt32(input[2]);

int greaterAB, greaterABC;

greaterAB = (A + B + Math.Abs(A - B)) / 2;
greaterABC = (greaterAB + C + Math.Abs(greaterAB - C)) / 2;

Console.WriteLine(greaterABC + " eh o maior");
