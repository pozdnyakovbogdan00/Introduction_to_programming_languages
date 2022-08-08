Console.Write("Insert Number of the day: ");
int NumberDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string NameOfTheDay;
NameOfTheDay = "";

if (NumberDay > 0 & NumberDay < 8)
{
    if (NumberDay == 1) NameOfTheDay = "Monday";
    if (NumberDay == 2) NameOfTheDay = "Tuesday";
    if (NumberDay == 3) NameOfTheDay = "Wednesday";
    if (NumberDay == 4) NameOfTheDay = "Thursday";
    if (NumberDay == 5) NameOfTheDay = "Friday";
    if (NumberDay == 6) NameOfTheDay = "Satrurday";
    if (NumberDay == 7) NameOfTheDay = "Sunday"; 
}
else
{
    NameOfTheDay = "Неправильно введен номер дня недели [1-7]";   
}

Console.WriteLine($"{NameOfTheDay}");