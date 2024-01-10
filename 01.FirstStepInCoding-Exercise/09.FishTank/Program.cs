int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heigthInCm = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = lengthInCm * widthInCm * heigthInCm;
double litersVolume = aquariumVolume * 0.001;
double filledVolume = percentage / 100.0;
double totalLitersNedeed = litersVolume * (1 - filledVolume);

Console.WriteLine(totalLitersNedeed);
