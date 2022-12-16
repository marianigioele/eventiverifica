using System;
using System.Collections.Generic;
using System.Text;

namespace eventiverifica
{
    class CSensore
    {
        private int mDato;
        private int mLatitudide;
        private int mLongitudine;
        private int mContatore;
        private int mMatrice;
        private int mAlarmValue;

        public int Dato
        {
            get { return mDato; }
            set { mDato = value; }
        }

        public int Latitudide
        {
            get { return mLatitudide; }
            set { mLatitudide = value; }
        }

        public int Longitudine
        {
            get { return mLongitudine; }
            set { mLongitudine = value; }
        }

        public int Contatore
        {
            get { return mContatore; }
            set { mContatore = value; }
        }

        public int Matrice
        {
            get { return mMatrice; }
            set { mMatrice = value; }
        }

        public int AlarmValue
        {
            get { return mAlarmValue; }
            set { mAlarmValue = value; }
        }

        public CSensore()
        {
            this.Dato = 0;
            this.Latitudide = 0;
            this.Longitudine = 0;
            this.Contatore = 0;
            this.Matrice = 0;
            this.AlarmValue = 0;
        }

        public CSensore(int a,int b,int c,int d)
        {
            this.Latitudide = a;
            this.Longitudine = b;
            this.Matrice = c;
            this.AlarmValue = d;
        }

        public void GetSensorValue()
        {
            Random rnd = new Random();
            if(Matrice < 4)
            {
                Dato = rnd.Next(-10, 30);
            }
            else
            {
                Dato = rnd.Next(0, 100);
            }
        }
    }
}
