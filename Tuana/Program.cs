//3-Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1 

Console.Write("Enter a line: ");
string word = Console.ReadLine().ToLower();
Console.WriteLine("Given word: " + word);
int len = word.Length;
char c;
int r = 0;


for  (int i = 0; i < len; i++)
{
    c = word[i];
    if (fonkii(word, c, i) == false)
    {
        for (int j = 0; j < len; j++)
            if (word[j] == c)
                r++;
        Console.WriteLine(c + ": " + r);
    }
    r = 0;
}

bool fonkii(string str, char c, int len)
{
    for (int i = 0; i < len; i++)
    {
        if (str[i] == c)
            return true;
    }
    return false;
}