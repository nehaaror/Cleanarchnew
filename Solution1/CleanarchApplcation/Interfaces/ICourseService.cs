using CleanarchApplcation.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanarchApplcation.Interfaces
{
   public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
