char symb1 = char.Parse(Console.ReadLine());
char symb2 = char.Parse(Console.ReadLine());
SymbolsInBetween(symb1, symb2);
static void SymbolsInBetween(char symb1, char symb2)
{
    if (symb1 > symb2)
    {
        for (char symb = ++symb2; symb < symb1; symb++) Console.Write(symb + " ");
    }
    else
    {
        for (char symb = ++symb1; symb < symb2; symb++) Console.Write(symb + " ");
    }
}