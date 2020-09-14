using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.2.2
    /// </summary>
    class Character : Tile
    {
        public enum Movement
        {
            NONE, UP, DOWN, LEFT, RIGHT
        }
        protected int HP, maxHP, damage;
        protected Tile[] characterVision;

        //The start of Q.2.3
        public Character(int xInput,int yInput, char symbol)
        {
            switch (symbol)
            {
                case 'H':
                    break;

                case 'E':
                    break;
            }
        }

        public virtual void Attack(Character target)
        {
            target.HP -= damage;
        }

        public bool isDead()
        {
            if(HP < 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a character is within range of it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public virtual bool CheckRange(Character target)
        {
            if( DistanceTo(target) < 1)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Determines the distance between a character and it's target.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {
            //if ()
                //int targetXPosition = target.X;
                //int targetYPosition = target.Y;
                return 0;
        }

        public void Move(Movement move)
        { 
            //NONE, UP, DOWN, LEFT, RIGHT
            switch (move)
            {
                case Movement.UP:
                    Tile.X -= 1;
                    break;
                default:
                    X = X;
                    Y = Y;
                    break;
            }
        }

        /// <summary>
        /// the method returns a direction of movement
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public abstract Movement ReturnMove(Movement move = 0)
        {

        }

        public abstract override ToString()
        {

        }
    }
}
