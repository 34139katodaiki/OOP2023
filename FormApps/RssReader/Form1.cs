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
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            if (tburl.Text == "")
                return;
            lbRssTitle.Items
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
    }
}
