using Singleton;

var s = SingletonDataContainer.Instance;
Console.WriteLine(s.GetPopulation("Sofia"));

var s1 = SingletonDataContainer.Instance;
Console.WriteLine(s1.GetPopulation("Plovdiv"));

var s2 = SingletonDataContainer.Instance;
Console.WriteLine(s2.GetPopulation("Varna"));
Console.WriteLine(s2.GetPopulation("Seoul"));
Console.WriteLine(s2.GetPopulation("Tokyo"));