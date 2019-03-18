using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odev_1
{
    class Takim
    {
        Asker[] birlik = new Asker[7];

        public Asker[] Birlik { get { return birlik; } set { birlik = value; } }

        public void yasayankaldimi()
        {
            int x = 7;
            if()
        }

        public void create_team(int x, int y, bool team)
        {
            Asker a = new Yuzbasi();
            a.putcoor(x + 2, y + 2);
            a.team = team;
            birlik[0] = a;
            a = new Er();
            a.putcoor(x + 4, y + 4);
            a.team = team;
            birlik[1] = a;
            a = new Er();
            a.putcoor(x + 4, y);
            a.team = team;
            birlik[2] = a;
            a = new Er();
            a.putcoor(x, y + 4);
            a.team = team;
            birlik[3] = a;
            a = new Er();
            a.putcoor(x, y);
            a.team = team;
            birlik[4] = a;
            a = new Tegmen();
            a.putcoor(x + 1, y + 1);
            a.team = team;
            birlik[5] = a;
            a = new Tegmen();
            a.putcoor(x + 3, y + 3);
            a.team = team;
            birlik[6] = a;

        }
    }
}