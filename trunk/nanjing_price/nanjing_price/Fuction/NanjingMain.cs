using System;
using System.Collections.Generic;
using System.Text;
using nanjing_price.WebUtility;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser.Util;
using Winista.Text.HtmlParser.Tags;
using Winista.Text.HtmlParser.Filters;

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
            Parser parser = Parser.CreateParser(content.Replace(System.Environment.NewLine, ""), "gb2312");
            NodeFilter table = new TagNameFilter("table");
            INode Table = parser.Parse(table)[2].Children[3];
            parser= Parser.CreateParser(Table.ToHtml(), "gb2312");
            Table = parser.Parse(table)[3];
            parser = Parser.CreateParser(Table.ToHtml(), "gb2312");
            Table = parser.Parse(table)[2];
            content = Tools.filterTableAttribute(Table.ToHtml());
            Console.Write(content);
            Tools.writeTxtFile(content, @"b:\6.html");
    
        }

    }
}
