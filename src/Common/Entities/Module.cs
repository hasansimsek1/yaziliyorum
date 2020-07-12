using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    public class Module: EntityBase
    {
        public string Name { get; set; }

        public IEnumerable<Topic> Topics { get; set; }

    }
}
