using System;
using System.Collections.Generic; // generic collection
using System.Collections; // non generic collection
using System.Text;
using System.Linq;

namespace ConsoleApp
{
    public class CustomColelctions<T>
    {
        public T[] A = new T[5]; // int
    }

    public class TestCollection
    {
        private List<Student> list = new List<Student>();
        private Stack st = new Stack();

        private void FunctionOne()
        {
            list.Add(new Student());
            //list.Add(1);

            st.Push(1);
            st.Push("");
            st.Push(new Student());
            st.Push(list);
        }

        public static void DictionarySample()
        {
            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine("Enter the Key");
                    var key = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Value");
                    var val = Console.ReadLine();
                    dict2.Add(key, val);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void ListLinqSamples()
        {
            List<string> list = new List<string>() { "Sagar Timalsina", "Sagar Basnet", "Susan Maharjan", "Arohan Nakarmi", "Ashish Khadka", "Rohit Maharjan", "Chandan Gupta", "Ram Kumar", "Shyam Kumar", "Ram Shrestha", "John Shrestha", "Academia College", "Sagar Timalsina", "Sagar Basnet", "Susan Maharjan", "Arohan Nakarmi", "Ashish Khadka", "Rohit Maharjan", "Chandan Gupta", "Ram Kumar", "Shyam Kumar", "Ram Shrestha", "John Shrestha", "Academia College", "Sagar Timalsina", "Sagar Basnet", "Susan Maharjan", "Arohan Nakarmi", "Ashish Khadka", "Rohit Maharjan", "Chandan Gupta", "Ram Kumar", "Shyam Kumar", "Ram Shrestha", "John Shrestha", "Academia College" };

            //linq query
            var newlist = (from l in list where l.StartsWith("Sagar") select l);

            //lambda expression
            var newlistlambda = list.Where(p => p.StartsWith("Sagar"));
        }

        public static void FileIOOPerationSample()
        {
            var dir = "D:\\Academics\\Academia\\academia\\abc";
            //System.IO.Directory //dirrectories / folders
            //System.IO.File //files
            //System.IO.Path //path

            var direxists = System.IO.Directory.Exists(dir);
            var file = System.IO.File.Create(dir + "\\abc.txt");
            var text = "This is revision of NCC";
            var txtBytes = System.Text.Encoding.ASCII.GetBytes(text);

            file.Write(txtBytes, 0, txtBytes.Length);
            file.Flush();
            file.Close();
        }
    }

    public class Student
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}