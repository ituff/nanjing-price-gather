using System;
using System.Collections.Generic;
using System.Text;
using nanjing_price.WebUtility;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser.Util;
using Winista.Text.HtmlParser.Tags;
using Winista.Text.HtmlParser.Filters;
using org.nutlab;

namespace nanjing_price.Fuction
{
    class NanjingMain
    {
        string content;
        string urlStr;

        public NanjingMain(string url){
        this.urlStr=url;
        getContent();
        inputDB();
        }

        void getContent() {
       webUtility web = new webUtility();
       content = Tools.filterScript(web.getContent(urlStr));
          // content = Tools.readTxtFile(@"b:\1.html");
        }

        void inputDB() {
            DateTime publishTime = new DateTime();
            good_price price = new good_price();
            Parser parser = Parser.CreateParser(content.Replace(System.Environment.NewLine, ""), "gb2312");
            NodeFilter table = new TagNameFilter("table");
            INode Table = parser.Parse(table)[2].Children[3];
            parser= Parser.CreateParser(Table.ToHtml(), "gb2312");
            Table = parser.Parse(table)[3];
            parser = Parser.CreateParser(Table.ToHtml(), "gb2312");
            Table = parser.Parse(table)[2];
            content = Tools.filterTableAttribute(Table.ToHtml());
            Console.WriteLine(content);
            //Tools.writeTxtFile(content, @"b:\6.html");
            parser = Parser.CreateParser(content, "gb2312");
            INode  tempTag = parser.Parse(table)[0];
            TableTag tableTag = (TableTag)tempTag;//上面判断如果得到的第一个为table 
            Tools.writeTxtFile(tempTag.ToHtml(), @"b:\6.html");
            Winista.Text.HtmlParser.Tags.TableRow[] tr = tableTag.Rows;//得到该table所有的tr
            TableColumn[] tc = tr[2].Columns;
            publishTime = Convert.ToDateTime(tc[0].ToPlainTextString().Trim().Substring(3));
            Console.WriteLine(publishTime);
            for (int i = 6; i < tr.Length; i++) {
                tc = tr[i].Columns;
                for (int j = 3; j < tc.Length; j++) {
                    price.name = tc[0].ToPlainTextString().Trim();
                    price.standard = tc[1].ToPlainTextString().Trim();
                    price.unit = tc[2].ToPlainTextString().Trim();
                    price.district_name = tr[4].Columns[j].ToPlainTextString().Trim();
                    price.market_name = tr[5].Columns[j].ToPlainTextString().Trim();
                    price.amount = tc[j].ToPlainTextString().Trim();
                    price.publish_time = publishTime;
                    price.get_time = System.DateTime.Now;
                    price.get_url = urlStr;
                    price.Add();
                }
            }
        }

    }
}
