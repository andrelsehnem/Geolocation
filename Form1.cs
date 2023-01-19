using System;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace Geolocation3
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //primeiro precisa https://www.nuget.org/packages/CefSharp.WinForms/#readme-body-tab
            var browser = new ChromiumWebBrowser("https://www.google.com");
            //se der erro aqui https://www.nuget.org/packages/CefSharp.Common.NETCore/
            //this.Controls.Add(browser);
            painel.Controls.Add(browser);

        }
    }
}
