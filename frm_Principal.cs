using CefSharp;
using CefSharp.Web;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace Littlemium
{
    public partial class frm_Principal : Form
    {
        private ChromiumWebBrowser chr;
        public frm_Principal()
        {

            InitializeComponent();
            painel.Controls.Clear();
            chr = new ChromiumWebBrowser("empty");
            painel.Controls.Add(chr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_url_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            chr.LoadUrl(txt_url.Text);
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            painel.Controls.Clear();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            chr.Reload();

        }

        private void txt_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            chr.FrameLoadEnd += Chr_FrameLoadEnd_bk;
        }

        private void bt_avancar_Click(object sender, EventArgs e)
        {
            chr.FrameLoadEnd += Chr_FrameLoadEnd_fw;
        }

        private void Chr_FrameLoadEnd_fw(object sender, FrameLoadEndEventArgs e)
        {
            chr.Forward();
        }

        private void Chr_FrameLoadEnd_bk(object sender, FrameLoadEndEventArgs e)
        {
            chr.Redo();
        }
    }
}
