int num = int.Parse(Console.ReadLine());

int sum = 0;

int copy = 0;

bool flag = false;

for (int i = 1; i <= num; i++)

{

    copy = i;

    while (i > 0)

    {

        sum += i % 10;

        i = i / 10;

    }

    flag = (sum == 5) || (sum == 7) || (sum == 11);

    Console.WriteLine("{0} -> {1}", copy, flag);

    sum = 0;

    i = copy;

}