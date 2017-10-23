using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotMau.Core.Base
{
    public class EntityBase : ICloneable
    {
        [Required]
        public string Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        /// <summary>
        /// Method executed to get type of entity object.
        /// </summary>
        public static Func<EntityBase, Type> GetObjectTypeMethod = (entity) => { throw new NotImplementedException(); };

        /// <summary>
        /// Gets type of entity object.
        /// </summary>
        /// <returns></returns>
        public Type GetObjectType()
        {
            return GetObjectTypeMethod(this);
        }

        /// <summary>
        /// Clones object.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return this;
        }
    }
}
