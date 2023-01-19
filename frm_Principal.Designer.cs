namespace Geolocation3
{
    partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel = new System.Windows.Forms.Panel();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.Location = new System.Drawing.Point(2, 34);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(797, 416);
            this.painel.TabIndex = 0;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(12, 5);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(680, 23);
            this.txt_url.TabIndex = 1;
            this.txt_url.TextChanged += new System.EventHandler(this.txt_url_TextChanged);
            this.txt_url.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_url_KeyPress);
            this.txt_url.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_url_MouseDoubleClick);
            // 
            // bt_go
            // 
            this.bt_go.Location = new System.Drawing.Point(706, 6);
            this.bt_go.Name = "bt_go";
            this.bt_go.Size = new System.Drawing.Size(23, 22);
            this.bt_go.TabIndex = 2;
            this.bt_go.Text = "▶";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(736, 6);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(23, 22);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "🗑";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(765, 6);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(23, 22);
            this.bt_refresh.TabIndex = 5;
            this.bt_refresh.Text = "🔃";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_go);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geolocalização";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_Principal_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_refresh;
    }
}
