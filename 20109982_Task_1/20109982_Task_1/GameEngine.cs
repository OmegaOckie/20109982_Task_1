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
        private Map myMap { get; }

        public GameEngine()
        {
            myMap = new Map();
        }

        public bool MovePlayer(Movement direction)
        {
            //Needs to be done with keystrokes.
        }
    }
}
