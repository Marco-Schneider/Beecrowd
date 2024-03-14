
int travelledDistance;
double amountOfFuelUsed;

double vehicleAutonomy;

travelledDistance = Convert.ToInt32(Console.ReadLine());
amountOfFuelUsed = Convert.ToDouble(Console.ReadLine());

vehicleAutonomy = travelledDistance / amountOfFuelUsed;

Console.WriteLine(string.Format("{0:0.000}", vehicleAutonomy) + " km/l");
