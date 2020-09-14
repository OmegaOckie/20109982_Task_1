using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    abstract class Enemy : Character
    {
        protected Random rng = new Random();

        public Enemy(int xPosition, int yPosition, int enemyDamage, int maxHP, char symbol = 'E')
        {
            Console.WriteLine("dadsda");
        }

        public override string ToString()
        {
            //Following line of code will throw errors since no Enemy Classes exist yet.
            Console.WriteLine(EnemyClassName + " at " + "[" + X + ", " + Y + "]" + "(" + damage + ")");
        }
    }
}
