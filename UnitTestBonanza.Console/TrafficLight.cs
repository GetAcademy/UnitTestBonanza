namespace UnitTestBonanza.Console
{
    public class TrafficLight
    {
        private int _phase = 0;
        public bool IsRed => _phase < 2;
        public bool IsYellow => _phase % 2 == 1;
        public bool IsGreen => _phase==2;

        public void Next()
        {
            var b1 = _phase == 1 || _phase == 2;
            var b2 = _phase is 1 or 2;

        }
    }
}
