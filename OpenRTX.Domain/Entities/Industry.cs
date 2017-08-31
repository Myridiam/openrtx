
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenRTX.Domain.Entities.Interfaces;


namespace OpenRTX.Domain.Entities
{

    public enum IndustryType
    {
        SawMill,
        Forest
    }

    public interface IIndustry
    {

        Guid Id { get; }
        string Name { get; set; }
        int MonthlyProduction { get; set; }
        IndustryType Type { get; }

    }

    public class Industry : Entity, IIndustry, IConstruction
    {

        #region Constructors
        public Industry(IndustryType type)
            : base()
        {
            Type = type;
        }
        #endregion

        #region Properties
        public string Name { get; set; }
        public IndustryType Type { get; protected set; }
        public int MonthlyProduction { get; set; }
        #endregion

    }

}
