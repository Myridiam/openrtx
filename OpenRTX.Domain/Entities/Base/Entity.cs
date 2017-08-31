using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenRTX.Domain.Entities
{

    public interface IEntity
    {

        Guid Id { get; }

    }

    /// <summary>
    /// Abstract class from which all other entities need to derive
    /// </summary>
    public abstract class Entity : IEntity
    {

        #region Constructors
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Entity(Guid id)
        {
            Id = id;
        }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        #endregion

    }

}
