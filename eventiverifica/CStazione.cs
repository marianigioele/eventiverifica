using System;
using System.Collections.Generic;
using System.Text;

namespace eventiverifica
{
    class CStazione
    {
        public void test()
        {
            CSensore sensore1 = new CSensore(20, 0, 1, 20);
            CSensore sensore2 = new CSensore(15, 5, 2, 20);
            CSensore sensore3 = new CSensore(10, 10, 3, 20);
            CSensore sensore4 = new CSensore(5, 15, 4, 50);
            CSensore sensore5 = new CSensore(0, 20, 5, 50);
            int i = 1;
            while (i == 0)
            {
                sensore1.GetSensorValue();
                if (sensore1.Dato > sensore1.AlarmValue)
                {
                    sensore1.Contatore++;
                    if (sensore1.Contatore >= 5 && sensore1.Contatore < 10)
                    {
                        chiamaSensorAlarm(null, null);
                    }
                    if (sensore1.Contatore > 10)
                    {
                        chiamaSensorRestore(null, null);
                    }
                }

                sensore2.GetSensorValue();
                if (sensore2.Dato > sensore2.AlarmValue)
                {
                    sensore2.Contatore++;
                    if (sensore2.Contatore >= 5 && sensore2.Contatore < 10)
                    {
                        chiamaSensorAlarm(null, null);
                    }
                    if (sensore2.Contatore > 10)
                    {
                        chiamaSensorRestore(null, null);
                    }
                }

                sensore3.GetSensorValue();
                if (sensore3.Dato > sensore3.AlarmValue)
                {
                    sensore3.Contatore++;
                    if (sensore3.Contatore >= 5 && sensore3.Contatore < 10)
                    {
                        chiamaSensorAlarm(null, null);
                    }
                    if (sensore3.Contatore > 10)
                    {
                        chiamaSensorRestore(null, null);
                    }
                }

                sensore4.GetSensorValue();
                if (sensore4.Dato > sensore4.AlarmValue)
                {
                    sensore4.Contatore++;
                    if (sensore4.Contatore >= 5 && sensore4.Contatore < 10)
                    {
                        chiamaSensorAlarm(null, null);
                    }
                    if (sensore4.Contatore > 10)
                    {
                        chiamaSensorRestore(null, null);
                    }
                }

                sensore5.GetSensorValue();
                if (sensore5.Dato > sensore5.AlarmValue)
                {
                    sensore5.Contatore++;
                    if (sensore5.Contatore >= 5 && sensore5.Contatore < 10)
                    {
                        chiamaSensorAlarm(null, null);
                    }
                    if (sensore5.Contatore > 10)
                    {
                        chiamaSensorRestore(null, null);
                    }
                }
            }
            
        }
        protected virtual void chiamaSensorAlarm(object o, EventArgs e)
        {
            SensorAlarm?.Invoke(null, null);
        }
        public event EventHandler SensorAlarm;
        protected virtual void chiamaSensorRestore(object o, EventArgs e)
        {
            SensorRestore?.Invoke(null, null);
        }
        public event EventHandler SensorRestore;
    }
}
