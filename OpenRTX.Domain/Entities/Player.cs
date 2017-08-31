
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities
{

    public interface IPlayer : IEntity
    {

        string Name { get; set; }

        bool IsComputerControlled { get; set; }

    }

    public class Player : Entity, IPlayer
    {

        #region Constructors
        public Player()
            : base()
        { }
        #endregion

        #region Properties
        public string Name { get; set; }

        public bool IsComputerControlled { get; set; }
        #endregion

    }

}
