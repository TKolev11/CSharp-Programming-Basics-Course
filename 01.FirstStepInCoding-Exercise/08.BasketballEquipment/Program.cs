int yearTaxForTraining = int.Parse(Console.ReadLine());

double basketballSneakersPrice = yearTaxForTraining - (yearTaxForTraining * 0.40);
double basketballEquipPrice = basketballSneakersPrice - (basketballSneakersPrice * 0.20);
double ballPrice = basketballEquipPrice / 4;
double basketballAcessoriesPrice = ballPrice / 5;

double finalCost = yearTaxForTraining + basketballSneakersPrice + basketballEquipPrice + ballPrice + basketballAcessoriesPrice;
Console.WriteLine(finalCost);