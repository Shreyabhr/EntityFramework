using System;
using System.Collections.Generic;
using System.Diagnostics;
using Students.Model;

namespace StudentInMemoryRepository
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students = new List<Student>();
        public StudentRepository()
        {
            Debug.WriteLine("in student repo");
            _students.Add(new Student("shreya", 1, 9.9));
            _students.Add(new Student("prachi", 2, 9.5));
            _students.Add(new Student("jake", 3, 8.5));
            _students.Add(new Student("blake", 4, 7.5));
            _students.Add(new Student("king", 5, 6.5));
        }


        public List<Student> GetStudents()
        {
            return _students;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public Student GetStudent(Guid id)
        {
            return GetParticularStudent(id);
        }

        public void UpdateStudent(Guid id, string name, int rollno, double cgpa)
        {
            Student s = GetParticularStudent(id);
            s.Name = name;
            s.RollNo = rollno;
            s.Cgpa = cgpa;
        }

        public Student GetParticularStudent(Guid id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
