using Students.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Students.Repository
{
    public class StudentRepository
    {
        private List<Student> _students = new List<Student> { new Student(1, "shreya", 6, 75), new Student(2, "prachi", 7,85) };

        public List<Student> GetStudents()
        {
            return _students;
        }

        public void DeleteStudents(int id)
        {
            foreach(var student in _students)
            {
                if(student.Id == id)
                {
                    _students.Remove(student);
                }
            }
        }

        public Student UpdateStudent(Student s)
        {
            foreach (var student in _students)
            {
                if (student.Id == s.Id)
                {
                    student.Name = s.Name;
                    student.RollNo = s.RollNo;
                    student.Marks = s.Marks;
                    return student;
                }
            }
            return null;
        }
    }
}
