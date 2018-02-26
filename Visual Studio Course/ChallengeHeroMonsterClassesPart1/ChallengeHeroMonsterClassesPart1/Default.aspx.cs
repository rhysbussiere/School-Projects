using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            Hero myHero = new Hero();

            myHero.Name = "Rhys";
            myHero.Health = 100;
            myHero.MaxDamage = 20;
            myHero.Bonus = false;

            Monster theMonster = new Monster();

            theMonster.Name = "Monster";
            theMonster.Health = 100;
            theMonster.MaxDamage = 20;
            theMonster.Bonus = true;

            int Damage = HeroDamage();
            theMonster.Defend(Damage);

            Damage = MonsterDamage();
            myHero.Defend(Damage);

            FirstOutcome(myHero);
            SecondOutcome(theMonster);

        }

        public int HeroDamage()
        {
            int heroAttack = random.Next(0, 21);
            return heroAttack;
        }

        public int MonsterDamage()
        {
            int monsterAttack = random.Next(0, 21);
            return monsterAttack;
        }

        private void FirstOutcome(Hero hero)
        {
            resultLabel1.Text += String.Format("Name: {0} - Damage Dealt: {1} - Attack Bonus: {2}", hero.Name, hero.MaxDamage, hero.Bonus);
            resultLabel2.Text += String.Format("Hero Health: {0}", hero.Health);
        }

        private void SecondOutcome(Monster monster)
        {
            resultLabel3.Text += String.Format("Name: {0} - Damage Dealt: {1} - Attack Bonus: {2}", monster.Name, monster.MaxDamage, monster.Bonus);
            resultLabel4.Text += String.Format("Monster Health: {0}", monster.Health);
        }
    }

    class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDamage { get; set; }
        public bool Bonus { get; set; }

        public void Defend(int heroAttack)
        {
            this.Health -= heroAttack;
        }
    }

    class Monster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxDamage { get; set; }
        public bool Bonus { get; set; }

        public void Defend(int monsterAttack)
        {
            this.Health -= monsterAttack;
        }
    }
}