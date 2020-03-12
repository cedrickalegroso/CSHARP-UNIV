using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
    public class Faculty : Person
    {
 
        public string FacultyPosition;
        public string FacultyCollegeAssingment;
        public string FacultySkillsandSpecialization;


        public Faculty()
            : base()
        {

            FacultyPosition = "";
            FacultyCollegeAssingment = "";
            FacultySkillsandSpecialization = "";
        }

        public Faculty(string PFN, string PLN, string PMN, string PA, string PCN, string PBD, string FP, string FCA, string FSS)
            : base(PFN, PLN, PMN, PA, PCN, PBD)
        {
 
            FacultyPosition = FP;
            FacultyCollegeAssingment = FCA;
            FacultySkillsandSpecialization = FSS;
        }

     

        public string GetFacultyPosition()
        {
            return FacultyPosition;
        }

        public string GetFacultyCollegeAssingment()
        {
            return FacultyCollegeAssingment;
        }

        public string GetFacultySkillsandSpecialization()
        {
            return FacultySkillsandSpecialization;
        }

      
        public void SetFacultyPosition(string FP) { FacultyPosition = FP; }
        public void SetFacultyCollegeAssingment(string FCA) { FacultyCollegeAssingment = FCA; }
        public void SetFacultySkillsandSpecialization(string FSS) { FacultySkillsandSpecialization = FSS; }

    }
}
