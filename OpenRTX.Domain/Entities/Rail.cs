
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities
{

    public enum RailType
    {
        Steam
    }

    public interface IRail
    {

        Guid Id { get; }
        RailType Type { get; }

    }

    public class Rail : Entity, IRail
    {

        #region Constructors
        public Rail()
            : base()
        { }
        #endregion

        #region Properties
        public RailType Type { get; set; }
        #endregion

    }

}
