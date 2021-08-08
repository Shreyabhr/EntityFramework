using Students.Model;
using Students.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Services
{
    public class StudentServices
    {
        private StudentRepository _repo;

        public StudentServices()
        {
            _repo = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return _repo.GetStudents();
        }

        public int DeleteStudents(int id)
        {
           _repo.DeleteStudents(id);
            return id;
        }

        public Student UpdateStudents(Student s)
        {
            return _repo.UpdateStudent(s);
        }
    }
}
