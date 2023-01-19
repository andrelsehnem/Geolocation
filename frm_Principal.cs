using System;
using System.Windows.Forms;
using CefSharp.WinForms;

namespace Geolocation3
{
    public partial class frm_Principal : Form
    {
        private ChromiumWebBrowser chr;
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_url_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //txt_url.Text = $"C:/Users/Andr%C3%A9%20Luis/Desktop/geolocalizao/mapaAddress.html";
            txt_url.Text = $"file:///mapaAddress.html";
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            //primeiro precisa https://www.nuget.org/packages/CefSharp.WinForms/#readme-body-tab
            painel.Controls.Clear();
            chr = new ChromiumWebBrowser(txt_url.Text);
            var browser = chr;
            //se der erro aqui https://www.nuget.org/packages/CefSharp.Common.NETCore/

            painel.Controls.Add(browser);
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            painel.Controls.Clear();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            string _url = painel.Controls[0].ToString();
            chr.Refresh();

            painel.Controls.Clear();
            painel.Controls.Add(chr);   

        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 )
            {
                bt_go_Click(sender, EventArgs.Empty);
            }
        }

        private void frm_Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Equals(Keys.Enter))
            {
                bt_go_Click(sender, EventArgs.Empty);
            }
        }
    }
}
