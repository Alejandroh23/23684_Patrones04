using System;

namespace _Patrones04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DisA DisplayA = new DisA();
            DisB DisplayB = new DisB();
            DisC DisplayC = new DisC();

            WD Dataweather = new WD();
            Dataweather.add(DisplayA);
            Dataweather.add(DisplayB);
            Dataweather.add(DisplayC);

            Dataweather.setMeasurements(18.2324, 183.342, 11.8334);

            Dataweather.remove(DisplayA);

            Dataweather.setMeasurements(10.2647, 78.2234, 19.5672);
        }
    }
}