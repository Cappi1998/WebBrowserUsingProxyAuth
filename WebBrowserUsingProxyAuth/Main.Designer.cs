
namespace WebBrowserUsingProxyAuth
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
            this.btn_LoadPage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SingleProxy = new System.Windows.Forms.TextBox();
            this.ckUseSingleProxy = new System.Windows.Forms.CheckBox();
            this.btn_Open_Proxy_File = new System.Windows.Forms.Button();
            this.lbl_ProxyLoad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ChangerProxy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_PASS = new System.Windows.Forms.Label();
            this.lbl_USER = new System.Windows.Forms.Label();
            this.lbl_PORT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(12, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 491);
            this.panel1.TabIndex = 0;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(27, 35);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(454, 23);
            this.txtUrl.TabIndex = 1;
            // 
            // btn_LoadPage
            // 
            this.btn_LoadPage.Location = new System.Drawing.Point(487, 34);
            this.btn_LoadPage.Name = "btn_LoadPage";
            this.btn_LoadPage.Size = new System.Drawing.Size(118, 23);
            this.btn_LoadPage.TabIndex = 3;
            this.btn_LoadPage.Text = "Go";
            this.btn_LoadPage.UseVisualStyleBackColor = true;
            this.btn_LoadPage.Click += new System.EventHandler(this.btn_LoadPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SingleProxy);
            this.groupBox1.Controls.Add(this.ckUseSingleProxy);
            this.groupBox1.Controls.Add(this.btn_Open_Proxy_File);
            this.groupBox1.Controls.Add(this.lbl_ProxyLoad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(611, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Config";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "IP:Port:Username:Pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Format Example:";
            // 
            // txt_SingleProxy
            // 
            this.txt_SingleProxy.Location = new System.Drawing.Point(6, 50);
            this.txt_SingleProxy.Name = "txt_SingleProxy";
            this.txt_SingleProxy.Size = new System.Drawing.Size(274, 23);
            this.txt_SingleProxy.TabIndex = 14;
            // 
            // ckUseSingleProxy
            // 
            this.ckUseSingleProxy.AutoSize = true;
            this.ckUseSingleProxy.Location = new System.Drawing.Point(6, 25);
            this.ckUseSingleProxy.Name = "ckUseSingleProxy";
            this.ckUseSingleProxy.Size = new System.Drawing.Size(161, 19);
            this.ckUseSingleProxy.TabIndex = 13;
            this.ckUseSingleProxy.Text = "Use Single Rotating Proxy";
            this.ckUseSingleProxy.UseVisualStyleBackColor = true;
            // 
            // btn_Open_Proxy_File
            // 
            this.btn_Open_Proxy_File.Location = new System.Drawing.Point(316, 110);
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
            this.lbl_ProxyLoad.Location = new System.Drawing.Point(449, 91);
            this.lbl_ProxyLoad.Name = "lbl_ProxyLoad";
            this.lbl_ProxyLoad.Size = new System.Drawing.Size(27, 15);
            this.lbl_ProxyLoad.TabIndex = 1;
            this.lbl_ProxyLoad.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proyxs Load:";
            // 
            // btn_ChangerProxy
            // 
            this.btn_ChangerProxy.Location = new System.Drawing.Point(487, 67);
            this.btn_ChangerProxy.Name = "btn_ChangerProxy";
            this.btn_ChangerProxy.Size = new System.Drawing.Size(118, 23);
            this.btn_ChangerProxy.TabIndex = 13;
            this.btn_ChangerProxy.Text = "Changer Proxy";
            this.btn_ChangerProxy.UseVisualStyleBackColor = true;
            this.btn_ChangerProxy.Click += new System.EventHandler(this.btn_ChangerProxy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 14;
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_IP.Location = new System.Drawing.Point(49, 18);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(27, 15);
            this.lbl_IP.TabIndex = 15;
            this.lbl_IP.Text = "null";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "IP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "PORT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "USER:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "PASS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_PASS);
            this.groupBox2.Controls.Add(this.lbl_USER);
            this.groupBox2.Controls.Add(this.lbl_PORT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_IP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(27, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 92);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Proxy";
            // 
            // lbl_PASS
            // 
            this.lbl_PASS.AutoSize = true;
            this.lbl_PASS.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_PASS.Location = new System.Drawing.Point(49, 67);
            this.lbl_PASS.Name = "lbl_PASS";
            this.lbl_PASS.Size = new System.Drawing.Size(27, 15);
            this.lbl_PASS.TabIndex = 22;
            this.lbl_PASS.Text = "null";
            // 
            // lbl_USER
            // 
            this.lbl_USER.AutoSize = true;
            this.lbl_USER.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_USER.Location = new System.Drawing.Point(49, 49);
            this.lbl_USER.Name = "lbl_USER";
            this.lbl_USER.Size = new System.Drawing.Size(27, 15);
            this.lbl_USER.TabIndex = 21;
            this.lbl_USER.Text = "null";
            // 
            // lbl_PORT
            // 
            this.lbl_PORT.AutoSize = true;
            this.lbl_PORT.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_PORT.Location = new System.Drawing.Point(49, 33);
            this.lbl_PORT.Name = "lbl_PORT";
            this.lbl_PORT.Size = new System.Drawing.Size(27, 15);
            this.lbl_PORT.TabIndex = 20;
            this.lbl_PORT.Text = "null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Browser URL:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChangerProxy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_LoadPage);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "WebBrowserUsingProxyAuth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btn_LoadPage;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Open_Proxy_File;
        public System.Windows.Forms.Label lbl_ProxyLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ChangerProxy;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_SingleProxy;
        private System.Windows.Forms.CheckBox ckUseSingleProxy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label lbl_PASS;
        public System.Windows.Forms.Label lbl_USER;
        public System.Windows.Forms.Label lbl_PORT;
        private System.Windows.Forms.Label label3;
    }
}

