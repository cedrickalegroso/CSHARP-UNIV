using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
    public class Person
    {
        public string PersonFirstName;
        public string PersonLastName;
        public string PersonMiddleName;
        public string PersonAddress;
        public string PersonContactNumber;
        public string PersonBirthDate;


        public Person()
        {
            PersonFirstName = "";
            PersonLastName = "";
            PersonMiddleName = "";
            PersonAddress = "";
            PersonContactNumber = "";
            PersonBirthDate = "";
        }

        public Person(string PFN, string PLN, string PMN, string PA, string PCN, string PBD)
        {
            PersonFirstName = PFN;
            PersonLastName = PLN;
            PersonMiddleName = PMN;
            PersonAddress = PA;
            PersonContactNumber = PCN;
            PersonBirthDate = PBD;
        }

        public string GetPersonFirstName()
        {
            return PersonFirstName;
        }

        public string GetPersonLastName()
        {
            return PersonLastName;
        }

        public string GetPersonMiddleName()
        {
            return PersonMiddleName;
        }

        public string GetPersonAddress()
        {
            return PersonAddress;
        }


        public string GetPersonContactNumber()
        {
            return PersonContactNumber;
        }

        public string GetPersonBirthDate()
        {
            return PersonBirthDate;
        }

        public void SetPersonFirstName(string PFN) { PersonFirstName = PFN; }
        public void SetPersonLastName(string PLN) { PersonLastName = PLN; }
        public void SetPersonMiddleName(string PMN) { PersonMiddleName = PMN; }
        public void SetPersonAddress(string PA) { PersonAddress = PA; }
        public void SetPersonContactNumber(string PCN) { PersonContactNumber = PCN; }
        public void SetPersonBirthDate(string PBD) { PersonBirthDate = PBD; }


        public void ToString(Person p1, Person p2, Person p3, Students st1, Faculty f1, Staff sa1, Courses c1)
        {

            Console.Write("[========== OUTPUT STARTS ==========]");

            Console.WriteLine();

            Console.Write("Student \n");
            Console.Write( "Last Name: "+ p1.GetPersonLastName() + "\n");
            Console.Write( "First Name: " + p1.GetPersonFirstName() + "\n");
            Console.Write( "Middle Name: " + p1.GetPersonMiddleName()  + "\n");
            Console.Write( "Degree: " + st1.GetStudentDegree() + "\n");
            Console.Write( "Year and Section: " + st1.GetStudentYearandSection() + "\n");
            Console.Write( "Contact Number: " + p1.GetPersonContactNumber() + "\n");
            Console.Write( "BirthDate: " + p1.GetPersonBirthDate() + "\n");

            Console.WriteLine();

            Console.Write("Faculty \n");
            Console.Write("Last Name: " + p2.GetPersonLastName() + "\n");
            Console.Write("First Name: " + p2.GetPersonFirstName() + "\n");
            Console.Write("Middle Name: " + p2.GetPersonMiddleName() + "\n");
            Console.Write("Address: " + p2.GetPersonAddress() + "\n");
            Console.Write("Contact Number: " + p2.GetPersonContactNumber() + "\n");
            Console.Write("Position: " + f1.GetFacultyPosition() + "\n");
            Console.Write("College assignment: " + f1.GetFacultyCollegeAssingment() + "\n");
            Console.Write("Skills and Specialization: " + f1.GetFacultySkillsandSpecialization() + "\n");
            Console.Write("BirthDate: " + p2.GetPersonBirthDate() + "\n");

            Console.WriteLine();

            Console.Write("Staff \n");
            Console.Write("Last Name: " + p3.GetPersonLastName() + "\n");
            Console.Write("First Name: " + p3.GetPersonFirstName() + "\n");
            Console.Write("Middle Name: " + p3.GetPersonMiddleName() + "\n");
            Console.Write("Address: " + p3.GetPersonAddress() + "\n");
            Console.Write("Contact Number: " + p3.GetPersonContactNumber() + "\n");
            Console.Write("Designation: " + sa1.GetStaffDesignation() + "\n");
            Console.Write("Office assignment: " + sa1.GetStaffOfficeAssignment() + "\n");
            Console.Write("BirthDate: " + p3.GetPersonBirthDate() + "\n");

            Console.WriteLine();

            Console.Write("Courses \n");
            Console.Write("Course Title: " + c1.GetCourseTitle() + "\n");
            Console.Write("Course Description: " + c1.GetCourseDescription() + "\n");
            Console.Write("Units: " + c1.GetCourseUnits() + "\n");
            Console.Write("Degree it is offered in: " + c1.GetCourseDegreeOfferedIn() + "\n");

            Console.Write("[========== OUTPUT ENDS ==========]");

        }
    }
}
