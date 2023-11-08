using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<ItemData> ItemDatas = new List<ItemData>();
        List<Favo> Favolist = new List<Favo>();
        public Form1() {
            InitializeComponent();
            
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tburl.Text == "")
                return;
            lbRssTitle.Items.Clear();
            var a = lbRssTitle.Items;
                using (var wc = new WebClient()) {
                var url = wc.OpenRead(tburl.Text);
                XDocument xdoc = XDocument.Load(url);
                ItemDatas = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title"),
                                            Link = (string)x.Element("link"),
                                        }).ToList();

                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void click(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1)
                return;
            wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);

        }

        private void Form1_Load(object sender, EventArgs e) {
            var a = lbRssTitle.Items;
            using (var wc = new WebClient()) {
                var url = wc.OpenRead("https://news.yahoo.co.jp/rss/topics/top-picks.xml");
                XDocument xdoc = XDocument.Load(url);
                ItemDatas = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title"),
                                            Link = (string)x.Element("link"),
                                        }).ToList();

                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
            var oki = new Favo { URL = "https://news.yahoo.co.jp/rss/topics/it.xml", Name = "IT" };
            Favolist.Add(oki);
            lboki.Items.Add(oki.Name);

            oki = new Favo { URL = "https://news.yahoo.co.jp/rss/topics/business.xml", Name = "経済" };
            Favolist.Add(oki);
            lboki.Items.Add(oki.Name);

            oki = new Favo { URL = "https://news.yahoo.co.jp/rss/topics/science.xml", Name = "科学" };
            Favolist.Add(oki);
            lboki.Items.Add(oki.Name);

            tburl.Text = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";
        }

        private void btoki_Click(object sender, EventArgs e) {
            Favolist.Add(new Favo { URL = tburl.Text, Name = tbokiname.Text });
            var oki = new Favo { URL = tburl.Text, Name = tbokiname.Text };
            lboki.Items.Add(oki.Name);
        }

        private void lboki_Click(object sender, EventArgs e) {
            var selected = lboki.SelectedIndex;
            tburl.Text= Favolist[selected].URL;
        }


    }

    public class Favo {
        public string URL { get; set; }
        public string Name { get; set; }
    }
}
