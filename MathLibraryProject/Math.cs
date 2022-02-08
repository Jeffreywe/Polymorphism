using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryProject {

    public static class Math {

        // polymorphism example allows manipulation of the same method name with different perimeters
        public static string Add(string a, string b) { // method overloading, for Add
            return a + b;
        }
        public static decimal Add(decimal a, decimal b) {
            return a + b;
        }
        public static long Add(long a, long b) {
            return a + b;
        }
        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Sub(int a, int b) {
            return a - b;
        }
        public static int Mult(int a, int b) {
            return a * b;
        }
        public static int Div(int a, int b) {
            return a / b;
        }

    }
}
