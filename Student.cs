using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinqSqlLikeWebApp1
{
    public class Student
    {
        //declare the variables in the class.
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            //create a list of students.
            List<Student> listStudents = new List<Student>();

            //create student objects.
            Student student1 = new Student
            {
                ID = 101,
                Name = "Mike",
                Gender = "Male"
            };
            //add the student object to the list.
            listStudents.Add(student1);

            Student student2 = new Student
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listStudents.Add(student2);

            Student student3 = new Student
            {
                ID = 103,
                Name = "Neil",
                Gender = "Male"
            };
            listStudents.Add(student3);

            Student student4 = new Student
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listStudents.Add(student4);

            Student student5 = new Student
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listStudents.Add(student5);

            //here return the list of students back.
            return listStudents;
        }
    }
}