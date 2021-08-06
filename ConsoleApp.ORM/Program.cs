using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ConsoleApp.ORM
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //DataBaseConnection();
                SubjectDataInformation();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        private static void SubjectDataInformation()
        {
            Console.WriteLine("Enter the Subject Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var subject = db.Subjects.Include(p => p.Class).Include(p => p.Teacher).FirstOrDefault(p => p.Id == id);

            Console.WriteLine($"Subject Name {subject.Name}, Teacher {subject.Teacher.Name}, Class={subject.Class.ClassName}");
        }

        private static void DataBaseConnection()
        {
            Console.WriteLine("Press 1 to read from PersonTable");
            Console.WriteLine("Press 2 to insert in PersonTable");
            Console.WriteLine("Press 3 to edit in PersonTable");
            Console.WriteLine("Press 4 to delete from PersonTable");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReadData();
                    break;

                case "2":
                    InsertData();
                    break;

                case "3":
                    EditData();
                    break;

                case "4":
                    DeleteData();
                    break;

                default:
                    break;
            }
        }

        private static DefaultContext db = new DefaultContext();

        private static void DeleteData()
        {
            Console.WriteLine("Enter the Id");
            var Id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(Id);
            if (existing != null)
            {
                db.Students.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Student With Id {Id} not found");
            }
        }

        private static void EditData()
        {
            Console.WriteLine("Enter the Id");
            var Id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(Id);
            if (existing != null)
            {
                Console.WriteLine("Enter the Name");
                existing.Name = Console.ReadLine();

                Console.WriteLine("Enter the Address");
                existing.Address = Console.ReadLine();
                Console.WriteLine("Enter the Gender");
                existing.Gender = (Gender)Convert.ToInt32(Console.ReadLine());

                db.Entry(existing).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Student With Id {Id} not found");
            }
        }

        private static void InsertData()
        {
            var student = new Student();

            Console.WriteLine("Enter the Name");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            student.Address = Console.ReadLine();
            Console.WriteLine("Enter the Gender");
            student.Gender = (Gender)Convert.ToInt32(Console.ReadLine());

            db.Students.Add(student);
            db.SaveChanges();
        }

        private static void ReadData()
        {
            var data = db.Students.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id={item.Id}, Name={item.Name}, Address={item.Address}, Gender{item.Gender}");
            }
        }
    }
}