using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace SetMACAdrress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadAdapters();
        }

        private void LoadAdapters()
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces()
                                           .Where(adapter => adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet);

            foreach (var adapter in adapters)
            {
                comboBoxAdapters.Items.Add(adapter.Name);
            }

            if (comboBoxAdapters.Items.Count > 0)
                comboBoxAdapters.SelectedIndex = 0; // Select the first item
        }

        // When a new adapter is selected, display its MAC address
        private void comboBoxAdapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAdapter = comboBoxAdapters.SelectedItem.ToString();
            var adapter = NetworkInterface.GetAllNetworkInterfaces()
                                          .FirstOrDefault(a => a.Name == selectedAdapter);

            if (adapter != null)
            {
                labelCurrentMac.Text = $"Current MAC: {string.Join(":", adapter.GetPhysicalAddress().GetAddressBytes().Select(b => b.ToString("X2")))}";
            }
        }

        // Validate if the new MAC address is in a valid format
        private bool IsValidMac(string mac)
        {
            var regex = new Regex(@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$");
            return regex.IsMatch(mac);
        }

        // Event handler for changing the MAC address
        private void btnChangeMac_Click(object sender, EventArgs e)
        {
            var selectedAdapter = comboBoxAdapters.SelectedItem.ToString();
            var adapter = NetworkInterface.GetAllNetworkInterfaces()
                                          .FirstOrDefault(a => a.Name == selectedAdapter);

            if (adapter == null)
            {
                MessageBox.Show("Please select a valid adapter.");
                return;
            }

            var newMac = textBoxNewMac.Text.Trim();

            if (!IsValidMac(newMac))
            {
                MessageBox.Show("Please enter a valid MAC address in the format XX:XX:XX:XX:XX:XX.");
                return;
            }

            try
            {
                ChangeMacAddress(adapter, newMac);
                MessageBox.Show("MAC Address changed successfully! Please restart the network adapter.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to change MAC address: {ex.Message}");
            }
        }

        // Function to change MAC address in the registry
        private void ChangeMacAddress(NetworkInterface adapter, string newMac)
        {
            string registryPath = @"SYSTEM\CurrentControlSet\Control\Class\{4D36E972-E325-11CE-BFC1-08002BE10318}";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, true))
            {
                foreach (string subkeyName in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkeyName, true))
                    {
                        var driverDesc = subkey.GetValue("DriverDesc") as string;

                        if (driverDesc != null && driverDesc == adapter.Description)
                        {
                            // Replace hyphens with no separators for registry format
                            string formattedMac = newMac.Replace(":", "").Replace("-", "").ToUpper();
                            subkey.SetValue("NetworkAddress", formattedMac);
                        }
                    }
                }
            }
        }
    }
}