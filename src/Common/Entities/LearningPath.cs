using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    class LearningPath: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Course> Courses { get; set; }
    }
}
