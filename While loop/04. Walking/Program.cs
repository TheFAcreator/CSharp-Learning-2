int stepsRequired = 10000;
int steps = 0;
while (true)
{
    string input = Console.ReadLine();
    if (input != "Going home")
    {
        int addSteps = int.Parse(input);
        steps += addSteps;
        if (steps >= stepsRequired)
        {
            Console.WriteLine($"Goal reached! Good job!\n{steps - stepsRequired} steps over the goal!");
            break;
        }
    }
    else
    {
        int addSteps = int.Parse(Console.ReadLine());
        steps += addSteps;
        if (steps >= stepsRequired)
        {
            Console.WriteLine($"Goal reached! Good job!\n{steps - stepsRequired} steps over the goal!");
            break;
        }
        else
        {
            Console.WriteLine($"{stepsRequired - steps} more steps to reach goal.");
            break;
        }
    }
}