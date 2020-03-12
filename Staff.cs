using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
   public class Staff : Person
    {
       public string StaffDesignation;
       public string StaffOfficeAssignment;

       public Staff()
           : base()
       {
        
           StaffDesignation = "";
           StaffOfficeAssignment = "";
       }

       public Staff(string PFN, string PLN, string PMN, string PA, string PCN, string PBD, string SD, string SOA)
           : base(PFN, PLN, PMN, PA, PCN, PBD)
       {
   
           StaffDesignation = SD;
           StaffOfficeAssignment = SOA;
       }

   
       public string GetStaffDesignation()
       {
           return StaffDesignation;
       }

       public string GetStaffOfficeAssignment()
       {
           return StaffOfficeAssignment;
       }

     
       public void SetStaffDesignation(string SD) { StaffDesignation = SD; }
       public void SetStaffOfficeAssignment(string SOA) { StaffOfficeAssignment = SOA; }

    }
}
