
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities
{

    public interface IWorld
    {

        IGrid Grid { get; }

    }

    public class World : Entity, IWorld
    {

        #region Constructors
        public World()
            : base(Guid.NewGuid())
        {
            
        }
        #endregion

        #region Properties
        public IGrid Grid { get; protected set; }
        #endregion

        public void GenerateWorld(int dimensionX, int dimensionY)
        {
            Grid = new Grid(dimensionY, dimensionX);
            Grid.CreateTerrain();
        }

    }

}
