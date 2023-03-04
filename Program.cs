int AverageDigit (int nam)
{
int dec = nam / 10;
int average = dec%10;
return average;
}
Console.WriteLine("Input three-digit namber");
int nam = Convert.ToInt32(Console.ReadLine());
int result = AverageDigit(nam);
Console.WriteLine($"Average digit of {nam} -> {result}");