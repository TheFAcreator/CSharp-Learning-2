using MilitaryElite.Interfaces;

namespace MilitaryElite;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Soldier> soldiers = new List<Soldier>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string soldierType = tokens[0];
            int id = int.Parse(tokens[1]);
            string firstName = tokens[2];
            string lastName = tokens[3];

            switch (soldierType)
            {
                case "Private":
                    decimal salary = decimal.Parse(tokens[4]);
                    soldiers.Add(new Private(id, firstName, lastName, salary));
                    break;

                case "LieutenantGeneral":
                    salary = decimal.Parse(tokens[4]);
                    LeutenantGeneral general = new LeutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < tokens.Length; i++)
                    {
                        int privateId = int.Parse(tokens[i]);
                        Private privateSoldier = soldiers.FirstOrDefault(s => s.Id == privateId) as Private;

                        general.Privates.Add(privateSoldier);
                    }

                    soldiers.Add(general);
                    break;

                case "Engineer":
                    salary = decimal.Parse(tokens[4]);
                    string corps = tokens[5];

                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue; // Skip invalid corps
                    }

                    Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string partName = tokens[i];
                        int hoursWorked = int.Parse(tokens[i + 1]);

                        engineer.RepairsByHours.Add(new Repair(partName, hoursWorked));
                    }

                    soldiers.Add(engineer);
                    break;

                case "Commando":
                    salary = decimal.Parse(tokens[4]);
                    corps = tokens[5];

                    if (corps != "Airforces" && corps != "Marines")
                    {
                        continue; // Skip invalid corps
                    }

                    Commando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < tokens.Length; i += 2)
                    {
                        string missionCodeName = tokens[i];
                        string missionState = tokens[i + 1];

                        if (missionState == "Finished" || missionState == "InProgress")
                        {
                            commando.Missions.Add(new Mission(missionCodeName, missionState));
                        }
                    }

                    soldiers.Add(commando);
                    break;

                case "Spy":
                    int codeNumber = int.Parse(tokens[4]);
                    soldiers.Add(new Spy(id, firstName, lastName, codeNumber));
                    break;
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier.ToString());
        }
    }
}