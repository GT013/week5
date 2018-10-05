using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c;
            c = add(a, b); // ให้ c เก็บค่า a+b จากเมธอด add
            Console.WriteLine("c = {0}", c); // แสดงค่า c คือ ค่าของ a+b 
            Console.WriteLine("3 + 5 = {0}", add(3, 5)); // เรียกใช้เมธอด add(a+b) 
            Console.WriteLine("4 + 7 =  " + add(4, 7)); // เรียกใช้เมธอด add(a+b) เครื่องหมายบวกคือให้แสดงผลลัพธ์ต่อจาก =
            Console.ReadLine();
        }

        static int add(int a, int b) // เมธอดที่สร้างขึ้นมีชนิดเป็นจำนวนเต็ม
        {
            return a + b; // ค่าส่งกลับ
        }

    }
}

