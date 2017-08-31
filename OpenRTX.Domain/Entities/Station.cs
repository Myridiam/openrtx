
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRTX.Domain.Entities.Interfaces;


namespace OpenRTX.Domain.Entities
{

    public enum StationType
    {
        Small,
        Medium,
        Large
    }

    public interface IStation
    {

        Guid Id { get; }
        string Name { get; set; }
        List<IStation> Connections { get; set; }
        StationType Type { get; }

    }

    public class Station : Entity, IStation, IConstruction
    {

        #region Constructors
        public Station(StationType type)
            : base()
        {
            Type = type;
            Connections = new List<IStation>();
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public StationType Type { get; protected set; }
        public List<IStation> Connections { get; set; }
        #endregion

    }

}
