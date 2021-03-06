using LANHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SleepOnLanService
{
    public partial class SleepOnLanService : ServiceBase
    {
        private UdpClient _udpClient;

        public SleepOnLanService()
        {
            InitializeComponent();
            _udpClient = new UdpClient();
            _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _udpClient.ExclusiveAddressUse = false; // only if you want to send/receive on same machine.
            IPEndPoint endpoint = Communications.ReceiveEndpoint;
            _udpClient.Client.Bind(endpoint);
        }

        protected override void OnStart(string[] args)
        {
            ServiceStart(args);
        }

        protected override void OnStop()
        {
            ServiceStop();
        }

        /// <summary>
        /// <see cref="ServiceBase.OnStart(string[])"/>
        /// </summary>
        internal void ServiceStart(string[] args)
        {
            _udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);
        }

        /// <summary>
        /// <see cref="ServiceBase.OnStop"/>
        /// </summary>
        internal void ServiceStop()
        {
            _udpClient?.Close();
            _udpClient?.Dispose();
            _udpClient = null;
        }

        private void ReceiveCallback(IAsyncResult result)
        {
            IPEndPoint endpoint = Communications.BroadcastEndpoint;
            byte[] received = _udpClient.EndReceive(result, ref endpoint);
            _udpClient.BeginReceive(new AsyncCallback(ReceiveCallback), null);

            Console.WriteLine(Encoding.UTF8.GetString(received));
        }
    }
}
