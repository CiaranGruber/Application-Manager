using AppInstallerCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationManagerConsole
{
    /// <summary>
    /// Runs the uninstaller console program for the application manager
    /// </summary>
    public class ApplicationUninstaller
    {
        private bool SaveData = false;
        private string ShortcutName = "";
        private string SaveLocation = "";
        private string InstallLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private string[] YesChoices = { "yes", "yeah", "y", "true", "1" };
        private string[] AllowedOptions = { "yes", "yeah", "y", "true", "1", "no", "nah", "n", "false", "0" };

        private void Uninstall()
        {
            if (!Directory.Exists(InstallLocation))
            {
                ConsoleUtils.FormattedWrite("Install Location does not exist");
            }
            else if (!SaveData)
            {
                Uninstaller.UninstallApp(ShortcutName, InstallLocation);
            }
            else if (Directory.Exists(SaveLocation) || (!Directory.Exists(SaveLocation) &&
                YesChoices.Contains(ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Save Folder does not exist so installer will need to create one. Continue?"))))
            {
                Uninstaller.MoveApp(ShortcutName, InstallLocation, SaveLocation);
            }
        }

        private void ChangeSettings()
        {
            int menuOption = -1;
            while (menuOption != 5)
            {
                string input;
                List<string> settings = new List<string>() { "Shortcut name", "Install location", "Save data to specific location", "Back" };
                if (SaveData)
                {
                    settings.Insert(2, "Save location");
                }

                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(settings, "Settings:");
                menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: settings.Count, maxCharLength: 1, maxCharHeight: 1);

                // Set menu option if save location was not given
                if (!SaveData && menuOption == 3)
                {
                    menuOption++;
                }
                ConsoleUtils.FormattedWrite();

                switch (menuOption)
                {
                    // Shortcut name
                    case 1:
                        ConsoleUtils.FormattedWrite("Current Setting: " + ShortcutName);
                        ShortcutName = ConsoleUtils.FancyGetInput("Shortcut name: ");
                        break;

                    // Install location
                    case 2:
                        ConsoleUtils.FormattedWrite("Current Setting: " + InstallLocation);
                        InstallLocation = ConsoleUtils.FancyGetInput("Install location: ");
                        break;

                    // Save location
                    case 3:
                        ConsoleUtils.FormattedWrite("Current Setting: " + SaveLocation);
                        SaveLocation = ConsoleUtils.FancyGetInput("Save location: ");
                        break;

                    // Save data
                    case 4:
                        ConsoleUtils.FormattedWrite("Current Setting: " + SaveData);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Install for all users? (Requires admin) ", "Choice must be y/n", false);
                        SaveData = YesChoices.Contains(input.ToLower());
                        break;
                }
            }
        }

        private void DisplaySettings()
        {
            ConsoleUtils.FormattedWrite("Shortcut Name: " + ShortcutName);
            ConsoleUtils.FormattedWrite("Install Location: " + InstallLocation);
            if (SaveData)
            {
                ConsoleUtils.FormattedWrite("Save Location: " + SaveLocation);
                ConsoleUtils.FormattedWrite("Extra options:");
                ConsoleUtils.FormattedWrite(" - Save data");
            }
            ConsoleUtils.FormattedWrite();
            ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Starts the uninstaller program
        /// </summary>
        public void Start()
        {
            int menuOption = -1;
            Console.Title = "Application Uninstaller";

            while (menuOption != 4)
            {
                ConsoleUtils.PrepNewScreen("Application Uninstaller");
                ConsoleUtils.CreateMenu(new string[] { "Display Settings", "Change Settings", "Uninstall with current settings", "Close" });
                menuOption = ConsoleUtils.FancyGetInteger("Menu Option: ", "Option must be an integer", "Default", 1, 4, maxCharLength: 1, maxCharHeight: 1);

                switch (menuOption)
                {
                    case 1: // Display Settings
                        ConsoleUtils.FormattedWrite();
                        DisplaySettings();
                        break;
                    case 2: // Change settings
                        ChangeSettings();
                        break;
                    case 3: // Uninstall
                        Uninstall();
                        break;
                }
            }
        }
    }
}
