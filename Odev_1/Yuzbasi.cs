using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Yuzbasi : Asker
    {
        Random rand = new Random(); // ateş etme fonksiyonu
        int[] damages = new int[3] { 15,25,40 };
        public void Fire(Asker x)
        {
            x.hp = x.hp - rand.Next(0, 2); //random damage verme
            if (x.hp <= 0)
            {
                x.isalive = false;
                x.hp = 0;
            }
        }

      
        public void Walk(Asker x)
        {
            if (x.Koordinat.x + 1 >= 15 || x.Koordinat.y + 1>=15 || x.Koordinat.x - 1 <=0 || x.Koordinat.y-1<=0) //sınır kontrol farklı saçma bir bakış açısı
            {
                x.Koordinat.x -= 1;
                x.Koordinat.y -= 1;
            }
            else
            {
                x.Koordinat.x += 1;
                x.Koordinat.y += 1;
            }
            x.Koordinat.x = x.Koordinat.x + rand.Next(0, 2);
            if (x.hp <= 0)
            {
               
            }
        }

        public override void Ates_et(Ermeydani meydan) //etrafta biri var mı diye bakan fonksiyon 
        {
            List<int> map = new List<int>();
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y - 1));
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y+1));
            map.Add(this.Look(meydan, this.Koordinat.x-1, this.Koordinat.y-1 + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y+1));
            map.Add(this.Look(meydan, this.Koordinat.x+1, this.Koordinat.y - 1));
            if (map.Contains(2)) // eğer düşman varsa 1 kare mesafesinde ateş eder
            {
                switch (map.FindIndex(i => i == 2))
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

        public override void Move_beach(Ermeydani meydan)
        {
            List<int> map = new List<int>();
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y));
            map.Add(this.Look(meydan, this.Koordinat.x, this.Koordinat.y - 1));
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y - 1 + 1));
            map.Add(this.Look(meydan, this.Koordinat.x - 1, this.Koordinat.y + 1));
            map.Add(this.Look(meydan, this.Koordinat.x + 1, this.Koordinat.y - 1));
            if (map.Contains(2)) // eğer düşman varsa 1 kare mesafesinde ateş eder
            {
                switch (map.FindIndex(i => i == 2))
                {
                    case 0:
                        Walk(meydan.Harita[this.Koordinat.x + 1, this.Koordinat.y].asker); break;
                    case 1:
                        Walk(meydan.Harita[this.Koordinat.x, this.Koordinat.y + 1].asker); break;
                    case 2:
                       Walk(meydan.Harita[this.Koordinat.x - 1, this.Koordinat.y].asker); break;
                    case 3:
                        Walk(meydan.Harita[this.Koordinat.x, this.Koordinat.y - 1].asker); break;

                }
            }
        }
    }
}
