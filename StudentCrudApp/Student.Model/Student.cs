using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class Student
    {
        private Guid _id;
        private string _name;
        private int _rollno;
        private double _cgpa;

        public Student(string name, int rollno, double cgpa)
        {
            _id = Guid.NewGuid();
            _name = name;
            _rollno = rollno;
            _cgpa = cgpa;
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RollNo
        {
            get { return _rollno; }
            set { _rollno = value; }
        }

        public double Cgpa
        {
            get { return _cgpa; }
            set { _cgpa = value; }
        }
    }

}
