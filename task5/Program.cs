DateTime birthDate = new DateTime(2006, 11, 14);

DateTime currentDate = DateTime.Now;

TimeSpan age = currentDate - birthDate;

int ageInYears = (int)(age.TotalDays / 365.25);

DateTime dateAfter10Days = birthDate.AddDays(10);

Console.WriteLine($"Birthdate: {birthDate}");
Console.WriteLine($"Current date: {currentDate}");
Console.WriteLine($"Age: {ageInYears} years");
Console.WriteLine($"Birthdate after 10 days: {dateAfter10Days}");