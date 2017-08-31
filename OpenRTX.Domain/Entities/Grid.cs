
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities
{

    public interface IGrid
    {

        #region Properties
        Tile[,] Tiles { get; }
        int X { get; }
        int Y { get; }
        #endregion

        #region Public methods
        void CreateTerrain();
        #endregion

    }

    public class Grid : Entity, IGrid
    {

        #region Constructors
        public Grid(int height, int width)
            : base()
        {
            X = height;
            Y = width;
        }
        #endregion

        #region Properties
        public Tile[,] Tiles { get; protected set; }
        public int X { get; protected set; }
        public int Y { get; protected set; }
        #endregion

        #region Public methods
        public void CreateTerrain()
        {
            Tiles = new Tile[X, Y];

            for (var i = 0; i < X; i++)
            {
                for (var j = 0; j < Y; j++)
                {
                    var tile = new Tile();
                    tile.Layers.Add(new TerrainLayer(TerrainType.Flat));
                    Tiles[i, j] = new Tile();
                }
            }
        }
        #endregion

    }

}
