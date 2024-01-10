double depositedSum = double.Parse(Console.ReadLine());
int deposidPeriod = int.Parse(Console.ReadLine());
double annualRatePerYear = double.Parse(Console.ReadLine());

annualRatePerYear = annualRatePerYear / 100;

double compoundInterest = depositedSum * annualRatePerYear;
double interestPerMonth = compoundInterest / 12;
double totalSum = depositedSum + deposidPeriod * interestPerMonth;
Console.WriteLine(totalSum);