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
        private List<string> Shortcuts = new List<string>();
        private string SaveLocation = "";
        private string InstallLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private readonly string[] YesChoices = { "yes", "yeah", "y", "true", "1" };
        private readonly string[] AllowedOptions = { "yes", "yeah", "y", "true", "1", "no", "nah", "n", "false", "0" };

        /// <summary>
        /// Uninstalls the application based on the existing options
        /// </summary>
        private void Uninstall()
        {
            if (!Directory.Exists(InstallLocation))
            {
                ConsoleUtils.FormattedWrite("Install location does not exist");
            }
            else if (!SaveData)
            {
                Uninstaller.UninstallApp(Shortcuts, InstallLocation);
                ConsoleUtils.FormattedWrite("Application successfully uninstalled");
            }
            else if (Directory.Exists(SaveLocation) || (!Directory.Exists(SaveLocation) &&
                YesChoices.Contains(ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Save Folder does not exist so installer will need to create one. Continue?"))))
            {
                Uninstaller.MoveApp(Shortcuts, InstallLocation, SaveLocation);
                ConsoleUtils.FormattedWrite("Application successfully uninstalled");
            }
            ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Shows the interface used to change the uninstaller settings
        /// </summary>
        private void ChangeSettings()
        {
            int menuOption = -1;
            while (menuOption != 6)
            {
                string input;
                List<string> settings = new List<string>() { "Change Shortcuts", "Install location", "Save data to specific location", "Display Settings", "Back" };
                if (SaveData)
                {
                    settings.Insert(2, "Save location");
                }

                ConsoleUtils.PrepNewScreen("Application Uninstaller");
                ConsoleUtils.CreateMenu(settings, "Settings:");
                menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: settings.Count, maxCharLength: 1, maxCharHeight: 1);

                // Set menu option if save location was not given
                if (!SaveData && menuOption >= 3)
                {
                    menuOption++;
                }
                ConsoleUtils.FormattedWrite();

                switch (menuOption)
                {
                    // Shortcuts
                    case 1:
                        menuOption = -1;
                        while (menuOption != Shortcuts.Count + 2)
                        {
                            // Prep Screen for choosing the executable
                            ConsoleUtils.PrepNewScreen("Application Uninstaller");
                            ConsoleUtils.CreateMenu(Shortcuts.Concat(new string[] { "Add", "Back" }).ToList());
                            menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: Shortcuts.Count + 2, maxCharHeight: 1);

                            // Add new shortcut
                            if (menuOption == Shortcuts.Count + 1)
                            {
                                ConsoleUtils.FormattedWrite();
                                Shortcuts.Add(ConsoleUtils.FancyGetInverseAllowedInput(Shortcuts, "Add Shortcut: ", "Shortcut must not already exist"));
                            }
                            // Remove existing shortcut
                            else if (menuOption != Shortcuts.Count + 2)
                            {
                                Shortcuts.RemoveAt(menuOption - 1);
                            }
                        }
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
                        
                    // Save data to specific location
                    case 4:
                        ConsoleUtils.FormattedWrite("Current Setting: " + SaveData);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Save data in a specific location? ", "Choice must be y/n", false);
                        SaveData = YesChoices.Contains(input.ToLower());
                        break;

                    // Display settings
                    case 5:
                        DisplaySettings();
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the current settings for the uninstaller
        /// </summary>
        private void DisplaySettings()
        {
            ConsoleUtils.FormattedWrite("Shortcuts: ");
            foreach (string shortcut in Shortcuts)
            {
                ConsoleUtils.FormattedWrite(" - " + shortcut);
            }
            ConsoleUtils.FormattedWrite("Install Location: " + InstallLocation);
            if (SaveData)
            {
                ConsoleUtils.FormattedWrite("Save Location: " + SaveLocation);
            }
            ConsoleUtils.FormattedWrite("Extra options:");
            if (SaveData)
            {
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
                ConsoleUtils.CreateMenu(new string[] { "Display Settings", "Change Settings", "Uninstall with current settings", "Back" });
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
