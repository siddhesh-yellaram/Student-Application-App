using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApplicationApp.Model
{
    public class Student
    {
        private string _id;
        public Student()
        {
            Guid guid = Guid.NewGuid();
            _id = guid.ToString();
        }
        public String ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
    }
}