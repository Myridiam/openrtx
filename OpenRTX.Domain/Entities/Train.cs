
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpenRTX.Domain.Entities
{

    public interface ITrain
    {

        Guid Id { get; }
        string Name { get; set; }

    }

    public class Train : Entity, ITrain
    {

        #region Constructors
        public Train()
            : base()
        {

        }
        #endregion

        #region Properties
        public string Name { get; set; }
        #endregion

    }

}
