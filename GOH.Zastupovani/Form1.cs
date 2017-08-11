using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using MaterialSkin;
using MaterialSkin.Controls;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace GOH.Zastupovani
{
    public partial class Main : MaterialForm
    {
        private const string UrlBase = @"http://suplovani.gytool.cz/";
        public static string HtmlCode;
        public static WebClient WebClient = new WebClient();
        public static Stream Stream;
        public static HtmlDocument HtmlDocument = new HtmlDocument();

        public static string CurrentClass = string.Empty;
        public static string CurrentDate = string.Empty;
        public static List<string> Dates = new List<string>();
        public static HtmlNodeCollection Rows;

        public static List<Supl> Suplovani = new List<Supl>();

        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            HtmlNode.ElementsFlags.Remove("option");
            GetDays();
            GetClasses();
        }


        private void FillDataGrid()
        {
            DataGrid.DataSource = null;
            DataGrid.Rows.Clear();
            foreach (var s in Suplovani)
            {
                var row = new[] {s.Hodina, s.Predmet, s.Ucebna, s.Chybejici, s.Zastupujici, s.Poznamka};
                DataGrid.Rows.Add(row);
            }
            Suplovani.Clear();
        }

        private void UpdateRows()
        {
            Rows?.Clear();
            Rows = GetAbsentRows(CurrentClass);
        }

        private void ParseAndClear()
        {
            if (Rows == null) return;
            foreach (var r in Rows)
            {
                var p = ParseRow(r);
                Suplovani.Add(p);
                r.Remove();
            }
        }

        private Supl ParseRow(HtmlNode node)
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

        private string ResolveUrl()
        {
            var url = UrlBase + CurrentDate;
            return url;
        }

        private HtmlNodeCollection GetAbsentRows(string trida)
        {
            Stream = WebClient.OpenRead(ResolveUrl());
            HtmlDocument.Load(Stream);
            var rows =
                HtmlDocument.DocumentNode.SelectNodes(
                    @"//html/body/table[1]/tr[3]/td/table[1]/tr/td/table[2]/tr[2]/td/table/tr/td[normalize-space(text())=" +
                    "\"" + trida + "\"" + "]/..");
            return rows;
        }

        private void GetDays()
        {
            Stream = WebClient.OpenRead("http://suplovani.gytool.cz/index_menu.html");
            HtmlDocument.Load(Stream);
            var options = HtmlDocument.DocumentNode.SelectNodes("//select/option");
            foreach (var o in options)
            {
                Dates.Add(o.GetAttributeValue("value", "0"));
                Date.Items.Add(o.InnerText);
            }

            CurrentDate = Dates.ToString();
        }

        private void GetClasses()
        {
            Stream = WebClient.OpenRead("http://rozvrh.gytool.cz/index_tr_menu.html");
            HtmlDocument.Load(Stream);
            var options = HtmlDocument.DocumentNode.SelectNodes("//select/option");
            foreach (var o in options)
            {
                var fixedstring = o.InnerText.Replace("&nbsp;&nbsp;", "");
                ClassComboBox.Items.Add(fixedstring);
            }
        }

        private void Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentDate = Dates[Date.SelectedIndex];
            if (ClassComboBox.SelectedItem == null)
            {
                return;
            }
            UpdateRows();
            ParseAndClear();
            FillDataGrid();
        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentClass = (string) ClassComboBox.SelectedItem;
            if (Date.SelectedItem == null)
            {
                return;
            }
            UpdateRows();
            ParseAndClear();
            FillDataGrid();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            var credits = new Credits();
            credits.Show();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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