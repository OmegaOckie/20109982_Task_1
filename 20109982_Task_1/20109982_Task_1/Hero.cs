using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.6
    /// </summary>
    class Hero : Character
    {
        public Hero(int xInput,int yInput, int HP)
        {
            this.HP = HP;
            maxHP = HP;
            damage = 2;
        }

        override ReturnMove()
        {
            key
        }

        public override string ToString()
        {
            return "Player Stats:\n"
                + "HP: " + maxHP
                + "Damage: " + 2
                + "[" + X + ", " + Y + "]";
        }
    }
}
