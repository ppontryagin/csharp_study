using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromPythonWeek1 {
    /*
     * N школьников делят K яблок поровну, не делящийся остаток остается в корзинке. 
     * Сколько яблок достанется каждому школьнику?
     */
    class Program {
        static void Main(string[] args) {
            // delApple returns divisor of n/k 
            int delApple(int n, int k) {
                return 0;
            }

            if (delApple(3, 14) != 4) {
                Console.WriteLine("expected: {0}, received: {1}", 4, delApple(3, 14));
                System.Environment.Exit(0);
            }

            // read user input
            // n - number of people
            int pupils = Int32.Parse(Console.ReadLine());
            // n + number of apples
            int apples = Int32.Parse(Console.ReadLine());

            int result = delApple(pupils, apples);
            Console.WriteLine($"Каждому школьнику достанется {result} яблок");
        }
    }
}
