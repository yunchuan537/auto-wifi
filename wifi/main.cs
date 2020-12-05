using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using System.Threading;
using System.Net;
using NativeWifi;

namespace wifi
{
    public partial class main : Form
    {

        private WlanClient.WlanInterface WlanIface;
        private List<Wlan.WlanAvailableNetwork> NetWorkList = new List<Wlan.WlanAvailableNetwork>();
        private bool isDealing = false; //处理中


        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WlanClient client = new WlanClient();
            WlanIface = client.Interfaces[0];//一般就一个网卡，有2个没试过。

            Tick(sender, e);
            this.TimerCounter.Start();
        }

        private void TimerCounter_Tick(object sender, System.EventArgs e)
        {
            Tick(sender, e);
        }

        private void Tick(object sender, System.EventArgs e)
        {
            this.CurrentTime.Text = DateTime.Now.ToLocalTime().ToString();

            Wlan.WlanAvailableNetwork[] networks = WlanIface.GetAvailableNetworkList(0);
            foreach (Wlan.WlanAvailableNetwork network in networks)
            {
                string SSID = WlanHelper.GetStringForSSID(network.dot11Ssid);
                if (!SSID.Contains("?") && SSID.Length > 0)
                {
                    if (network.flags.HasFlag(Wlan.WlanAvailableNetworkFlags.Connected))
                    {
                        this.CurrentWifi.Text = SSID;
                    }
                    //如果有配置文件的SSID会重复出现。过滤掉
                    if (!WifiList.Items.Contains(SSID))
                    {
                        WifiList.Items.Add(SSID);
                        NetWorkList.Add(network);
                    }
                }
                
            }

            checkConnection();
        }

        private void checkConnection()
        {
            if (isDealing)
            {
                return;
            }

            if (!WlanHelper.IsConnectedInternet())
            {
                this.Ping.Text = "无网络";
                ReconnectWifi();
                return;
            }

            try
            {
                IPAddress[] addresslist = Dns.GetHostAddresses("www.baidu.com");
                if (addresslist[0].ToString().Length > 6)
                {
                    this.Ping.Text = "畅通";
                }
                else
                {
                    this.Ping.Text = "--";
                    ReconnectWifi();
                }
            }
            catch
            {
                this.Ping.Text = "无外网";
                ReconnectWifi();
            }
        }

        //重连wifi，分为3步：
        // ipconfig /release
        // ipconfig /renew
        // AutoConnect
        private void ReconnectWifi()
        {
            //如果没有外网，就断开重连
            isDealing = true;
            Console.WriteLine("断开网络");
            WlanHelper.DisConnect();
            Console.WriteLine("重新获取网络");
            WlanHelper.ReConnect();
            Console.WriteLine("自动连接");
            WlanHelper.SetAutoConnect(this.CurrentWifi.Text);
            isDealing = false;
        }

    }
}
