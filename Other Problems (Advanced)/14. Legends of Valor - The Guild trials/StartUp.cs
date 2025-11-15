using AccessControlSystem.Core;
using LegendsOfValor_TheGuildTrials.Core.Contracts;

// Chance of proper output of this program - 83/100
namespace LegendsOfValor_TheGuildTrials
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
