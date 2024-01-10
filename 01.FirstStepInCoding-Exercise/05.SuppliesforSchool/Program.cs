double packetWithPens = 5.80;
double packetWithMarkers = 7.20;
double medicinePerLiter = 1.20;

int numPacketsOfPens = int.Parse(Console.ReadLine());
int numPacketsOfMarkers = int.Parse(Console.ReadLine());
int litersMedicineForCleaning = int.Parse(Console.ReadLine());
int discountRate = int.Parse(Console.ReadLine());

double totalSumOfPens = numPacketsOfPens * packetWithPens;
double totalSumOfMarkers = numPacketsOfMarkers * packetWithMarkers;
double totalSumOfMedicine = medicinePerLiter * litersMedicineForCleaning;

double totalSumBeforeDiscount = totalSumOfPens + totalSumOfMarkers + totalSumOfMedicine;
double discount = totalSumBeforeDiscount * (discountRate / 100.0);
double totalSumAfterDiscount = totalSumBeforeDiscount - discount;

Console.WriteLine(totalSumAfterDiscount);