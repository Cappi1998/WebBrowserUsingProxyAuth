using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json;
using SteamAccountCreateHelper;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        public static Main _Form;

        public Main()
        {
            _Form = this;
            InitializeComponent();
        }

        public static string BaseDiretory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
        public static string ConfigDiretory = Path.Combine(BaseDiretory, "Config.json");

        public static ChromiumWebBrowser chrome;
        public static CefSettings settings = new CefSettings();

        public static List<ProxyOptions> ProxyList = new List<ProxyOptions>();
        public static ProxyOptions proxy;
        public static bool ProxySet = false;
        public static string ProxyFilePath = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            #region File_create_IfNoExist

            if (!File.Exists(ConfigDiretory))
            {
                Config usado = new Config { SingleProxyText=null, SingleProxtCkhecked=false, ProxyFilePath=null };

                File.WriteAllText(ConfigDiretory, JsonConvert.SerializeObject(usado, Formatting.Indented));
            }

            #endregion

            LoadConfig();

            settings.IgnoreCertificateErrors = true;
            var tete = Cef.Initialize(settings);
            txtUrl.Text = "meuip.com";
            chrome = new ChromiumWebBrowser(txtUrl.Text);
            this.panel1.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        void ChangerProxy(string URL)
        {
            if (!CheckProxyIsInput())
            {
                MessageBox.Show("Proxy no Input, Please Input Proxy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ProxySet)
            {
                if (ckUseSingleProxy.Checked)
                {
                    var split = txt_SingleProxy.Text.Split(':');
                    proxy = new ProxyOptions(split[0], split[1], split[2], split[3]);
                }
                else
                {
                    proxy = ProxyList[RandomUtils.GetRandomInt(0, ProxyList.Count)];
                    ProxyList.Remove(proxy);
                }

                CefSharpSettings.Proxy = proxy;
                var rc = chrome.GetBrowser().GetHost().RequestContext;

                Cef.UIThreadTaskFactory.StartNew(delegate {
                    rc.SetProxy($"{proxy.IP}:{proxy.Port}", out var error);
                });

                ProxySet = true;
            }

            chrome.Load(URL);
        }

        public bool CheckProxyIsInput()
        {

            if (!string.IsNullOrWhiteSpace(txt_SingleProxy.Text))
            {
                return true;
            }

            if (ProxyList.Count > 0)
                return true;

            return false;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                txtUrl.Text = e.Address;
            }));
        }

        private void btn_LoadPage_Click(object sender, EventArgs e)
        {
            ChangerProxy(txtUrl.Text);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
        }

        private void btn_Open_Proxy_File_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = "Open Text File";
                theDialog.Filter = "TXT files|*.txt";
                theDialog.InitialDirectory = Application.StartupPath;
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    ProxyFilePath = theDialog.FileName;

                    ProxyList.Clear();
                    var lista = File.ReadAllLines(theDialog.FileName);

                    foreach (var email in lista)
                    {
                        var split = email.Split(':');
                        var proxy = new ProxyOptions(split[0], split[1], split[2], split[3]);
                        ProxyList.Add(proxy);
                    }

                    lbl_ProxyLoad.Text = ProxyList.Count.ToString();
                    lbl_ProxyLoad.ForeColor = Color.DarkCyan;
                    lbl_ProxyLoad.Font = new Font("Arial", 10, FontStyle.Bold);
                    //Log.info(EMAIl_LIST.Count + " E-Mails Load!");
                    SaveConfig();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR To Read File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_ProxyLoad.Text = "ERROR";
                lbl_ProxyLoad.ForeColor = Color.Red;
            }
        }

        private void btn_OpenCriationPage_Click(object sender, EventArgs e)
        {
            ChangerProxy("https://store.steampowered.com/join/?l=english");
        }

        public static void LoadConfig()
        {
            if (File.Exists(ConfigDiretory))
            {
                try
                {
                    Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigDiretory));
                    if (!string.IsNullOrWhiteSpace(config.ProxyFilePath))
                    {
                        ProxyFilePath = config.ProxyFilePath;

                        ProxyList.Clear();
                        var lista = File.ReadAllLines(config.ProxyFilePath);
                        foreach (var item in lista)
                        {
                            var split = item.Split(':');
                            var proxy = new ProxyOptions(split[0], split[1], split[2], split[3]);
                            ProxyList.Add(proxy);
                        }

                        Main._Form.lbl_ProxyLoad.Text = ProxyList.Count.ToString();
                        Main._Form.lbl_ProxyLoad.ForeColor = Color.DarkCyan;
                        Main._Form.lbl_ProxyLoad.Font = new Font("Arial", 10, FontStyle.Bold);
                        //Log.info(Avatar_URL_List.Count + " Avatars Load!");
                    }

                    if (config.SingleProxtCkhecked)
                    {
                        Main._Form.ckUseSingleProxy.Checked = true;
                    }

                    if (!string.IsNullOrWhiteSpace(config.SingleProxyText))
                    {
                        Main._Form.txt_SingleProxy.Text = config.SingleProxyText;
                    }

                }
                catch (Exception ex)
                {
                    //Log.error($"Error to load Config: {ex.Message}");
                }
            }

        }

        public static void SaveConfig()
        {
            Config config = new Config();
            config.SingleProxtCkhecked = Main._Form.ckUseSingleProxy.Checked;
            config.SingleProxyText = Main._Form.txt_SingleProxy.Text;
            config.ProxyFilePath = ProxyFilePath;

            System.IO.File.WriteAllText(ConfigDiretory, JsonConvert.SerializeObject(config, Formatting.Indented));

            //Log.info("Config Save..");
        }

        private void txt_SingleProxy_Leave(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void ckUseSingleProxy_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}
