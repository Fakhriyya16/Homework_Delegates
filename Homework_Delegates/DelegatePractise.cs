using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegates
{
    internal class DelegatePractise
    {
        //public delegate bool CheckNums(int a);
        //public bool CheckOddNums(int num)
        //{
        //    return num % 2 != 0;
        //}
        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}

        public void Execute()
        {
            //List<int> list = new List<int> { 1,2,3,3,4,5,6,12};

            //SumOfNumsByCondition(list, m=>m%2!=0);
            //SumOfNumsByCondition(list, m=>m%2==0);

            //ShowText("Salam", StrToLower);
            //ShowText("Salam", StrToUpper);

            //Action<string> action1 = StrToLower;
            //Action<string> action2 = StrToUpper;

            //action1.Invoke("Sagol");
            //action2.Invoke("Sagol");

            //GetLengthOfStr("salam",5,GetLength);

            //Func<string, int, int> func = GetLength;

            //Console.WriteLine(func.Invoke("hi", 10));

            //SumOfNumsByCondition(6, 7, 8, CheckNums);


        }

        //public void SumOfNumsByCondition(List<int> list, Predicate<int> func)
        //{
        //    int sum = 0;
        //    foreach (int i in list)
        //    {
        //        if (func(i))
        //        {
        //            sum += i;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}
        public delegate void ChangeStr(string str);
        public void StrToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public void StrToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }


        public void ShowText(string text, Action<string> action)
        {
            action(text);
        }

        public void GetLengthOfStr(string str,int num,Func<string,int,int> expression)
        {
            Console.WriteLine(expression(str,num));
        }

        public int GetLength(string str, int num)
        {
            return str.Length+num;
        }

        public delegate int CalculateLength(string str,int num);

        public void SumOfNumsByCondition(int num1,int num2,int num3,Func<int,int,int,bool> expression)
        {
            if (expression(num1,num2,num3))
            {
                Console.WriteLine(num1+num2+num3);
            }
        }

        public bool CheckNums(int num1,int num2,int num3)
        {
            return num1>5 && num2>5 && num3>5;
        }


    }
}
