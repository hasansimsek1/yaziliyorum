using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface ICourseService
    {
        public List<Course> GetAll();
    }
}
