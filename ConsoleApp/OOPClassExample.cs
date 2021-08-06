using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class OOPClassExample
    {
        public OOPClassExample()
        {
        }

        public OOPClassExample(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }

        private string fname; //variables of types string
        private string lname; //variables of type string

        public string FName //properties
        {
            get // to get the value
            {
                if (string.IsNullOrWhiteSpace(fname))
                {
                    return "Default";
                }
                return fname;
            }
            set // sets the value
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    fname = "Default";
                }
                else
                {
                    fname = value;
                }
            }
        }

        public string LName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public string FullName
        {
            get
            {
                return fname + " " + lname;
            }
        }

        private string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        public string this[int i]
        {
            get
            {
                if (i >= 7 || i <= -1)
                {
                    return "Invalid";
                }
                else
                {
                    return days[i];
                }
            }
        }
    }

    public class OOpImpl
    {
        public static void Example()
        {
            OOPClassExample obj1 = new OOPClassExample();
            var val = obj1.FName;
            obj1.FName = "Arohan";
            OOPClassExample obj2 = new OOPClassExample("Arohan", "Nakarmi");

            var day = obj1[0];
        }
    }
}