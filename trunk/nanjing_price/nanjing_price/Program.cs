using System;
using System.Collections.Generic;
using System.Text;
using nanjing_price.WebUtility;
using nanjing_price.Fuction;

namespace nanjing_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("南京物价采集DEMO\n输入网址：");
            NanjingMain nk = new NanjingMain(Console.ReadLine());
            Console.WriteLine("倒入数据成功！");
            Console.ReadLine();
        }
    }
}
