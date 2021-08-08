using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using StudentInMemoryRepository;
using Students.Model;

namespace Students.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            Debug.WriteLine("In serive");
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetStudents();
        }

        public void AddStudent(Student s)
        {
            if (s.Name != null && s.Id != null)
            {
                _repo.AddStudent(s);
            }
        }

        public int Count()
        {
            return _repo.GetStudents().Count();
        }

        public Student GetStudent(Guid id)
        {
            return _repo.GetStudent(id);
        }

        public void UpdateStudent(Guid id, string name, int rollno, double cgpa)
        {
            _repo.UpdateStudent(id, name, rollno, cgpa);
        }


    }
}
