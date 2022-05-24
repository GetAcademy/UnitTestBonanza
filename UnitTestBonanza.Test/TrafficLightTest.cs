using NUnit.Framework;
using UnitTestBonanza.Console;

namespace UnitTestBonanza.Test
{
    /*
      - teknisk sett, hvordan lage unit test
      - testdrevet utvikling
      - kodedekning
     */
    public class TrafficLightTest
    {
        [Test]
        public void TestStartsWithRed()
        {
            var trafficLight = new TrafficLight();
            Assert.IsTrue(trafficLight.IsRed);
            Assert.IsFalse(trafficLight.IsYellow);
            Assert.IsFalse(trafficLight.IsGreen);
        }
    }
}