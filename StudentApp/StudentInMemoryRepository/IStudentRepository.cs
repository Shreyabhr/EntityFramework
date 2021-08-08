using Students.Model;
using System;
using System.Collections.Generic;

namespace StudentInMemoryRepository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        Student GetStudent(Guid id);
        List<Student> GetStudents();
        void UpdateStudent(Guid id, string name, int rollno, double cgpa);

        //public static IStudentRepository GetInstance();
    }
}