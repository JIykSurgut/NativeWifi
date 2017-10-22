using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Win32.Wifi;

namespace WindowsFormsNativeWifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WlanClient wlanClient = new WlanClient();
            wlanClient.Open();
            wlanClient.Interfaces[0].GetNetwork();

        }
    }
}
