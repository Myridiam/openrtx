
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenRTX.Domain.Entities.Interfaces;


namespace OpenRTX.Domain.Entities
{

    public class Game : Entity, IGame
    {

        #region Constructors
        protected Game()
            : base()
        { }

        public Game(IPlayer player, IWorld world)
            : this()
        {
            Player = player;
            World = world;
        }
        #endregion

        #region Properties
        public IPlayer Player { get; protected set; }
        public IWorld World { get; protected set; }
        #endregion

    }

}
