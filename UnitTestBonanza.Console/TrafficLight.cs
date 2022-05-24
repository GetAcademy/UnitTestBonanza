namespace UnitTestBonanza.Console
{
    public class TrafficLight
    {
        private int _phase = 0;
        public bool IsRed => _phase < 2;
        public bool IsYellow => _phase % 2 == 1;
        public bool IsGreen => _phase == 2;

        public void Next()
        {
            // ternary operator
            //_phase = _phase < 3 ? _phase + 1 : 0;
            _phase = (_phase + 1) % 4;
        }
    }
}
