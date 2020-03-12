using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
    public class Courses
    {
        public string CourseTitle;
        public string CourseDescription;
        public double CourseUnits;
        public string CourseDegreeOfferedIn;

        public Courses()
        {
            CourseTitle = "";
            CourseDescription = "";
            CourseUnits = 0.0;
            CourseDegreeOfferedIn = "";
        }

        public Courses(string CT, string CD, double CU, string CDO)
        {
            CourseTitle = CT;
            CourseDescription = CD;
            CourseUnits = CU;
            CourseDegreeOfferedIn = CDO;
        }

        public string GetCourseTitle()
        {
            return CourseTitle;
        }

        public string GetCourseDescription()
        {
            return CourseDescription;
        }

        public double GetCourseUnits()
        {
            return CourseUnits;
        }

        public string GetCourseDegreeOfferedIn()
        {
            return CourseDegreeOfferedIn;
        }

        public void SetCourseTitle(string CT) { CourseTitle = CT; }
        public void SetCourseDescription(string CD) { CourseDescription = CD; }
        public void SetCourseUnits(double CU) { CourseUnits = CU; }
        public void SetCourseDegreeOfferedIn(string CDO) { CourseDegreeOfferedIn = CDO; }

    }
}
