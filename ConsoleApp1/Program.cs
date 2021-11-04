using System;

namespace CodingChallenge
{
    class Program
    {
        public static int collatz(int n)
        {
            int s = 0;
            while(n != 1)
            {
                if(n%2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = (n * 3) + 1;
                }
                s++;
            }

            return s;
        }
        public static bool isSimple(int d, int n){
            if(n == 1 || n == (d-1)){
                return true;
            }
            if(d%n == 0){
                return false;
            }
            for(int i = 2; i < d; i++){
                if(d%i == 0 && n%i == 0){
                    return false;
                }
            }
            return true;
        }
        public static double UniqueFract(){
            double total = 0;
            for (int i = 2; i < 10; i ++){
                for(int j = 1; j < i; j++){
                    if(isSimple(i, j)){
                        total += ((double)j/(double)i);
                    }
                }
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(UniqueFract());
            Console.WriteLine();
            Console.WriteLine(collatz(2));
            Console.WriteLine(collatz(3));
            Console.WriteLine(collatz(10));
            
        }
    }
}
