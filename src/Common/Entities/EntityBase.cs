using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    public class EntityBase : IEntityWithCommonProperties
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
