using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace nanjing_price.Fuction
{
    class Tools
    {
        public static string filterScript(string str1)//去除代码中的javascript
        {
            // string str1 = "new TextParser('/posts/05/B1/B3/9E/content_html.txt', 'content_tree');";
            if (str1.Contains("<script"))
            {
                for (; str1.Contains("<script"); )
                {
                    int i_1 = str1.IndexOf("<script");
                    int i_2 = str1.IndexOf("</script>");
                    str1 = str1.Remove(i_1, i_2 - i_1 + 9);
                }
            }
            return str1;
        }
        public static string filterTableAttribute(string s0)
        { 
        return Regex.Replace(s0, @"<(\w+)(?:\s+(?:""[^""]*""|'[^']*'|[^""'>])*)?>", "<$1>");
        }
        public static string readTxtFile(string url)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                //StreamReader sr = new StreamReader(@"D:\a.txt");
                using (StreamReader sr = new StreamReader(@url))
                {
                    String line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        sb.Append(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("读" + url + "取成功");
            return sb.ToString();
        }
        public static void writeTxtFile(string str, string url)
        {
           File.AppendAllText(url, str, Encoding.UTF8);
        }
    }
}
