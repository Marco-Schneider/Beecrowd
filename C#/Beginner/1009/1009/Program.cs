
string employeeName = "";
double baseSalary, sales, salary;

employeeName = Console.ReadLine();
baseSalary = Convert.ToDouble(Console.ReadLine());
sales = Convert.ToDouble(Console.ReadLine());

salary = baseSalary + sales * 0.15;

Console.WriteLine("TOTAL = R$ " + string.Format("{0:0.00}", salary));
