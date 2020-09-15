using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_Task_1
{
    class Map
    {
        /// <summary>
        /// Q.3.1 The variables are declared here.
        /// </summary>
        protected Tile[,] mapArray;
        protected Hero myHero = new Hero();
        protected Enemy[] myEnemies;
        protected int mapWidth;
        protected int mapHeight;
        protected Random rng = new Random();

        public Map(int minimumWidth, int maximumWidth, int minimumHeight, int maximumHeight, int numberOfEnemies)
        {

            //Randomised the dimensions of the map.
            int mapWidth = rng.Next(minimumWidth, maximumWidth);
            int mapHeight = rng.Next(minimumHeight, maximumHeight);

            mapArray = new Tile[randomWidth, randomHeight];
            myEnemies = new Enemy[(randomWidth + randomHeight) / 3];

            Create(Tile);
            UpdateVision();
        }

        public void UpdateVision()
        {

        }

        private Tile Create(Tile type)
        {
            int randomX = rng.Next(mapWidth);
            int randomY = rng.Next(mapHeight);

            switch (type)
            {
                case HERO:
                    mapArray[randomX, randomY] = 'H';
                    break;
                case Enemy:
                    mapArray[randomX, randomY] = 'G';
                    break;
            }
        }
    }
}
