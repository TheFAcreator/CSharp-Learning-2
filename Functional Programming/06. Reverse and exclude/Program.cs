List<int> nums = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
int divider = int.Parse(Console.ReadLine());

Predicate<int> isDivisible = n => n % divider == 0;

List<int> result = nums.FindAll(n => !isDivisible(n));

Console.WriteLine(string.Join(" ", result));