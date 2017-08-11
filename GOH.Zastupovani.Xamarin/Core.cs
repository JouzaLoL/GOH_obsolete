using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Text;
using HtmlAgilityPack;

namespace GOH.Zastupovani.Xamarin
{
    public static class Core
    {
        public static WebClient WebClient = new WebClient() {Encoding = Encoding.GetEncoding(1250)};
        public static HtmlDocument HtmlDocument = new HtmlDocument();
        public static Stream Stream;
        public static string HtmlCode;

        public static List<Supl> Suplovani = new List<Supl>();

        public const string BaseUrl = @"http://suplovani.gytool.cz/";

        public static void Initialize()
        {
            HtmlNode.ElementsFlags.Remove("option");
        }

        public static List<string> GetDates()
        {
            Stream = WebClient.OpenRead("http://suplovani.gytool.cz/index_menu.html");
            HtmlDocument.Load(Stream, Encoding.GetEncoding(1250));

            var options = HtmlDocument.DocumentNode.SelectNodes("//select/option");
            return options.Select(o => o.InnerText).ToList();
        }

        public static List<string> GetDatesValues()
        {
            Stream = WebClient.OpenRead("http://suplovani.gytool.cz/index_menu.html");
            HtmlDocument.Load(Stream, Encoding.GetEncoding(1250));

            var options = HtmlDocument.DocumentNode.SelectNodes("//select/option/@value");

            return options.Select(y => y.Attributes[0].Value).ToList();
        }

        /// <summary>
        /// Retrieves classes from the system
        /// </summary>
        /// <returns>String list of classes</returns>
        public static List<string> GetClasses()
        {
            Stream = WebClient.OpenRead("http://rozvrh.gytool.cz/index_tr_menu.html");
            HtmlDocument.Load(Stream, Encoding.GetEncoding(1250));

            var options = HtmlDocument.DocumentNode.SelectNodes("//select/option");
            return options.Select(o => o.InnerText.Replace("&nbsp;&nbsp;", "")).ToList(); //Clean the string
        }

        public static List<Supl> GetSuplovani(string trida, string datum)
        {
            Stream = WebClient.OpenRead(ResolveUrl(datum));
            HtmlDocument.Load(Stream, Encoding.GetEncoding(1250));

            var rows =
                HtmlDocument.DocumentNode.SelectNodes(
                    @"//html/body/table[1]/tr[3]/td/table[1]/tr/td/table[2]/tr[2]/td/table/tr/td[normalize-space(text())=" +
                    "\"" + trida + "\"" + "]/..");
            return rows?.Select(ParseRow).ToList();
        }

        private static Supl ParseRow(HtmlNode node)
        {
            var s = new Supl
            {
                Hodina = node.SelectSingleNode("td[contains(@class, 'C11')]").InnerText,
                Chybejici = node.SelectSingleNode("td[contains(@class, 'C12')]").InnerText,
                Predmet = node.SelectSingleNode("td[contains(@class, 'C14')]").InnerText,
                Zastupujici = node.SelectSingleNode("td[contains(@class, 'C16')]").InnerText,
                Ucebna = node.SelectSingleNode("td[contains(@class, 'C15')]").InnerText,
                Poznamka = node.SelectSingleNode("td[contains(@class, 'C18')]").InnerText.Replace("&nbsp;", "")
            };
            return s;
        }

        private static string ResolveUrl(string currentDate)
        {
            var url = BaseUrl + currentDate;
            return url;
        }

        public static Supl GetHeader()
        {
            return new Supl("Hodina","Chybějící","Zastupující","Předmět","Učebna","Poznámka");
        }
    }

    public class Supl
    {
        public string Hodina;
        public string Chybejici;
        public string Poznamka;
        public string Predmet;
        public string Ucebna;
        public string Zastupujici;

        public Supl(string h, string ch, string z, string p, string u, string po)
        {
            Hodina = h;
            Chybejici = ch;
            Zastupujici = z;
            Predmet = p;
            Ucebna = u;
            Poznamka = po;
        }

        public Supl()
        {
        }
    }

}
