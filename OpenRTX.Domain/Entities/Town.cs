
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenRTX.Domain.Entities.Interfaces;


namespace OpenRTX.Domain.Entities
{

    public interface ITown
    {

        Guid Id { get; }
        string Name { get; set; }
        int PopulationCount { get; set; }

    }

    public class Town : Entity, ITown, IConstruction
    {

        #region Constructors
        public Town(string name, int startPopulationCount)
            : base()
        {
            Name = name;
            PopulationCount = startPopulationCount;
        }
        #endregion

        #region Properties
        public string Name { get; set; }

        public int PopulationCount { get; set; }
        #endregion

    }

}
