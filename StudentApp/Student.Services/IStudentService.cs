using Students.Model;
using System;
using System.Collections.Generic;

namespace Students.Services
{
    public interface IStudentService
    {
        void AddStudent(Student s);
        int Count();
        Student GetStudent(Guid id);
        List<Student> GetStudents();
        void UpdateStudent(Guid id, string name, int rollno, double cgpa);
    }
}