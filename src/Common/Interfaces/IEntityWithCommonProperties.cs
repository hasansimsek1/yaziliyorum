using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IEntityWithCommonProperties: IEntity
    {
        public string Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
