using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170724_TwoFightersOneWinner
{
    [TestClass]
    public class TwoFightersOneWinnerTests
    {
        [TestMethod]
        public void TwoFightersOneWinnerTest1()
        {
            AssertWinnerShoudBe(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew", "Lew");
        }

        private static void AssertWinnerShoudBe(Fighter fighter1, Fighter fighter2, string firstAttacker, string expected)
        {
            var kata = new Kata();
            var acutal = kata.declareWinner(fighter1, fighter2, firstAttacker);
            Assert.AreEqual(expected, acutal);
        }
    }

    public class Kata
    {
        public string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            var winner = string.Empty;
            do
            {
                Fighter1AttachFighter2(fighter1, fighter2);
                if (Fighter2HadDeath(fighter2))
                {
                    winner = fighter1.Name;
                    break;
                }

                Fighter2AttachFighter1(fighter1, fighter2);
                if (Fighter1HadDeath(fighter1))
                {
                    winner = fighter2.Name;
                    break;
                }

            } while (!Fighter1HadDeath(fighter1) && !Fighter2HadDeath(fighter2));

            return winner;
        }

        private static bool Fighter1HadDeath(Fighter fighter1)
        {
            return fighter1.Health <=0;
        }

        private static bool Fighter2HadDeath(Fighter fighter2)
        {
            return fighter2.Health <= 0;
        }

        private static void Fighter2AttachFighter1(Fighter fighter1, Fighter fighter2)
        {
            fighter1.Health -= fighter2.DamagePerAttack;
        }

        private static void Fighter1AttachFighter2(Fighter fighter1, Fighter fighter2)
        {
            fighter2.Health -= fighter1.DamagePerAttack;
        }
    }

    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;

        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
}