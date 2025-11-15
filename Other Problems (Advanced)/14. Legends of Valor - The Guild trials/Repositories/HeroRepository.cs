using LegendsOfValor_TheGuildTrials.Models.Contracts;
using LegendsOfValor_TheGuildTrials.Repositories.Contratcs;

namespace LegendsOfValor_TheGuildTrials.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {
        private List<IHero> heroes = new();
        public void AddModel(IHero entity)
        {
            heroes.Add(entity);
        }

        public IReadOnlyCollection<IHero> GetAll()
        {
            return heroes.AsReadOnly();
        }

        public IHero GetModel(string runeMarkOrGuildName)
        {
            return heroes.Where(h => h.RuneMark == runeMarkOrGuildName).FirstOrDefault();
        }
    }
}
