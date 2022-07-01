using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week15_2
{
    class Program
    {
        class Student
        {
            private string ID, Name;
            private int Chi, Eng, Math;
        }
        public static void Information(string ID, string Name, int Chi, int Eng, int Math)
        {
       3f 
            if (Chi > 100)
                Chi = 100;
            else if (Chi < 0)
                Chi = 0;
            if (Math > 100)
                Math = 100;
            else if (Math < 0)
                Math = 0;
            if (Eng > 100)
                Eng = 100;
            else if (Eng < 0)
                Eng = 0;
            Console.WriteLine("學號:" + ID + ",姓名:" + Name +
              "國文:" + Chi + ",數學:" + Math + ",英文:" + Eng);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR_week15_2");

            Student 段昱如_2_1;
            段昱如_2_1 = new Student();
            string ID1 = "B0226497_1";
            string Name1 = "段昱如_2_1";
            int Chi1 = 201;
            int Eng1 = -65;
            int Math1 = 56;
            Student 段昱如_2_2;
            段昱如_2_2 = new Student();
            string ID2 = "B0226497_2";
            string Name2 = "段昱如_2_2";
            int Chi2 = 101;
            int Eng2 = 154;
            int Math2 = -8;
            Student 段昱如_2_3;
            段昱如_2_3 = new Student();
            string ID3 = "B0226497_3";
            string Name3 = "段昱如_2_3";
            int Chi3 =66;
            int Eng3 = 120;
            int Math3 =-6;
            Console.WriteLine("同學1:");
            Information(ID1, Name1, Chi1, Eng1, Math1);
            Console.WriteLine("同學2:");
            Information(ID2, Name2, Chi2, Eng2, Math2);
            Console.WriteLine("同學3:");
            Information(ID3, Name3, Chi3, Eng3, Math3);
            Console.ReadLine();

        }
    }
}   