using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Practise_14032024
{
    internal class Delegatepractise
    {
        private Func<int, int, int, bool> CheckNums;
        //public delegate bool CheckNums(int,a);
        public delegate int CalculateLengt(string str, int num);
        //public delegate void ChangeStr(string str);
        //public bool CheckOddNums(int num)
        //{
        // return num%2 ==0;
        //}

        //public bool CheckevenNums(int num)
        //{
        // return num%2==0
        //}

        public void StrToUpper(string str, int num)
        {
            Console.WriteLine(str.ToUpper());
        }

        public void StrToLower(string str, int num)
        {
            Console.WriteLine(str.ToLower());
        }

        public int GetLength(string str, int num)
        {
            return str.Length + num;
        }

        public bool Check(int num1, int num2, int num3)
        {
            return num1 > 5 && num2 > 5 && num3 > 5;
        }

        public void excute()
        {

            // List<int>list = new list<int>{1,4,5,7,8,9}
            // list.Where(m=>m>100);
            //SumOfNumsByCondition(listm=>m%2!=0);
            //SumOfNumsByCondition(listm=>m%2==0);
            //ShowText("sagol",StrToUpper);
            //ShowText("sagol",StrToLower);

            //Action<string> del1 = StrToUpper;
            //Action<string> del1 = StrToLower;

            //del1("sagol")
            //del2("sagol")
            //GetLengthOfStr("salam", GetLength);
            //Func<string, int, int> func = GetLength;
            // var t = func("hello",100);
            // Console.WriteLine(t);

            // SumOfNummsByCondition(1, 11, 12, CheckNums);
            // Predicate<int> test = CheckEvenNums;
            // Console.WriteLine(test(10));

        }
        public void SumOfByCondition(int num1, int num2, int num3 Func<int, int, int, bool>CheckNums)
        {
            if (Expresstion(num1, num2, num3))
            {
                Console.WriteLine(num3+num2+num1);
            }
        }

        //public int GetLengthOStr(string str Func<string,int,int>)func)
        //{
        //    int Count = Func(string, 10);
        //  Console.Writeline(Count)

         
        //}

        //public void ShowText(string text, Action<string> func)
        //{
        //    func(texr)
        //}

        //public void SumOfByCondition(List<int> nums, Predicate<>func)
        //{
        //    int sum = 0;

        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

    }
     
}
