using LANHelper;
using LANHelper.Secrets;
using System;
using System.Windows.Forms;

namespace WOLClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void WakeDesktopButton_Click(object sender, EventArgs e)
        {
            await Communications.SendWakeupOnLanRequest(SecretKeys.DesktopMAC);
        }

        private async void SleepDesktopButton_Click(object sender, EventArgs e)
        {
            await Communications.SendSleepOnLanRequest(SecretKeys.DesktopMAC);
        }

        private async void WakeLaptopButton_Click(object sender, EventArgs e)
        {
            await Communications.SendWakeupOnLanRequest(SecretKeys.LaptopMAC);
        }

        private async void SleepLaptopButton_Click(object sender, EventArgs e)
        {
            await Communications.SendSleepOnLanRequest(SecretKeys.LaptopMAC);
        }
    }
}
