using System;
using Transport;
using NUnit.Framework;

namespace UnitTests.Model
{
    class CarTest
    {
        [Test]
        [TestCase(1, TestName = "Тестирование при Distabce = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при Distabce = 2.PositiveValue")]
        [TestCase(100, TestName = "Тестирование при Distabce = 100.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof (ArgumentException),
            TestName = "Тестирование при Distance = -1.NegativeValue")]
        [TestCase(-100, ExpectedException = typeof (ArgumentException),
            TestName = "Тестирование при Distance = -100.NegativeValue")]
        public void Distance(double dist)
        {
            var car = new Car();
            car.Distance = dist;
        }
        [Test]
        [TestCase(1, TestName = "Тестирование при FuelOnKillometers = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при FuelOnKillometers = 2.PositiveValue")]
        [TestCase(100, TestName = "Тестирование при FuelOnKillometers = 100.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof (ArgumentException),
            TestName = "Тестирование при FuelOnKillometers = -1.NegativeValue")]
        [TestCase(-100, ExpectedException = typeof (ArgumentException),
            TestName = "Тестирование при FuelOnKillometers = -100.NegativeValue")]
        public void FuelOnKillometers(double fok)
        {
            var car = new Car();
            car.FuelOnKillometers = fok;
        }
        [Test]
        [TestCase(1, TestName = "Тестирование при Tank = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при Tank = 2.PositiveValue")]
        [TestCase(100, TestName = "Тестирование при Tank = 100.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Tank = -1.NegativeValue")]
        [TestCase(-100, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при Tank = -100.NegativeValue")]
        public void Tank(double tank)
        {
            var car = new Car();
            car.Tank = tank;
        }
        [Test]
        [TestCase(1, TestName = "Тестирование при SpentFuel = 1.PositiveValue")]
        [TestCase(2, TestName = "Тестирование при SpentFuel = 2.PositiveValue")]
        [TestCase(100, TestName = "Тестирование при SpentFuel = 100.PositiveValue")]
        [TestCase(-1, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при SpentFuel = -1.NegativeValue")]
        [TestCase(-100, ExpectedException = typeof(ArgumentException),
            TestName = "Тестирование при SpentFuel = -100.NegativeValue")]
        public void SpentFuel(double spentfuel)
        {
            var car = new Car();
            car.SpentFuel = spentfuel;
        }

        [Test]
        public void GetSpentFuelTest()
        {
            var expected = 0.02;
            var car = new Car()
            {
                Distance = 2,
                FuelOnKillometers = 1,
                SpentFuel = 1,
                Tank = 1
            };
            var actual = car.GetSpentFuel();
            Assert.AreEqual(expected,actual);
        }
    }
}
