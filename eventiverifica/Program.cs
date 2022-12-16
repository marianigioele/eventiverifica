using System;

namespace eventiverifica
{
    class Program
    {
        static void Main(string[] args)
        {
            CStazione s = new CStazione();
            s.SensorAlarm += Alarm;

        }
        public static void Alarm(object o, EventArgs e)
        {

        }
    }
}
