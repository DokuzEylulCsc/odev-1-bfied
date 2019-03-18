using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    abstract class Asker
    {
        private Bolge koordinat;
        public Bolge Koordinat { get { return koordinat; } set { koordinat = value; } }

        public int hp=100;

        public bool isalive=true; // 

        public bool team;

        public void putcoor(int x,int y) {
            Koordinat.x = x;
            Koordinat.y = y;
        }        // ..... //

        public int Look(Ermeydani meydan, int x, int y)
        {
            if (x < 0 || x > 15 || y < 0 || y > 15) return -1;
            else
            {
                if (meydan.Harita[x, y].isempty) return 0;
                else
                {
                    if (meydan.Harita[x, y].asker.team == this.team) return 1;
                    else return 2;
                }
            }
        }

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.
        public abstract void Ates_et(Ermeydani meydan);
       public abstract void  Move_beach(Ermeydani meydan);

        public abstract void Bekle();

        // ..... //

    }
}
