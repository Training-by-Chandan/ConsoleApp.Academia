using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                //ClassExplanation();
                //InheritanceExample();

                //AbstractExample();

                //GenericAndNonGenericExample();

                //DelegateExample();

                DataBaseConnection();

                Console.WriteLine("Do you want to continue more? (y/n)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }

        private static string connectionstring = "Data Source=DESKTOP-C25RLDB\\SQLEXPRESS;Initial Catalog=Academia;integrated security=true;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

        private static void ReadData()
        {
            var con = new SqlConnection(connectionstring);

            string query = "select * from Person";
            var cmd = new SqlCommand(query, con);

            con.Open();
            try
            {
                //todo operations here
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    var id = result.GetInt32(0);
                    var name = result.GetString(1);
                    var address = result.GetString(2);
                    Console.WriteLine($"Id={id}, Name={name}, Adress={address}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        private static void InsertData()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            var address = Console.ReadLine();

            var con = new SqlConnection(connectionstring);

            string query = $"insert into Person (id, Name, address) values ({id}, '{name}','{address}')";
            var cmd = new SqlCommand(query, con);

            con.Open();
            try
            {
                //todo operations here
                var res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        private static void EditData()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            var address = Console.ReadLine();

            var con = new SqlConnection(connectionstring);

            string query = $"update Person set Address='{address}', Name ='{name}' where id={id}";
            var cmd = new SqlCommand(query, con);

            con.Open();
            try
            {
                //todo operations here
                var res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        private static void DeleteData()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var con = new SqlConnection(connectionstring);

            string query = $"delete from Person where id={id}";
            var cmd = new SqlCommand(query, con);

            con.Open();
            try
            {
                //todo operations here
                var res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        private static void DelegateExample()
        {
            Delegs d = new Delegs();
            d.Implemenation();
        }

        private static void GenericAndNonGenericExample()
        {
            CustomColelctions<int> obj1 = new CustomColelctions<int>();
            CustomColelctions<string> obj2 = new CustomColelctions<string>();

            TestCollection.DictionarySample();
        }

        private static void AbstractExample()
        {
            AbsShape shape = new SquareAbs();
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }

        private static void InterfaceExample()
        {
            IShape s = new Square();
            s = new Rectangle();
        }

        private static void InheritanceExample()
        {
            LivingThings l1 = new LivingThings();
            //Animal a1 = new Animal();
            //Plant p1 = new Plant();
            //HumanBeings h1 = new HumanBeings();
            //Men m1 = new Men();
            //Women w1 = new Women();
            l1.Eat();
            Animal a1 = new Animal(10);
            a1.Eat();

            LivingThings l2 = new Animal();
            l2.Eat();
        }

        private static void ClassExplanation()
        {
            Human Ashutosh = new Human();
            Human Suman = new Human();
            Human Sagar = new Human();

            Human X = new Human(3, 1, 4);

            Console.WriteLine("Ashutosh has");

            Ashutosh.DisplayDetails();
            Console.WriteLine("Sagar has");
            Sagar.DisplayDetails();
            Console.WriteLine("Suman has");
            Suman.DisplayDetails();
            Console.WriteLine("X has");
            X.DisplayDetails();
            X.Eyes = 5;
            X.Eyes = 2;
            X.OperationofEye(2);

            X.DisplayDetails();
            //_ _ _ _ _ _ _ _
            //0 0 0 0 0 0 0 0
        }
    }

    public partial class PClass
    {
        public void FunctionOne()
        {
        }
    }
}