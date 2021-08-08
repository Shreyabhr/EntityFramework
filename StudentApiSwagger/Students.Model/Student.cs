using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    public class Student
    {
        public int _id;
        public string _name;
        public int _rollNo;
        public int _marks;

        public Student(int id, string name, int rollNo, int marks)
        {
            _id = id;
            _name = name;
            _rollNo = rollNo;
            _marks = marks;
        }

        public int Id
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
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        public int Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }
    }
}
