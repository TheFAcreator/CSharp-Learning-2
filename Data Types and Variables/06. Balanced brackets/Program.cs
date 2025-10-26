public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool balanced = false;
        bool check = true;
        int count1 = 0;
        int count2 = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (input == "(")
            {
                if (!balanced)
                {
                    balanced = true;
                    count1++;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            else if (input == ")")
            {
                if (balanced)
                {
                    balanced = false;
                    count2++;
                }
                else
                {
                    check = false;
                    break;
                }
            }
        }
        if (check && count1 == count2) Console.WriteLine("BALANCED");
        else Console.WriteLine("UNBALANCED");
    }
}