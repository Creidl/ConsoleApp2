namespace ConsoleApp2.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Employee employee1 = new Employee();
            employee1.AddScore(1);
            employee1.AddScore(2);
            employee1.AddScore(3);

            Assert.AreEqual(6,employee1.Score);
        }
        [Test]
        public void Test2()
        {
            Employee employee1 = new Employee();
            employee1.AddScore(1);
            employee1.AddScore(-2);
            employee1.AddScore(-9);
            Assert.AreEqual(-10, employee1.Score);
        }
        [Test]
        public void Test3()
        {
            Employee employee1 = new Employee();
            employee1.AddScore(10);
            employee1.AddScore(-2);
            employee1.AddScore(-8);
            Assert.That(employee1.Score,Is.EqualTo(-0));
            //VS podpowiada taki tes zamiast tego z lekcji
            // ps liczba zero nie jest dodatnia ani ujemna
        }
    }
}