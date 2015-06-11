using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skbtInstaller
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            this.linkLabel1.Links.Add(206, 26, @"http://epochmod.com/forum/index.php?/topic/29149-release-server-keepalive-batch-tool/");
            this.linkLabel1.Links.Add(234, 19, @"https://github.com/uniflare/skbtforarma");
            this.linkLabel1.Links.Add(253, 22, @"https://sourceforge.net/projects/skbtforarma/");
            this.lblAboutTitle.Text = this.lblAboutTitle.Text + "v" + skbtCoreConfig.strVersion;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
