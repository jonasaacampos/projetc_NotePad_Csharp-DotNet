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
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
            webBrowser.Navigate("https://jonasaacampos.github.io/projetc_NotePad_Csharp-DotNet/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
