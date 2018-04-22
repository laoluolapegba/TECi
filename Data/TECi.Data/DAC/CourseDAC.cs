using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECi.Entities.Domain.Courses;

namespace TECi.Data.DAC
{
    public class CourseDAC
    {
        private TECiDbContext db;
        public Course Add(Course courseentity)
        {
            using (var db = new TECiDbContext())
            {
                //db.Set<Course>().Add(course);
                db.Courses.Add(courseentity);
                db.SaveChanges();

                return courseentity;
            }
        }
    }
}
