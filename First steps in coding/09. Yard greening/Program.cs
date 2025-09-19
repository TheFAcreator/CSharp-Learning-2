double meters2 = double.Parse(Console.ReadLine());
double price = meters2 * 7.61;
double discount = 0.18 * price;
double finalPrice = price - discount;
Console.WriteLine("The final price is: " + finalPrice + " lv.");
Console.WriteLine("The discount is: " + discount + " lv.");