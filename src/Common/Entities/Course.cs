using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    public class Course: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Prerequisites { get; set; }
        public IEnumerable<Module> Modules { get; set; }

    }
}
