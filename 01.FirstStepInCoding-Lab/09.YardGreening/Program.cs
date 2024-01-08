double pricePerSquareMeter = 7.61;
double discountRate = 0.18;

double totalSquareMeters = double.Parse(Console.ReadLine());
double totalPriceBeforeDiscount = totalSquareMeters * pricePerSquareMeter;
double totalPriceAfterDiscount = discountRate * totalPriceBeforeDiscount;
double finalPrice = totalPriceBeforeDiscount - totalPriceAfterDiscount;

Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
Console.WriteLine($"The discount is: {totalPriceAfterDiscount:F2} lv.");
