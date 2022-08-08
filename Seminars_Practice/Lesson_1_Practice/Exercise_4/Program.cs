Console.WriteLine("Insert number 1, number 2 and number 3: ");
int N1 = Convert.ToInt32(Console.ReadLine());
int N2 = Convert.ToInt32(Console.ReadLine());
int N3 = Convert.ToInt32(Console.ReadLine());
double Number_1_Final = N1%10;
double Number_2_Final = N2%10;
double Number_3_Final = N3%10;
Console.WriteLine($"Result: {Number_1_Final} , {Number_2_Final} , {Number_3_Final}");