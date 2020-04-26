using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using Microsoft.Win32;
using System.Threading;

namespace CostScaner
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer timer;
        private static HttpClient client = new HttpClient();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGrid();
            timer = new System.Timers.Timer(3000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            timer.Enabled = false;
            updateOzon();
            updateOnTrade();
            updateCitilink();
            updateRegard();
            updateDns();
            updateYandex();
            updateNix();
        }

        private void InitializeDataGrid()
        {
            dataGridView1.Rows.Add();//ozon
            dataGridView1.Rows.Add();//online trade
            dataGridView1.Rows.Add();//citilink
            dataGridView1.Rows.Add();//regard
            dataGridView1.Rows.Add();//dns
            dataGridView1.Rows.Add();//yandex
            dataGridView1.Rows.Add();//nix
            dataGridView1.Rows[0].Cells[0].Value = "Ozon";
            dataGridView1.Rows[1].Cells[0].Value = "Online trade";
            dataGridView1.Rows[2].Cells[0].Value = "Citilink";
            dataGridView1.Rows[3].Cells[0].Value = "Regard";
            dataGridView1.Rows[4].Cells[0].Value = "DNS";
            dataGridView1.Rows[5].Cells[0].Value = "Yandex Market";
            dataGridView1.Rows[6].Cells[0].Value = "Nix";
        }

        private void updateOzon()//0
        {
            int rowNumber = 0;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromOzon("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromOzon("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromOzon("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromOzon("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromOzon("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromOzon("" + counter++);
        }
        private void updateOnTrade()//1
        {
            int rowNumber = 1;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromOnTrade("https://www.onlinetrade.ru/catalogue/materinskie_platy-c340/asus/materinskaya_plata_asus_rog_strix_x570_f_gaming_am4_atx-1852465.html");
            //dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromOnTrade("");
            //dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromOnTrade("");
            //dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromOnTrade("");
            //dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromOnTrade("");
            //dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromOnTrade("");
        }
        private void updateCitilink()//2
        {
            int rowNumber = 2;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromCitilink("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromCitilink("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromCitilink("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromCitilink("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromCitilink("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromCitilink("" + counter++);
        }
        private void updateRegard()//3
        {
            int rowNumber = 3;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromRegard("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromRegard("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromRegard("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromRegard("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromRegard("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromRegard("" + counter++);
        }
        private void updateDns()//4
        {
            int rowNumber = 4;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromDns("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromDns("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromDns("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromDns("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromDns("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromDns("" + counter++);
        }
        private void updateYandex()//5
        {
            int rowNumber = 5;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromYandex("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromYandex("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromYandex("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromYandex("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromYandex("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromYandex("" + counter++);
        }
        private void updateNix()//6
        {
            int rowNumber = 6;
            dataGridView1.Rows[rowNumber].Cells[1].Value = getCostFromNix("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[2].Value = getCostFromNix("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[3].Value = getCostFromNix("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[4].Value = getCostFromNix("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[5].Value = getCostFromNix("" + counter++);
            dataGridView1.Rows[rowNumber].Cells[6].Value = getCostFromNix("" + counter++);
        }

        private string getCostFromOzon(string url)
        {
            return "ozon cost" + url;
        }
        private string getCostFromOnTrade(string url)
        {
            //HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            //HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            //var nodes = doc.DocumentNode.SelectNodes("//*[contains(@itemprop,'price')]");
            string response = GetDinamycResponse(url).Result;
            //var doc1 = new XmlDocument();
            //doc1.LoadXml(response);
            //var elem = doc.DocumentElement;
            //var sel = elem.SelectNodes("//*[contains(@itemprop,'price')]");
            return "";

        }
        private string getCostFromCitilink(string url)
        {
            return "citilink cost" + url;
        }
        private string getCostFromRegard(string url)
        {
            return "regard cost" + url;
        }
        private string getCostFromDns(string url)
        {
            return "dns cost" + url;
        }
        private string getCostFromYandex(string url)
        {
            return "yandex cost" + url;
        }
        private string getCostFromNix(string url)
        {
            return "nix cost" + url;
        }

        private async Task<string> getResponse(string url)
        {
            string responseStr = "";
            //client.DefaultRequestHeaders.Add("User-Agent", "Mozilla /5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.113 Safari/537.36");
            //client.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");
            //client.DefaultRequestHeaders.Add("Sec-Fetch-User", "?1");
            //client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
            //client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "navigate");
            //client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "document");
            //client.DefaultRequestHeaders.Add("Referer", "https://www.onlinetrade.ru/catalogue/materinskie_platy-c340/asus/materinskaya_plata_asus_rog_strix_x570_f_gaming_am4_atx-1852465.html");
            //client.DefaultRequestHeaders.Add("If-Modified-Since", "Thu, 23 Apr 2020 10:36:32 GMT");//????
            //client.DefaultRequestHeaders.Add("Host", "www.onlinetrade.ru");
            //client.DefaultRequestHeaders.Add("Cookie", "onlinetrade=1d83d42e0bfe4f17556e3867ed270092; session_id=f4c8488a43762a7944e76d7c0a46f668; rerf=AAAAAF6YV7Vv0oZaAyIfAg==; ipp_uid2=4DIFOGuQnNTTbvGx/QPpN7hqdVpFnJ4APvWytIg==; ipp_uid1=1587042228439; ipp_uid=1587042228439/4DIFOGuQnNTTbvGx/QPpN7hqdVpFnJ4APvWytIg==; _ym_d=1587042229; _ym_uid=1587042229825787409; _gcl_au=1.1.1395012529.1587042230; __utmc=77444427; user_c=50; user_city=3; items_per_page=36; __utmz=77444427.1587049033.4.4.utmcsr=google|utmccn=(organic)|utmcmd=organic|utmctr=(not%20provided); ipp_static_key=1587454639526/tokLcQvIR1yluk3r1e5k3A==; _ym_isad=2; sort=price-asc; views=1852465%2C1859967%2C1860069%2C1857439%2C1972666%2C1047058%2C1584477%2C1849855%2C1849853; _ym_visorc_234640=w; __utma=77444427.589069110.1587042230.1587634564.1587637495.13; ipp_sign=d86ad2d96b52724911600b6ebef173f4_2047739740_825262e104d107c6fd63722d59a22042; ipp_key=v1587638190693/v3394bd400b5e53a13cfc65163aeca6afa04ab3/SUxN3nJnCmQo+ERE+IBgrQ==; __utmt_UA-24629835-1=1; __utmb=77444427.4.10.1587637495");
            //client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            //client.DefaultRequestHeaders.Add("Cache-Control", "max-age=0");
            //client.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            //client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            //client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                responseStr = await response.Content.ReadAsStringAsync();
            }
            return responseStr;
        }



        private async Task<string> GetDinamycResponse(string url)
        {
            try
            {
                var cts = new CancellationTokenSource(10000);
                var html = await LoadDynamicPage(url, cts.Token);
                return "" + (html == null || html.Length == 0);
            }
            catch(Exception)
            {
                return "";
            }
        }

        async Task<string> LoadDynamicPage(string url, CancellationToken token)
        {
            // navigate and await DocumentCompleted
            var tcs = new TaskCompletionSource<bool>();
            WebBrowserDocumentCompletedEventHandler handler = (s, arg) =>
                tcs.TrySetResult(true);

            using (token.Register(() => tcs.TrySetCanceled(), useSynchronizationContext: true))
            {
                this.webBrowser.DocumentCompleted += handler;
                try
                {
                    this.webBrowser.Navigate(url);
                    await tcs.Task; // wait for DocumentCompleted
                }
                finally
                {
                    try
                    {
                        this.webBrowser.DocumentCompleted -= handler;
                    }
                    catch { }
                }
            }

            // get the root element
            var documentElement = this.webBrowser.Document.GetElementsByTagName("html")[0];

            // poll the current HTML for changes asynchronosly
            var html = documentElement.OuterHtml;
            while (true)
            {
                // wait asynchronously, this will throw if cancellation requested
                await Task.Delay(500, token);

                // continue polling if the WebBrowser is still busy
                if (this.webBrowser.IsBusy)
                    continue;

                var htmlNow = documentElement.OuterHtml;
                if (html == htmlNow)
                    break; // no changes detected, end the poll loop

                html = htmlNow;
            }

            // consider the page fully rendered 
            token.ThrowIfCancellationRequested();
            return html;
        }

        // enable HTML5 (assuming we're running IE10+)
        // more info: https://stackoverflow.com/a/18333982/1768303
        static void SetFeatureBrowserEmulation()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
                appName, 10000, RegistryValueKind.DWord);
        }
    }
}
