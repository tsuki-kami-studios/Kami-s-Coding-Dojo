using System.Diagnostics;
using System.Net.NetworkInformation;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace HotspotCreator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter SSID for the hotspot: ");
            var ssid = Console.ReadLine();
            Console.Write("Enter password for the hotspot: ");
            var password = Console.ReadLine();
            Console.Write("Enter network band for the hotspot (2.4G or 5G): ");
            var band = Console.ReadLine();
            var startInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe", UseShellExecute = true, RedirectStandardInput = false,
                    Verb = "runas", // Run as administrator
                    Arguments = $"/C netsh wlan set hostednetwork mode=allow ssid={ssid} key={password} band={band} && netsh wlan start hostednetwork",
                };
            Process.Start(startInfo);
            // Show available netsh wlan options
            startInfo.Arguments = "/C netsh wlan /?";
            Process.Start(startInfo);
            // Get network interfaces
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var ni in interfaces)
                Console.WriteLine($"Name: {ni.Name}, Type: {ni.NetworkInterfaceType}, Status: {ni.OperationalStatus}");
        }
    }
}