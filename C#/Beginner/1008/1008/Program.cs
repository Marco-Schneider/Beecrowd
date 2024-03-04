
int employeeNumber, workedHours;
double paymentPerHour, salary;

employeeNumber = Convert.ToInt32(Console.ReadLine());
workedHours = Convert.ToInt32(Console.ReadLine());
paymentPerHour = Convert.ToDouble(Console.ReadLine());

salary = workedHours * paymentPerHour;

Console.WriteLine("NUMBER = " + employeeNumber);
Console.WriteLine("SALARY = U$ " + string.Format("{0:0.00}", salary));
