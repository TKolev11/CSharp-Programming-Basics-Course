double dogFoodPrice = 2.50;
double catFoodPrice = 4;

int numOfDogFoodPackages = int.Parse(Console.ReadLine());
int numOfCatFoodPackages = int.Parse(Console.ReadLine());

Console.WriteLine($"{(numOfDogFoodPackages * dogFoodPrice) + (numOfCatFoodPackages * catFoodPrice)} lv.");