
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities.Interfaces
{

    public interface IGame
    {

        IPlayer Player { get; }
        IWorld World { get; }

    }

}
