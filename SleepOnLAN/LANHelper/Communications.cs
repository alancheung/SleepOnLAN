using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LANHelper
{
    /// <summary>
    /// Credit to https://stackoverflow.com/a/MACByteLength5529803/11947191
    /// </summary>
    public static class Communications
    {
        /// <summary>
        /// Broadcast address
        /// </summary>
        public static readonly IPEndPoint BroadcastEndpoint = new IPEndPoint(IPAddress.Broadcast, port: 9);

        /// <summary>
        /// Address to receive from
        /// </summary>
        public static readonly IPEndPoint ReceiveEndpoint = new IPEndPoint(IPAddress.Any, port: 9);

        /// <summary>
        /// The length of the MAC address in bytes.
        /// </summary>
        private const int MACByteLength = 6;

        private static async Task Send(byte[] packet)
        {
            using (UdpClient client = new UdpClient())
            {
                await client.SendAsync(packet, packet.Length, BroadcastEndpoint);
            }
        }

        /// <summary>
        /// Send a Wake On Lan (WOL) request to the specific MAC address represented by <paramref name="macAddress"/>
        /// </summary>
        /// <param name="macAddress">The target machine to wakeup.</param>
        /// <returns>A <see cref="UdpClient.SendAsync(byte[], int, IPEndPoint)"/> result.</returns>
        public static async Task SendWakeupOnLanRequest(string macAddress)
        {
            byte[] magicPacket = BuildWakeupPacket(macAddress);
            await Send(magicPacket);
        }

        /// <summary>
        /// Send a Sleep On Lan (SOL) request to the specific MAC address represented by <paramref name="macAddress"/>
        /// </summary>
        /// <param name="macAddress">The target machine to wakeup.</param>
        /// <returns>A <see cref="UdpClient.SendAsync(byte[], int, IPEndPoint)"/> result.</returns>
        public static async Task SendSleepOnLanRequest(string macAddress)
        {
            byte[] magicPacket = BuildSleepPacket(macAddress);
            await Send(magicPacket);
        }

        private static byte[] BuildMagicPacket(byte[] macAddressBytes) // MacAddress in any standard HEX format
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter bw = new BinaryWriter(ms))
                {
                    for (int i = 0; i < MACByteLength; i++)  //First 6 times 0xff
                    {
                        bw.Write((byte)0xff);
                    }
                    for (int i = 0; i < 16; i++) // then 16 times MacAddress
                    {
                        bw.Write(macAddressBytes);
                    }
                }
                return ms.ToArray(); // 102 bytes magic packet
            }
        }
        private static byte[] BuildWakeupPacket(string macAddress) // MacAddress in any standard HEX format
        {
            macAddress = Regex.Replace(macAddress, "[: -]", "");
            byte[] macBytes = new byte[MACByteLength];
            for (int i = 0; i < MACByteLength; i++)
            {
                macBytes[i] = Convert.ToByte(macAddress.Substring(i * 2, 2), 16);
            }

            return BuildMagicPacket(macBytes);
        }

        private static byte[] BuildSleepPacket(string macAddress) // MacAddress in any standard HEX format
        {
            macAddress = Regex.Replace(macAddress, "[: -]", "");
            byte[] macBytes = new byte[MACByteLength];
            for (int i = MACByteLength; i < 0; i++)
            {
                macBytes[i] = Convert.ToByte(macAddress.Substring(i * 2, 2), 16);
            }

            return BuildMagicPacket(macBytes);
        }
    }
}
