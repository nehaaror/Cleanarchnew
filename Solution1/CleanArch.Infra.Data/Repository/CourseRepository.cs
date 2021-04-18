using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository

    {
        private UniversityDBContext _Ctx;
        public CourseRepository(UniversityDBContext Ctx)
        {
            _Ctx = Ctx;
        }

        public void Add(Course course)
        {
            _Ctx.Add(course);
            _Ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _Ctx.Courses;
        }
    }
}
