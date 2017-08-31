
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRTX.Domain.Entities.Interfaces;


namespace OpenRTX.Domain.Entities
{

    public interface ITile
    {
        List<ITile> BorderTiles { get; }
        List<ILayer> Layers { get; }
    }

    public class Tile : Entity, ITile
    {

        #region Constructors
        public Tile()
            : base()
        {
            BorderTiles = new List<ITile>();
            Layers = new List<ILayer>();
        }
        #endregion

        #region Properties
        public List<ITile> BorderTiles { get; protected set; }
        public List<ILayer> Layers { get; protected set; } 
        #endregion

    }

}
