//1 - Write a C# program to check if the entered number is Armstrong number? 

Console.Write("Enter a number: ");
int Number = int.Parse(Console.ReadLine());
int N = Number;
int Sum = 0;

int Len = Number.ToString().Length;
Console.WriteLine("Len: " + Len);
Console.WriteLine("Number: " + Number);

while (Number > 0)
{
    Sum += Fonkii(Number % 10, Len);
    Number /= 10;
}

Console.WriteLine("Sum: " + Sum);

if (Sum == N)
    Console.WriteLine(N + " is an Armstrong number");
else
    Console.WriteLine(N + " is not an Armstrong number");

int Fonkii(int Number, int Len)
{
    int P = Number;
    while (Len > 1)
    {
        Number *= P;
        Len--;
    }
    return Number;
}
