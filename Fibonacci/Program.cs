//2-Write a C# function to print first 100 numbers in Fibonacci series? 

ulong n1 = 0;
ulong n2 = 1;
ulong temp;
int i = 0;

Console.Write(n1 + " ");
while (i < 100)
{
    Console.Write(n2 + " ");
    temp = n2;
    n2 = n1 + n2;
    n1 = temp;
    i++;
}
