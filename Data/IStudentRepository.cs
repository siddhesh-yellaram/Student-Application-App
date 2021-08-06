using StudentApplicationApp.Model;
using System.Collections.Generic;

namespace StudentApplicationApp.Data
{
    public interface IStudentRepository
    {
        void Add(Student s);
        void EditStudent(string id, Student updatedStudent);
        List<Student> Get();
        Student GetById(string id);
    }
}