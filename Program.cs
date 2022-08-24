using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;

namespace sanctionScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            getHtml();
         

            Console.ReadLine();    
            
        }

        private static void getHtml()
        {
            string url = "https://www.sahibinden.com/";

            //belirlediğimiz url'den  ait html dokümanının çekilmesi
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc =  web.Load(url);

            IList<HtmlNode> nodes =  doc.QuerySelector("div.uiBox showcase").QuerySelectorAll("ul.vitrin-list clearfix li a");

            var data = nodes.Select((node) => {
                return new {
                    title = node.GetAttributeValue("title" ,""),
                    link = node.GetAttributeValue("href", "")
                };
            });

            
            


        }




    }
    }

