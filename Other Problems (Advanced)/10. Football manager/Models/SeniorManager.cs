namespace FootballManager.Models
{
    public class SeniorManager : Manager
    {
        public SeniorManager(string name)
            : base(name, 30)
        {
        }

        public override void RankingUpdate(double value)
        {
            if (Ranking + value < 0)
                Ranking = 0;
            else if (Ranking + value > 100)
                Ranking = 100;
            else
                Ranking += value;
        }
    }
}
