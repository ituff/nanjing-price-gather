using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser.Visitors;  

namespace nanjing_price.WebUtility
{
    class webUtility
    {
        public string getContent(string url) {
            string content;
            try
            {
                WebClient myWebClient = new WebClient();
                byte[] myDataBuffer = myWebClient.DownloadData(url);
                content = Encoding.Default.GetString(myDataBuffer);
              
            }
            catch {
                content = "err";
            }
            return content;
        }
    }
}
