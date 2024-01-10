double neylonSquareMeterPrice = 1.50;
double paintPricePerLiter = 14.50;
double thinnerPricePerLiter = 5.00;

int requiredNeylonSquareMeter = int.Parse(Console.ReadLine());
int requiredPaintPerLiter = int.Parse(Console.ReadLine());
int requiredThinnerPerLiter = int.Parse(Console.ReadLine());
int workHoursByCraftsmen = int.Parse(Console.ReadLine());

double totalSumForNeylon = (requiredNeylonSquareMeter + 2) * neylonSquareMeterPrice;
double totalSumForPaint = (requiredPaintPerLiter * 1.10) * paintPricePerLiter;
Console.WriteLine(totalSumForPaint);
double totalSumForThinner = requiredThinnerPerLiter * thinnerPricePerLiter;
double totalSumOfBags = 0.40;
double totalSumForMaterials = totalSumForNeylon + totalSumForPaint + totalSumForThinner + totalSumOfBags;
double totalSumForCraftsmen = (totalSumForMaterials * 0.30) * workHoursByCraftsmen;
double finalSum = totalSumForMaterials + totalSumForCraftsmen;

Console.WriteLine(finalSum);