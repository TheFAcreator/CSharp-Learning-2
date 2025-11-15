namespace FootballManager.Models
{
    public class AmateurManager : Manager
    {
        public AmateurManager(string name)
            : base(name, 15)
        {
        }

        public override void RankingUpdate(double value)
        {
            value *= 0.75;

            if (Ranking + value < 0)
                Ranking = 0;
            else if (Ranking + value > 100)
                Ranking = 100;
            else
                Ranking += value;
        }
    }
}
