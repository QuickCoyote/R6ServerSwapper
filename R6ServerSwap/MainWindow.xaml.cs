using System;
using System.IO;
using System.Linq;
using System.Windows;

namespace R6ServerSwap
{
    public partial class MainWindow : Window
    {
        string[] dataCenters = {
            "default",
            "australiaeast",
            "brazilsouth",
            "centralus",
            "eastasia",
            "eastus",
            "japaneast",
            "northeurope",
            "southafricanorth",
            "southcentralus",
            "southeastasia",
            "uaenorth",
            "westeurope",
            "westus"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string desiredDataCenter = dataCenters[comboBox1.SelectedIndex];

            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string basePath = userPath + "/Documents/My Games/Rainbow Six - Siege/";

            string[] allAccounts = Directory.GetDirectories(basePath);
            string[] gameSettingsLines = new string[0];

            foreach (string account in allAccounts)
            {
                string filePath = account + "\\GameSettings.ini";

                gameSettingsLines = File.ReadLines(filePath).ToArray();

                gameSettingsLines = gameSettingsLines.Select(line => line.Contains("DataCenterHint=") ? "DataCenterHint=playfab/" + desiredDataCenter : line).ToArray();

                File.Delete(account + "\\GameSettings.ini");
                File.WriteAllLines(account + "\\GameSettings.ini", gameSettingsLines);

                ConfirmationTextBlock.Text = "Changed Server To: " + comboBox1.SelectedValue;
            }
        }
    }
}
