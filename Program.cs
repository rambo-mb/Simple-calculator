Console.WriteLine("Oddiy kalkulyatorga xush kelibsiz!");
Console.Write("Kiriting: ");
string input = Console.ReadLine();

if (input.IndexOf("+") != -1)
{
    int a = Convert.ToInt32(input.Substring(0, input.IndexOf("+")));
    int b = Convert.ToInt32(input.Substring(input.IndexOf("+")+1));
    Console.WriteLine($"Natija: {a + b}");
}
else if (input.IndexOf("-") != -1)
{
    int a = Convert.ToInt32(input.Substring(0, input.IndexOf("-")));
    int b = Convert.ToInt32(input.Substring(input.IndexOf("-")+1));
    Console.WriteLine($"Natija: {a - b}");
}
else if (input.IndexOf("*") != -1)
{
    int a = Convert.ToInt32(input.Substring(0, input.IndexOf("*")));
    int b = Convert.ToInt32(input.Substring(input.IndexOf("*")+1));
    Console.WriteLine($"Natija: {a * b}");
}
else if (input.IndexOf("/") != -1)
{
    int a = Convert.ToInt32(input.Substring(0, input.IndexOf("/")));
    int b = Convert.ToInt32(input.Substring(input.IndexOf("/")+1));
    Console.WriteLine($"Natija: {a / b}");
}
else
{
    Console.WriteLine("Noto'g'ri formatda kiritdingiz!");
}
