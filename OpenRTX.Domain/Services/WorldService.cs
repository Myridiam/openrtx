
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenRTX.Domain.Entities;


namespace OpenRTX.Domain.Services
{

    public class WorldService
    {

        public IWorld CreateGameWorld()
        {
            var world = new World();
            world.Grid.CreateTerrain();
            
            return world;
        }        

    }

}
