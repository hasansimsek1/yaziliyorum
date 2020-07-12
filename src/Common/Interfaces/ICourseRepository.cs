using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface ICourseRepository: IRepository
    {
        public IEnumerable<Course> GetAll();
    }
}
