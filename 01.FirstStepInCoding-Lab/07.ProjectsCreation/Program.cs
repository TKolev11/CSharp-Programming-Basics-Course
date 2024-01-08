string architectName = Console.ReadLine();
int hoursForCompletedProject = 3;
int numberOfProjects = int.Parse(Console.ReadLine());
Console.WriteLine($"The architect {architectName} will need {numberOfProjects * hoursForCompletedProject} hours to complete {numberOfProjects} project/s.");