using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad_CS
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            
        }

        private void webBrowserSobre_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowserSobre = new WebBrowser();
            webBrowserSobre.Dock = DockStyle.Fill;
            webBrowserSobre.Navigate(Application.StartupPath + @"sobre\index.html");
            this.Controls.Add(webBrowserSobre);
        }
    }
}
