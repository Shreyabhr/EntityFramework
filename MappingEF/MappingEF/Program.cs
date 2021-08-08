using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingEF
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionproDBContext db = new AurionproDBContext();

            /*Department d1 = new Department { DeptNo = 10, DeptName = "sales", Location = "Mumbai" };
            Department d2 = new Department { DeptNo = 20, DeptName = "IT", Location = "Andheri" };

            Employee e1 = new Employee { ENo = 101, EName = "shreya", department = d1 };
            Employee e2 = new Employee { ENo = 102, EName = "Jake", department = d1 };
            Employee e3 = new Employee { ENo = 103, EName = "Sandy", department = d2 };
            Employee e4 = new Employee { ENo = 104, EName = "Prachi", department = d2 };

            d1.Employees = new List<Employee>();
            d1.Employees.Add(e1);
            d1.Employees.Add(e2);

            d2.Employees = new List<Employee>();
            d2.Employees.Add(e3);
            d2.Employees.Add(e4);

            db.Employees.Add(e1);
            db.Employees.Add(e2);
            db.Employees.Add(e3);
            db.Employees.Add(e4);

            db.SaveChanges();*/

            Console.WriteLine("Employee details");
            PrintEmployeeDetails(db);
            Console.WriteLine("Display employees in particular department");
            PrintEmployeeInDepartment(db);
            Console.WriteLine("Employees with department names");
            EmployeesWithDepartmentName(db);
            Console.ReadLine();
            //List<Employee> emps;
            
            
        }

        private static void EmployeesWithDepartmentName(AurionproDBContext db)
        {
            var employeesWithDepartments = from e in db.Employees
                                           join d in db.Departments
                                           on e.department.DeptNo equals d.DeptNo
                                           select new { employeeNo = e.ENo, employeeName = e.EName, employeeDepartment = d.DeptName };

            foreach(var employee in employeesWithDepartments)
            {
                Console.WriteLine("Eno: {0}\tName: {1}\tDepartmentName: {2}", employee.employeeNo, employee.employeeName, employee.employeeDepartment);
            }
        }

        private static void PrintEmployeeInDepartment(AurionproDBContext db)
        {
            var departmentWithEmployee = from d in db.Departments
                                         join e in db.Employees
                                         on d.DeptNo equals e.department.DeptNo
                                         select new { department = d.DeptName, employee = e.EName };

            foreach(var item in departmentWithEmployee)
            {
                Console.WriteLine("Department: {0}\tEmployee: {1}",item.department, item.employee);              
            }
        }

        private static void PrintEmployeeDetails(AurionproDBContext db)
        {
            var employeesDetails = db.Employees.Select(e => e);
            foreach(var employee in employeesDetails)
            {
                Console.WriteLine("Eno: {0}\tName: {1}", employee.ENo, employee.EName);
            }
        }
    }
}
