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
            long c = Factorial(5); // long เหมือนกับ int แต่จะมีขนาดมากกว่า ใส่ค่าอาร์กิวเมนต์ 5
            Console.WriteLine("Factorial of 5 = {0}", c); // แสดงข้อความและผลลัพธืที่ได้จากการคำนวณ
            Console.ReadLine();
        }
        static long Factorial(int n) // สร้างเมธอด 
        {
            if (n == 0)  // Factorial 0 = 1
                return 1;
            return n * Factorial(n - 1); // 
        }
    }
}
