using System.ComponentModel.Design;
using System.Diagnostics;

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

            //string numberType;
            //if (_phase % 2 == 0)
            //{
            //    numberType = "partall";
            //}
            //else
            //{
            //    numberType = "oddetall";
            //}

            //string numberType2 = "oddetall";
            //if (_phase % 2 == 0)
            //{
            //    numberType2 = "partall";
            //}

            //var numberType3 = _phase % 2 == 0 ? "partall" : "oddetall";

            //var dayNo = 3;
            //var dayName =
            //    dayNo == 0 ? "Mandag" :
            //    dayNo == 1 ? "Tirsdag" :
            //    dayNo == 2 ? "Onsdag" :
            //    dayNo == 3 ? "Torsdag" :
            //    dayNo == 4 ? "Fredag" :
            //    dayNo == 5 ? "Lørdag" :
            //    dayNo == 6 ? "Søndag" :
            //    "Ugyldig dag";

            //var dayName2 = dayNo switch
            //{
            //    0 => "Mandag",
            //    1 => "Tirsdag",
            //    _ => "Ukjent"
            //};
        }
    }
}
