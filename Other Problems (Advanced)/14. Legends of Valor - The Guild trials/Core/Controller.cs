using LegendsOfValor_TheGuildTrials.Core.Contracts;
using LegendsOfValor_TheGuildTrials.Models;
using LegendsOfValor_TheGuildTrials.Models.Contracts;
using LegendsOfValor_TheGuildTrials.Repositories;
using LegendsOfValor_TheGuildTrials.Repositories.Contratcs;
using LegendsOfValor_TheGuildTrials.Utilities.Messages;
using System.Text;

namespace LegendsOfValor_TheGuildTrials.Core
{
    public class Controller : IController
    {
        private IRepository<IHero> heroes = new HeroRepository();
        private IRepository<IGuild> guilds = new GuildRepository();

        public string AddHero(string heroTypeName, string heroName, string runeMark)
        {
            if (heroTypeName != nameof(Warrior) && heroTypeName != nameof(Sorcerer) && heroTypeName != nameof(Spellblade))
            {
                return string.Format(OutputMessages.InvalidHeroType, heroTypeName);
            }
            if (heroes.GetAll().Any(h => h.RuneMark == runeMark))
            {
                return string.Format(OutputMessages.HeroAlreadyExists, runeMark);
            }

            IHero hero;
            if (heroTypeName == nameof(Warrior))
            {
                hero = new Warrior(heroName, runeMark);
            }
            else if (heroTypeName == nameof(Sorcerer))
            {
                hero = new Sorcerer(heroName, runeMark);
            }
            else
            {
                hero = new Spellblade(heroName, runeMark);
            }

            heroes.AddModel(hero);

            return string.Format(OutputMessages.HeroAdded, heroTypeName, heroName, runeMark);
        }

        public string CreateGuild(string guildName)
        {
            if (guilds.GetAll().Any(g => g.Name == guildName))
            {
                return string.Format(OutputMessages.GuildAlreadyExists, guildName);
            }

            IGuild guild = new Guild(guildName);
            guilds.AddModel(guild);

            return string.Format(OutputMessages.GuildCreated, guildName);
        }

        public string RecruitHero(string runeMark, string guildName)
        {
            if (!heroes.GetAll().Any(h => h.RuneMark == runeMark))
            {
                return string.Format(OutputMessages.HeroNotFound, runeMark);
            }
            if (!guilds.GetAll().Any(g => g.Name == guildName))
            {
                return string.Format(OutputMessages.GuildNotFound, guildName);
            }

            IHero hero = heroes.GetModel(runeMark);
            if (hero.GuildName != null)
            {
                return string.Format(OutputMessages.HeroAlreadyInGuild, hero.Name);
            }
            Guild guild = (Guild)guilds.GetModel(guildName);
            if (guild.IsFallen)
            {
                return string.Format(OutputMessages.GuildIsFallen, guildName);
            }
            if (guild.Wealth < 500)
            {
                return string.Format(OutputMessages.GuildCannotAffordRecruitment, guildName);
            }

            if ((hero is Warrior && guildName == "SorcererGuild")
                || (hero is Sorcerer && guildName == "WarriorGuild")
                || (hero is Spellblade && guildName == "ShadowGuild"))
            {
                return string.Format(OutputMessages.HeroTypeNotCompatible, hero.GetType().Name, guildName);
            }

            hero.JoinGuild(guild);
            guild.RecruitHero(hero);

            return string.Format(OutputMessages.HeroRecruited, hero.Name, guildName);
        }

        public string StartWar(string attackerGuildName, string defenderGuildName)
        {
            if (!guilds.GetAll().Any(g => g.Name == attackerGuildName) || !guilds.GetAll().Any(g => g.Name == defenderGuildName))
            {
                return string.Format(OutputMessages.OneOfTheGuildsDoesNotExist);
            }

            IGuild attackerGuild = guilds.GetModel(attackerGuildName);
            IGuild defenderGuild = guilds.GetModel(defenderGuildName);
            if (attackerGuild.IsFallen || defenderGuild.IsFallen)
            {
                return string.Format(OutputMessages.OneOfTheGuildsIsFallen);
            }

            int attackerPower = 0;
            var attackingHeroes = new List<IHero>();
            foreach (var hero in attackerGuild.Legion)
            {
                attackingHeroes.Add(heroes.GetModel(hero));
            }
            foreach (var hero in attackingHeroes)
            {
                attackerPower += hero.Power + hero.Mana + hero.Stamina;
            }

            int defenderPower = 0;
            var defendingHeroes = new List<IHero>();
            foreach (var hero in defenderGuild.Legion)
            {
                defendingHeroes.Add(heroes.GetModel(hero));
            }
            foreach (var hero in defendingHeroes)
            {
                defenderPower += hero.Power + hero.Mana + hero.Stamina;
            }

            if (attackerPower > defenderPower)
            {
                int gain = defenderGuild.Wealth;
                attackerGuild.WinWar(defenderGuild.Wealth);
                defenderGuild.LoseWar();
                return string.Format(OutputMessages.WarWon, attackerGuildName, defenderGuildName, gain);
            }
            else
            {
                int gain = attackerGuild.Wealth;
                defenderGuild.WinWar(attackerGuild.Wealth);
                attackerGuild.LoseWar();
                return string.Format(OutputMessages.WarLost, defenderGuildName, attackerGuild.Wealth, gain);
            }
        }

        public string TrainingDay(string guildName)
        {
            if (!guilds.GetAll().Any(g => g.Name == guildName))
            {
                return string.Format(OutputMessages.GuildNotFound, guildName);
            }

            IGuild guild = guilds.GetModel(guildName);
            if (guild.IsFallen)
            {
                return string.Format(OutputMessages.GuildTrainingDayIsFallen, guildName);
            }

            int total = 200 * guild.Legion.Count;
            if (guild.Wealth < total)
            {
                return string.Format(OutputMessages.TrainingDayFailed, guildName);
            }

            var heroesToTrain = new List<IHero>();
            foreach (var hero in guild.Legion)
            {
                heroesToTrain.Add(heroes.GetModel(hero));
            }

            guild.TrainLegion(heroesToTrain);
            return string.Format(OutputMessages.TrainingDayStarted, guildName, heroesToTrain.Count, total);
        }

        public string ValorState()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Valor State:");
            foreach (var guild in guilds.GetAll().OrderByDescending(g => g.Wealth))
            {
                result.AppendLine($"{guild.Name} (Wealth: {guild.Wealth})");

                var heroes = new List<IHero>();
                foreach (var hero in guild.Legion)
                {
                    heroes.Add(this.heroes.GetModel(hero));
                }
                foreach (var hero in heroes.OrderBy(h => h.Name))
                {
                    result.AppendLine("-" + hero.ToString());
                    result.AppendLine("--" + hero.Essence());
                }
            }
            return result.ToString().TrimEnd();
        }
    }
}
