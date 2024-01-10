double chickenMenu = 10.35;
double fishMenu = 12.40;
double veganMenu = 8.15;
double delievery = 2.50;

int chickenMenuQuantity = int.Parse(Console.ReadLine());
int fishMenuQuantity = int.Parse(Console.ReadLine());
int veganMenuQuantity = int.Parse(Console.ReadLine());

double chickenMenuTotalCost = chickenMenuQuantity * chickenMenu;
double fishMenuTotalCost = fishMenuQuantity * fishMenu;
double veganMenuTotalCost = veganMenuQuantity * veganMenu;
double menusTotalCost = chickenMenuTotalCost + fishMenuTotalCost + veganMenuTotalCost;
double priceForDesert = menusTotalCost * 0.20;
double orderTotalCost = menusTotalCost + priceForDesert + delievery;
Console.WriteLine(orderTotalCost);
