using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MstcIntroCs.Library.Elements;

namespace MstcIntroCs.Library.Extensions
{
    public static class StudentExtensions
    {
        /// <summary>
        /// Adds a course to a student
        /// </summary>
        /// <param name="student"></param>
        /// <param name="course"></param>
        public static void AddCourse(this Student student, Course course)
        {
            if(student.Courses == null)
            {
                student.Courses = new List<Course>();
            }
            student.Courses.Add(course);
        }
    }
}
