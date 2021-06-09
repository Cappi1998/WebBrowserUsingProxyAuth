
namespace WinFormsApp
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_LoadPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Open_Proxy_File = new System.Windows.Forms.Button();
            this.lbl_ProxyLoad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ckUseSingleProxy = new System.Windows.Forms.CheckBox();
            this.txt_SingleProxy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenCriationPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 504);
            this.panel1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(28, 59);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(365, 23);
            this.txtUrl.TabIndex = 1;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(399, 87);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(118, 23);
            this.btn_reload.TabIndex = 2;
            this.btn_reload.Text = "Reload Page";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_LoadPage
            // 
            this.btn_LoadPage.Location = new System.Drawing.Point(399, 58);
            this.btn_LoadPage.Name = "btn_LoadPage";
            this.btn_LoadPage.Size = new System.Drawing.Size(118, 23);
            this.btn_LoadPage.TabIndex = 3;
            this.btn_LoadPage.Text = "Go";
            this.btn_LoadPage.UseVisualStyleBackColor = true;
            this.btn_LoadPage.Click += new System.EventHandler(this.btn_LoadPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Open_Proxy_File);
            this.groupBox1.Controls.Add(this.lbl_ProxyLoad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(890, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Config";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP:Port:Username:Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Format Example:";
            // 
            // btn_Open_Proxy_File
            // 
            this.btn_Open_Proxy_File.Location = new System.Drawing.Point(20, 89);
            this.btn_Open_Proxy_File.Name = "btn_Open_Proxy_File";
            this.btn_Open_Proxy_File.Size = new System.Drawing.Size(164, 30);
            this.btn_Open_Proxy_File.TabIndex = 2;
            this.btn_Open_Proxy_File.Text = "Load Proxy from File";
            this.btn_Open_Proxy_File.UseVisualStyleBackColor = true;
            this.btn_Open_Proxy_File.Click += new System.EventHandler(this.btn_Open_Proxy_File_Click);
            // 
            // lbl_ProxyLoad
            // 
            this.lbl_ProxyLoad.AutoSize = true;
            this.lbl_ProxyLoad.ForeColor = System.Drawing.Color.Red;
            this.lbl_ProxyLoad.Location = new System.Drawing.Point(93, 19);
            this.lbl_ProxyLoad.Name = "lbl_ProxyLoad";
            this.lbl_ProxyLoad.Size = new System.Drawing.Size(27, 15);
            this.lbl_ProxyLoad.TabIndex = 1;
            this.lbl_ProxyLoad.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proyxs Load:";
            // 
            // ckUseSingleProxy
            // 
            this.ckUseSingleProxy.AutoSize = true;
            this.ckUseSingleProxy.Location = new System.Drawing.Point(610, 27);
            this.ckUseSingleProxy.Name = "ckUseSingleProxy";
            this.ckUseSingleProxy.Size = new System.Drawing.Size(113, 19);
            this.ckUseSingleProxy.TabIndex = 7;
            this.ckUseSingleProxy.Text = "Use Single Proxy";
            this.ckUseSingleProxy.UseVisualStyleBackColor = true;
            this.ckUseSingleProxy.Click += new System.EventHandler(this.ckUseSingleProxy_Click);
            // 
            // txt_SingleProxy
            // 
            this.txt_SingleProxy.Location = new System.Drawing.Point(610, 52);
            this.txt_SingleProxy.Name = "txt_SingleProxy";
            this.txt_SingleProxy.Size = new System.Drawing.Size(274, 23);
            this.txt_SingleProxy.TabIndex = 8;
            this.txt_SingleProxy.Leave += new System.EventHandler(this.txt_SingleProxy_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "https://store.steampowered.com/join/?l=english";
            // 
            // btn_OpenCriationPage
            // 
            this.btn_OpenCriationPage.Location = new System.Drawing.Point(299, 21);
            this.btn_OpenCriationPage.Name = "btn_OpenCriationPage";
            this.btn_OpenCriationPage.Size = new System.Drawing.Size(118, 23);
            this.btn_OpenCriationPage.TabIndex = 10;
            this.btn_OpenCriationPage.Text = "Go to Criation Page";
            this.btn_OpenCriationPage.UseVisualStyleBackColor = true;
            this.btn_OpenCriationPage.Click += new System.EventHandler(this.btn_OpenCriationPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "IP:Port:Username:Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Format Example:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_OpenCriationPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SingleProxy);
            this.Controls.Add(this.ckUseSingleProxy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_LoadPage);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "WebBrowserUsingProxyAuth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_LoadPage;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Open_Proxy_File;
        public System.Windows.Forms.Label lbl_ProxyLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckUseSingleProxy;
        public System.Windows.Forms.TextBox txt_SingleProxy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenCriationPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

