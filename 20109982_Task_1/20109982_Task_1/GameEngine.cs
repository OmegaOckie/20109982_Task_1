using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _20109982_Task_1.Character;

namespace _20109982_Task_1
{
    /// <summary>
    /// Q.3.3
    /// </summary>
    class GameEngine
    {
        public GameEngine(Map map)
        {
            this.map = map;
        }

        protected Map Map;

        public Map map
        {
            get
            {
                return Map;
            }
            set
            {
                map = value;
            }
        }
        public bool MovePlayer(Character.Movement direction)
        {
            return true;
        }

        public override string ToString()
        {
            return null;
        }
    }
}
