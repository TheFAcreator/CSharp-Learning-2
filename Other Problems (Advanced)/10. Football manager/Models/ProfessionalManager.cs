namespace FootballManager.Models
{
    public class ProfessionalManager : Manager
    {
        public ProfessionalManager(string name)
            : base(name, 60)
        {
        }

        public override void RankingUpdate(double value)
        {
            value *= 1.5;

            if (Ranking + value < 0)
                Ranking = 0;
            else if (Ranking + value > 100)
                Ranking = 100;
            else
                Ranking += value;
        }
    }
}
