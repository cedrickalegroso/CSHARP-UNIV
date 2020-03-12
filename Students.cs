using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
    public class Students : Person
    {
        public string StudentDegree;
        public string StudentYearandSection;

        public Students() : base()
        {
            StudentDegree = "";
            StudentYearandSection = "";
        }

        public Students(string PFN, string PLN, string PMN, string PA, string PCN, string PBD, string SD, string SYS)
            : base(PFN, PLN, PMN, PA, PCN, PBD)
        {
            StudentDegree = SD;
            StudentYearandSection = SYS;
        }

        public string GetStudentDegree()
        {
            return StudentDegree;
        }

        public string GetStudentYearandSection()
        {
            return StudentYearandSection;
        }

        public void SetStudentDegree(string SD) { StudentDegree = SD; }
        public void SetStudentYearandSection(string SYS) { StudentYearandSection = SYS; }

    }
}
