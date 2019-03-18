using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Tegmen : Asker
    {
        Random rand = new Random();
        int[] damages = new int[3] { 10, 20, 25 };

        public void Fire(Asker x)
        {
            x.hp = x.hp - rand.Next(0, 2);
            if (x.hp <= 0)
            {
                x.isalive = false;
                x.hp = 0;
            }
        }
        public void Look_around(Ermeydani meydan) //etrafta biri var mı diye bakan fonksiyon 
        {
            List<int> map = new List<int>();
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y - 1));
            if (map.Contains(2)) // eğer düşman varsa 1 kare mesafesinde ateş eder
            {
                switch (map.FindIndex(i => i == 2)) // düşmanın indexini kontrol eder
                {
                    case 0:
                        Fire(meydan.Harita[this.Koordinat.x + 1, this.Koordinat.y].asker); break;
                    case 1:
                        Fire(meydan.Harita[this.Koordinat.x, this.Koordinat.y + 1].asker); break;
                    case 2:
                        Fire(meydan.Harita[this.Koordinat.x - 1, this.Koordinat.y].asker); break;
                    case 3:
                        Fire(meydan.Harita[this.Koordinat.x, this.Koordinat.y - 1].asker); break;

                }

            }
            }
        public override void Bekle()
        {
            //nothing
        }

        public override void HaraketEt()
        {

        }
    }
}
