using NUnit.Framework;
using UnitTestBonanza.Console;

namespace UnitTestBonanza.Test
{
    /*
      - teknisk sett, hvordan lage unit test
      - testdrevet utvikling - TDD 
      - kodedekning
     */
    public class TrafficLightTest
    {
        [Test]
        public void TestPhase1()
        {
            var trafficLight = new TrafficLight();
            Assert.IsTrue(trafficLight.IsRed);
            Assert.IsFalse(trafficLight.IsYellow);
            Assert.IsFalse(trafficLight.IsGreen);
        }

        [Test]
        public void TestPhase2()
        {
            var trafficLight = new TrafficLight();
            trafficLight.Next();
            Assert.IsTrue(trafficLight.IsRed);
            Assert.IsTrue(trafficLight.IsYellow);
            Assert.IsFalse(trafficLight.IsGreen);
        }

        [Test]
        public void TestPhase3()
        {
            var trafficLight = new TrafficLight();
            trafficLight.Next();
            trafficLight.Next();
            Assert.IsFalse(trafficLight.IsRed);
            Assert.IsFalse(trafficLight.IsYellow);
            Assert.IsTrue(trafficLight.IsGreen);
        }

        [Test]
        public void TestPhase4()
        {
            var trafficLight = new TrafficLight();
            trafficLight.Next();
            trafficLight.Next();
            trafficLight.Next();
            Assert.IsFalse(trafficLight.IsRed);
            Assert.IsTrue(trafficLight.IsYellow);
            Assert.IsFalse(trafficLight.IsGreen);
        }

        [Test]
        public void TestPhase1AfterPhase4()
        {
            // Arrange
            var trafficLight = new TrafficLight();
            trafficLight.Next(); // fase 2
            trafficLight.Next(); // fase 3
            trafficLight.Next(); // fase 4

            // Act
            trafficLight.Next(); // fase 1

            // Assert
            Assert.IsTrue(trafficLight.IsRed);
            Assert.IsFalse(trafficLight.IsYellow);
            Assert.IsFalse(trafficLight.IsGreen);
        }

        private static void DoNexts(int count, TrafficLight t)
        {
            while (count > 0)
            {
                t.Next();
                count--;
            }
        }
    }
}