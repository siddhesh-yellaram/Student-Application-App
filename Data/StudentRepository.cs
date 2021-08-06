using StudentApplicationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplicationApp.Data
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> Students;
        //private readonly StudentRepository _instance = new StudentRepository();
        public StudentRepository()
        {
            Student s1 = new Student { Name = "Siddhesh", RollNo = 101, Cgpa = 8.9 };
            Student s2 = new Student { Name = "Ojas", RollNo = 102, Cgpa = 8.7 };
            Student s3 = new Student { Name = "Anmol", RollNo = 103, Cgpa = 8.8 };
            Student s4 = new Student { Name = "Ram", RollNo = 104, Cgpa = 8.8 };
            Student s5 = new Student { Name = "Rahul", RollNo = 105, Cgpa = 8.5 };
            Students = new List<Student>
            {
                s1,
                s2,
                s3,
                s4,
                s5
            };
        }
        //public StudentRepository Instance
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}
        public List<Student> Get()
        {
            return Students;
        }
        public Student GetById(string id)
        {
            foreach (Student s in Students)
            {
                if (s.ID == id)
                {
                    return s;
                }
            }
            return null;
        }

        public void Add(Student s)
        {
            Students.Add(s);
        }

        public void EditStudent(string id, Student updatedStudent)
        {
            int i = 0;
            foreach (Student s in Students)
            {
                if (s.ID == id)
                {
                    break;
                }
                i++;
            }
            updatedStudent.ID = id;
            Students[i] = updatedStudent;
        }
    }
}