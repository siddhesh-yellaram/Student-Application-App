using StudentApplicationApp.Data;
using StudentApplicationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplicationApp.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _repo;
        public StudentService(IStudentRepository repository)
        {
            _repo = repository;
        }
        public List<Student> Get()
        {
            return _repo.Get();
        }
        public void AddStudent(Student s)
        {
            if (IsAllFieldsValid(s))
            {
                _repo.Add(s);
            }
            else
            {
                throw new Exception("Invalid Fields");
            }
        }
        private bool IsAllFieldsValid(Student s)
        {
            return s.Name != null || s.Name != "";
        }
        public int Count()
        {
            return _repo.Get().Count();
        }
        public void EditStudent(string id, Student s)
        {
            _repo.EditStudent(id, s);
        }

        public Student GetStudentById(string id)
        {
            return _repo.GetById(id);
        }
    }
}