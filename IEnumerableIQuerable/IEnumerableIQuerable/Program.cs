using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableIQuerable
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionproDBContext db = new AurionproDBContext();
            //Student s = new Student { FullName = "Shreya Bhoir", Cgpa = 8.9, Id = Guid.NewGuid() };
            /*Student s1 = new Student { FullName = "Sachine tendulkar", Cgpa = 8.9, Id = Guid.NewGuid() };
            Student s2 = new Student { FullName = "Blake King", Cgpa = 8.9, Id = Guid.NewGuid() };
            Student s3 = new Student { FullName = "Sandy jake", Cgpa = 8.9, Id = Guid.NewGuid() };
            Student s4 = new Student { FullName = "Prachi patil", Cgpa = 8.9, Id = Guid.NewGuid() };
            db.Students.Add(s1);
            db.Students.Add(s2);
            db.Students.Add(s3);
            db.Students.Add(s4);
            db.SaveChanges();*/

            QueryableCase1(db);
            //QueryableCase2(db);
            EnumerableCase(db);
            Console.ReadLine();
        }

        private static void EnumerableCase(AurionproDBContext db)
        {
            var FirstNameStartingWithS = db.Students
                                         //.ToList()
                                         .Where(s => s.FullName.StartsWith("S"))
                                         .ToList()
                                         .Select(s => new
                                         {
                                            FirstName = s.FullName.Split(' ')[0],
                                            Cgpa = s.Cgpa
                                          });

            Console.WriteLine("Sql Build Expression");
            Console.WriteLine(FirstNameStartingWithS);

            var FirstNameStartingWithSList = FirstNameStartingWithS.ToList();

            foreach (var s in FirstNameStartingWithSList)
            {
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.Cgpa);
            }
        }

        private static void QueryableCase2(AurionproDBContext db)
        {
            var FirstNameStartingWithS = db.Students
                                    .Where(s => s.FullName.StartsWith("S"))
                                    //.ToList()
                                    .Select(s => new
                                    {                                     
                                        FirstName = s.FullName.Split(' ')[0],
                                        Cgpa = s.Cgpa
                                    });

            Console.WriteLine("Sql Build Expression");
            Console.WriteLine(FirstNameStartingWithS);

            var FirstNameStartingWithSList = FirstNameStartingWithS.ToList();

            foreach (var s in FirstNameStartingWithSList)
            {
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.Cgpa);
            }
        }

        private static void QueryableCase1(AurionproDBContext db)
        {
            var NameStartingWithS = db.Students
                                    .Where(s => s.FullName.StartsWith("S"))
                                    .Select(s => new
                                    {
                                        s.FullName,
                                        s.Cgpa
                                    });

            Console.WriteLine("Sql Build Expression");
            Console.WriteLine(NameStartingWithS);

            var NameStartingWithSList = NameStartingWithS.ToList();

            foreach(var s in NameStartingWithSList)
            {
                Console.WriteLine(s.FullName);
                Console.WriteLine(s.Cgpa);
            }
        }
    }
}
