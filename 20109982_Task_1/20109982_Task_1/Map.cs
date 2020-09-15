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

            mapArray = new Tile[mapWidth, mapHeight];
            myEnemies = new Enemy[(mapWidth + mapHeight) / 3];

            Create(Tile);
            UpdateVision();
        }

        public void UpdateVision()
        {
            Tile tileTemp;
            foreach (Tile temporaryVariable in myEnemies)
            {
                for (int i = -1; i < 2; i++)
                {

                }
            }
        }

        private Tile Create(Tile type)
        {
            int randomX = rng.Next(mapWidth);
            int randomY = rng.Next(mapHeight);

            switch (type)
            {

                case Tile.TileType.HERO:
                    
                    mapArray[randomX, randomY] = 'H';
                    break;
                case Enemy:
                    mapArray[randomX, randomY] = 'G';
                    break;
            }
        }
    }
}
