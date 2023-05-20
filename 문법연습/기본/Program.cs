// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace value { 
class Program
{
    static int Division(int a, int b)
    {
        return a / b;
    }
    static int Swap(int a, int b)
    {
        int temp = b;
        b = a;
        a = temp;
        return a;
        return b;
    }

        static void Main(string[] args)
        {
            Console.WriteLine("hello, World");
            Console.WriteLine("문자를 출력하기");
            int a;
            a = 100;
            float b;
            b = 100.13f;
            ushort c;
            c = 80;
            double d = 100.20003;
            Console.WriteLine(a);
            Console.Write(b);
            Console.WriteLine(c);
            Console.Write(d);

            char v = '문';
            string x = "자열을 저장";
            Console.WriteLine("{0}{1}", v, x);
            Console.WriteLine("{1}{0}", v, x);
            Console.WriteLine("{0}{1}", x, v);

            bool z = true;
            bool q = false;

            Console.WriteLine("{0},{1}", z, q);

            object w = "아무 문자열";
            object e = 50 * 2;
            object r = 12 * 3;
            object t = true;

            Console.WriteLine("{0}{1}{2}{3}", w, e, t, r);

            int ab = 12345678;
            double ba = 12.345678;

            Console.WriteLine("통화(C)....:{0:C}", ab);
            Console.WriteLine("10진법 (D){0:D}", ab);
            Console.WriteLine("지수 표기법 (E) {0:E}", ba);
            Console.WriteLine("고정 소수점 (F)..{0:F}", ba);
            Console.WriteLine("일반 (G)..{0:G}", ab);
            Console.WriteLine("숫자 (N)..{0:F}", ab);
            Console.WriteLine("16진법 (X)..{0:X}", ab);
            Console.WriteLine("백분율(P)..{0:P}", ba);

            a = 12;
            b = 1200.345678f;

            Console.WriteLine("0 자리 표시(0) :{0:00000}", a);
            Console.WriteLine("10진수 자리 표시(#) : {0:#.#}", a);
            Console.WriteLine("소수점 (.){0:0.00}{1:0.0}", b, a);
            Console.WriteLine("천 단위 자릿수 표시(,) {0:0,0}", a);
            Console.WriteLine("백분율 자리 표시(%) {0:0%}", b);
            Console.WriteLine("지수 표기법 (e) {0:0.000e+0}", b);

            a = 12345;
            Console.WriteLine("|{0,15}|", a);
            Console.WriteLine("|{0,-15}|", a);
            Console.WriteLine("|{0,15:N0}|", a);
            Console.WriteLine("|{0,-200:N0}|", a);
            Console.WriteLine("{0,15:N}", a);
            Console.WriteLine("{0,-15:N}", a);
            Console.WriteLine("{0,-15:000000}", a);

            int inta = 500;
            float floatb = inta;

            Console.WriteLine("{0} = {1} ", inta, floatb);

            double doublec = 123.45;
            int intd = (int)doublec;

            Console.WriteLine("c ={0} , d = {1}", doublec, intd);

            a = 500;
            b = 60.44f;
            string cd = a.ToString();
            string dc = b.ToString();

            Console.WriteLine("{0},{1},{2},{3}", a, b, cd, dc);
            Console.WriteLine(cd + dc);

            string ef = "123";
            string fe = "123.456";
            int ga = int.Parse(ef);
            float h = float.Parse(fe);

            Console.WriteLine("{0},{1},{2},{3}", ef, fe, ga, h);
            Console.WriteLine(ga + h);

            int num1 = 10;
            Console.WriteLine(num1++);
            Console.WriteLine(num1--);

            int num2 = 2;
            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 & num2);
            Console.WriteLine(num1 % num2);
        }