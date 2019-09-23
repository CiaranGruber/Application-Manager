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
    /// Runs the installer console program for the application manager
    /// </summary>
    public class ApplicationInstaller
    {
        private bool HasFolder = false;
        private bool AdminInstall = false;
        private bool CreateDesktopShortcut = false;
        private bool InstallLocationModified = false;
        private string InstallLocation;
        private string ExecutableName = "";
        private string ShortcutName = "";
        private string ProgramLocation = "";
        private string[] YesChoices = { "yes", "yeah", "y", "true", "1" };
        private string[] AllowedOptions = { "yes", "yeah", "y", "true", "1", "no", "nah", "n", "false", "0" };

        private void ChangeInstallLocation()
        {
            if (!InstallLocationModified)
            {
                // Choose folder depending on admin access
                InstallLocation = Environment.GetFolderPath(AdminInstall ? Environment.SpecialFolder.ProgramFilesX86 : Environment.SpecialFolder.LocalApplicationData);

                // Choose rest of location depending on folder usage
                InstallLocation = Path.Combine(InstallLocation, HasFolder ? Path.GetFileName(ProgramLocation) : Path.GetFileNameWithoutExtension(ExecutableName));
                InstallLocationModified = false;
            }
        }

        private void Install()
        {
            if (File.Exists(Path.Combine(InstallLocation, ExecutableName)))
            {
                ConsoleUtils.FormattedWrite("Application already exists at selected location");
            }
            else if (!File.Exists(Path.Combine(ProgramLocation, ExecutableName)))
            {
                ConsoleUtils.FormattedWrite("Executable located at \"" + Path.Combine(ProgramLocation, ExecutableName) + "\" does not exist");
            }
            else if (!Directory.Exists(ProgramLocation))
            {
                ConsoleUtils.FormattedWrite("Program folder directory does not exist");

            }
            else if (Directory.Exists(InstallLocation) || (!Directory.Exists(InstallLocation) && 
                YesChoices.Contains(ConsoleUtils.FancyGetAllowedInput(AllowedOptions,
                "Installer will be required to create a new directory. Continue? ", isCaseSensitive: false).ToLower())))
            {
                Installer.InstallApp(ExecutableName, ShortcutName, ProgramLocation, InstallLocation, HasFolder, CreateDesktopShortcut, AdminInstall);
                ConsoleUtils.FormattedWrite("Application successfully installed");
                ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
                Console.CursorVisible = false;
                Console.ReadKey(true);
                Console.CursorVisible = true;
            }
        }

        private void ChangeSettings()
        {
            int menuOption = -1;
            while (menuOption != 8)
            {
                string input;

                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(new string[] { HasFolder ? "Executable path (from program location)" : "Executable name", "Shortcut name", "Program location", "Installation location",
                    "Contained in app folder", "Install for all users? (Requires admin)", "Create desktop shortcut", "Back" }, "Settings:");
                menuOption = ConsoleUtils.FancyGetInteger("Menu choice: ", minValue: 1, maxValue: 8, maxCharLength: 1, maxCharHeight: 1);
                ConsoleUtils.FormattedWrite();

                switch (menuOption)
                {
                    // Executable name
                    case 1:
                        ConsoleUtils.FormattedWrite("Current Setting: " + ExecutableName);
                        ExecutableName = ConsoleUtils.FancyGetInput(HasFolder ? "Executable path (from program location)" : "Executable name: ");
                        ChangeInstallLocation();
                        break;

                    // Shortcut name
                    case 2:
                        ConsoleUtils.FormattedWrite("Current Setting: " + ShortcutName);
                        ShortcutName = ConsoleUtils.FancyGetInput("Shortcut name: ");
                        break;

                    // Program location
                    case 3:
                        ConsoleUtils.FormattedWrite("Current Setting: " + ProgramLocation);
                        ProgramLocation = ConsoleUtils.FancyGetInput("Program location: ");
                        ChangeInstallLocation();
                        break;

                    // Installation location
                    case 4:
                        ConsoleUtils.FormattedWrite("Current Setting: " + InstallLocation);
                        InstallLocation = ConsoleUtils.FancyGetInput("Installation location: ");
                        InstallLocationModified = true;
                        break;

                    // Contained in app folder
                    case 5:
                        ConsoleUtils.FormattedWrite("Current Setting: " + HasFolder);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Contained in app folder? ", "Choice must be y/n", false);
                        HasFolder = YesChoices.Contains(input.ToLower());
                        ChangeInstallLocation();
                        break;

                    // Install for all users
                    case 6:
                        ConsoleUtils.FormattedWrite("Current Setting: " + AdminInstall);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Install for all users? (Requires admin) ", "Choice must be y/n", false);
                        HasFolder = YesChoices.Contains(input.ToLower());
                        InstallLocationModified = false;
                        ChangeInstallLocation();
                        break;

                    // Create desktop shortcut
                    case 7:
                        ConsoleUtils.FormattedWrite("Current Setting: " + CreateDesktopShortcut);
                        input = ConsoleUtils.FancyGetAllowedInput(AllowedOptions, "Create desktop shortcut? ", "Choice must be y/n", false);
                        HasFolder = YesChoices.Contains(input.ToLower());
                        break;
                }
            }
        }

        public void DisplaySettings()
        {
            ConsoleUtils.FormattedWrite("Executable Name: " + ExecutableName);
            ConsoleUtils.FormattedWrite("Shortcut Name: " + ShortcutName);
            ConsoleUtils.FormattedWrite("Program Location: " + ProgramLocation);
            ConsoleUtils.FormattedWrite("Installation Location: " + InstallLocation);
            ConsoleUtils.FormattedWrite("Extra options:");
            if (HasFolder)
            {
                ConsoleUtils.FormattedWrite(" - Contained in app folder");
            }
            if (AdminInstall)
            {
                ConsoleUtils.FormattedWrite(" - Folder made with admin priviledges");
            }
            if (CreateDesktopShortcut)
            {
                ConsoleUtils.FormattedWrite(" - Create a desktop shortcut");
            }
            ConsoleUtils.FormattedWrite();
            ConsoleUtils.FormattedWrite("Press any key to continue...", new FormattedWriteSettings() { NewLine = false });
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Starts the installer program
        /// </summary>
        public void Start()
        {
            int menuOption = -1;
            Console.Title = "Application Installer";
            ChangeInstallLocation();

            while (menuOption != 4)
            {
                ConsoleUtils.PrepNewScreen("Application Installer");
                ConsoleUtils.CreateMenu(new string[] { "Display Settings", "Change Settings", "Install with current settings", "Close" });
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
                    case 3:
                        Install();
                        break;
                }
            }
        }
    }
}
