using LegendsOfValor_TheGuildTrials.Models.Contracts;
using LegendsOfValor_TheGuildTrials.Repositories.Contratcs;

namespace LegendsOfValor_TheGuildTrials.Repositories
{
    public class GuildRepository : IRepository<IGuild>
    {
        private List<IGuild> guilds = new();
        public void AddModel(IGuild entity)
        {
            guilds.Add(entity);
        }

        public IReadOnlyCollection<IGuild> GetAll()
        {
            return guilds.AsReadOnly();
        }

        public IGuild GetModel(string runeMarkOrGuildName)
        {
            return guilds.Where(g => g.Name == runeMarkOrGuildName).FirstOrDefault();
        }
    }
}
