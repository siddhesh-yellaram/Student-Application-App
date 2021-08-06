using StudentApplicationApp.Model;
using System.Collections.Generic;

namespace StudentApplicationApp.Services
{
    public interface IStudentService
    {
        void AddStudent(Student s);
        int Count();
        void EditStudent(string id, Student s);
        List<Student> Get();
        Student GetStudentById(string id);
    }
}