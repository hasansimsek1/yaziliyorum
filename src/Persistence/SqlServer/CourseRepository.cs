using Common.Entities;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.SqlServer
{
    public class CourseRepository : ICourseRepository
    {
        public IEnumerable<Course> GetAll()
        {
            return new List<Course>
            {
                new Course { Name= "Introduction To Java" },
                new Course { Name= "Introduction To Python" },
            };
        }
    }
}
