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
            
            NanjingMain nk = new NanjingMain("http://www.njprice.com/col71/col464/articleinfo.php?infoid=44181");
            Console.ReadLine();
        }
    }
}
