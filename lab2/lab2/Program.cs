using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer :");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter char :");
            char char1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter long :");
            long long1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter double :");
            double double1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter dynamic :");
            dynamic dynamic1 = Console.ReadLine();
            Console.Write("\nIn packaged state\n");
            //Console.Write(string.Format("\n{0} {1} {2} {3} {4}\n", integer, char1, long1, double1, dynamic1));
            object obj1 = integer;
            object obj2 = char1;
            object obj3 = long1;
            object obj4 = double1;
            object obj5 = dynamic1;
            Console.Write(string.Format("\n{0} {1} {2} {3} {4}\n", obj1, obj2, obj3, obj4, obj5));
            int int1 = (int)obj1;
            char ch2 = (char)obj2;
            long lo1 = (long)obj3;
            double do1 = (double)obj4;
            dynamic dy1 = obj5;
            Console.Write("\nIn unpackaged state\n");
            Console.Write(string.Format("\n{0} {1} {2} {3} {4}\n", int1, ch2, lo1, do1, dy1));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("\n\n My group is 4\n");
            int group = 4;
            Console.WriteLine(string.Format("\n 4 obviously like long :{0}\n", (long)group));
            long grouplong = group;
            Console.WriteLine(string.Format(" 4 not obviously like long :{0}\n", grouplong));
            Console.WriteLine(string.Format("\n 4 obviously like double :{0:n1}\n", (double)group));
            double groupdouble = group;
            Console.WriteLine(string.Format(" 4 not obviously like double :{0:n1}\n", groupdouble));
            Console.WriteLine(string.Format("\n 4 obviously like object :{0}\n", (byte)group));
            object groupobject = group;
            Console.WriteLine(string.Format(" 4 not obviously like object :{0}\n\n", groupobject));
            string myName = "Danil";
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(string.Format("\n My name is {0}\n", myName));
            Console.WriteLine(string.Format($" My name is {myName}\n\n"));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"\n Object={double1.ToString()} Cash {double1.GetHashCode()} Type {double1.GetTypeCode()} ");
            Console.WriteLine($" Object={char1.ToString()} Cash {char1.GetHashCode()} Type {char1.GetTypeCode()} ");
            Console.WriteLine($" Char equal Double  ? {char1.Equals(double1)} ");
            char ee = 't';
            Console.WriteLine($"and dif char equal char  ? {char1.Equals(ee)} ");
            ee = char1;
            Console.WriteLine($"and same char equal char  ? {char1.Equals(ee)} ");
            ee = '2';
            Console.WriteLine($"Char compare to chare {char1.CompareTo(ee)} ");
            Console.WriteLine($"Chare compare to char {ee.CompareTo(char1)} ");
            Console.WriteLine("---------------------------------------");
            string myStr = "Converts the value of objects to string";
            string fStr = "FFFFFFFFFFFFF";
            Console.WriteLine($"My str compare randomstr {string.Compare("sddsf", myStr)}");
            Console.WriteLine($"My str contains randomstr {myStr.Contains("value")}");
            Console.WriteLine($"My str substring  {myStr.Substring(3, 10)}");
            Console.WriteLine($"My str insert  {myStr.Insert(5, fStr)}");
            Console.WriteLine($"My str replace  {myStr.Replace('o', 'Q')}");
            Console.WriteLine("---------------------------------------");
            string nullstr = null;
            string emptstr = "";
            Console.WriteLine($"Null or Empty  {string.IsNullOrEmpty(nullstr)}{string.IsNullOrEmpty(emptstr)}");
            Console.WriteLine("---------------------------------------");
            var variable = 10005;
            //variable = "string";
            dynamic var2 = 10005;
            var2 = "string";

            short? nullable = null;
            Console.WriteLine($"Nullable ?  {nullable == null}");
            var unnamed = (one: 234, jj: 45234, izi: "izi");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(unnamed.Item1 + ' ' + unnamed.Item2);
            Console.WriteLine(unnamed.one + ' ' + unnamed.izi);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Checked");
            int maxint = int.MaxValue;
            Console.WriteLine(unchecked(maxint + integer));

            using (Example exmpl = new Example(12))
            {
                Console.WriteLine("\nUsing :"+exmpl.GetState());
                exmpl.Dispose();
                GC.Collect();
            }
            

            int x = Console.Read();
        }
    }
}
