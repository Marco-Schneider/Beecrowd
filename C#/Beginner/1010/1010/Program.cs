
const int numberOfEntries = 2;
double totalPrice = 0;

for (int i = 0; i < numberOfEntries; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    int quantity = Convert.ToInt32(input[1]);
    double unitPrice = Convert.ToDouble(input[2]);

    totalPrice = totalPrice + quantity * unitPrice;
}

Console.WriteLine("VALOR A PAGAR: R$ " + string.Format("{0:0.00}", totalPrice));
