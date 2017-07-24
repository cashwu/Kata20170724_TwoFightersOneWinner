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

        [TestMethod]
        public void TwoFightersOneWinnerTest2()
        {
            AssertWinnerShoudBe(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Harry", "Harry");
        }

        [TestMethod]
        public void TwoFightersOneWinnerTest3()
        {
            AssertWinnerShoudBe(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harry", "Harald");
        }

        [TestMethod]
        public void TwoFightersOneWinnerTest4()
        {
            AssertWinnerShoudBe(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald", "Harald");
        }

        [TestMethod]
        public void TwoFightersOneWinnerTest5()
        {
            AssertWinnerShoudBe(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry", "Harald");
        }

        [TestMethod]
        public void TwoFightersOneWinnerTest6()
        {
            AssertWinnerShoudBe(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Harald", "Harald");
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
            var first_attacker = fighter1.Name == firstAttacker ? fighter1 : fighter2;
            var second_attacker = fighter1.Name == firstAttacker ? fighter2 : fighter1;

            do
            {
                second_attacker.Health -= first_attacker.DamagePerAttack;
                if (second_attacker.Health <= 0)
                {
                    return first_attacker.Name;
                }

                first_attacker.Health -= second_attacker.DamagePerAttack;

                if (first_attacker.Health <= 0)
                {
                    return second_attacker.Name;
                }

            } while (first_attacker.Health >= 0 && second_attacker.Health >= 0);

            return "";
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