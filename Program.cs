using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c08_Alegroso_University
{
    class Program
    {
        static void Main(string[] args)
        {

            // declaration of class

            // persons
            Person p1 = new Person();
            Person p2 = new Person();
            Person p3 = new Person();

            // student
            Students st1 = new Students();

            // faculty
            Faculty f1 = new Faculty();

            // staff
            Staff sa1 = new Staff();

            // course
            Courses c1 = new Courses();


            // Questions

            // Students 
            Console.WriteLine();
            Console.Write("Students \n");
            Console.Write("Last Name: ");
            p1.SetPersonLastName(Console.ReadLine());
            Console.Write("First Name: ");
            p1.SetPersonFirstName(Console.ReadLine());
            Console.Write("Middle Name: ");
            p1.SetPersonMiddleName(Console.ReadLine());
            Console.Write("Degree: ");
            st1.SetStudentDegree(Console.ReadLine());
            Console.Write("Year and Section: ");
            st1.SetStudentYearandSection(Console.ReadLine());
            Console.Write("Contact Number: ");
            p1.SetPersonContactNumber(Console.ReadLine());
            Console.Write("Birth Date: ");
            p1.SetPersonBirthDate(Console.ReadLine());
            Console.WriteLine();


            // Faculty 
            Console.WriteLine();
            Console.Write("Faculty \n");
            Console.Write("Last Name: ");
            p2.SetPersonLastName(Console.ReadLine());
            Console.Write("First Name: ");
            p2.SetPersonFirstName(Console.ReadLine());
            Console.Write("Middle Name: ");
            p2.SetPersonMiddleName(Console.ReadLine());
            Console.Write("Address: ");
            p2.SetPersonAddress(Console.ReadLine());
            Console.Write("Contact Number: ");
            p2.SetPersonContactNumber(Console.ReadLine());
            Console.Write("Position: ");
            f1.SetFacultyPosition(Console.ReadLine());
            Console.Write("College Assignment: ");
            f1.SetFacultyCollegeAssingment(Console.ReadLine());
            Console.Write("Skills and Specialization: ");
            f1.SetFacultySkillsandSpecialization(Console.ReadLine());
            Console.Write("Birth Date: ");
            p2.SetPersonBirthDate(Console.ReadLine());
            Console.WriteLine();

            // Staff
            Console.WriteLine();
            Console.Write("Staff \n");
            Console.Write("Last Name: ");
            p3.SetPersonLastName(Console.ReadLine());
            Console.Write("First Name: ");
            p3.SetPersonFirstName(Console.ReadLine());
            Console.Write("Middle Name: ");
            p3.SetPersonMiddleName(Console.ReadLine());
            Console.Write("Address: ");
            p3.SetPersonAddress(Console.ReadLine());
            Console.Write("Contact Number: ");
            p3.SetPersonContactNumber(Console.ReadLine());
            Console.Write("Designation: ");
            sa1.SetStaffDesignation(Console.ReadLine());
            Console.Write("Office assignment: ");
            sa1.SetStaffOfficeAssignment(Console.ReadLine());
            Console.Write("Birth Date: ");
            p3.SetPersonBirthDate(Console.ReadLine());
            Console.WriteLine();

            // Course 
            Console.WriteLine();
            Console.Write("Course \n");
            Console.Write("Course Title: ");
            c1.SetCourseTitle(Console.ReadLine());
            Console.Write("Course Description: ");
            c1.SetCourseDescription(Console.ReadLine());
            Console.Write("Course Units: ");
            c1.SetCourseUnits(double.Parse(Console.ReadLine()));
            Console.Write("Degree it is offered in: ");
            c1.SetCourseDegreeOfferedIn(Console.ReadLine());


            //output 
            Console.WriteLine();
            p3.ToString(p1, p2, p3, st1, f1, sa1, c1);

        }
    }
}
